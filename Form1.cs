using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using Microsoft.Win32;

namespace LocoNetMon
{
    public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };

    public partial class LocoNetMon : Form
    {
        const int MaxPatterns = 20;

        private     // ===========================================================================

        const string LocoNetMonVersion = "1.3";
        const string MinorVersion      = "1";
        
        BinaryWriter captureFile                = null;
        BinaryReader loadedCaptureFile          = null;
        BinaryWriter ppvFileOutput              = null;
        BinaryReader ppvFileInput               = null;
        bool         fFileOpen                  = false;
        string       szCOMportLocoNet           = null;
        int          iBAUDrateLocoNet           = 0;
        string       szCOMportDCC               = null;
        RegistryKey  RailNetKey                 = null;
        string       szSaveFileName             = null;
        string       szPpvFileName              = null;
        string       szLoadedFileName           = null;
        int          iCheckSumErrors            = 0;
        int          iBytesReceived             = 0;
        int          iPacketsReceived           = 0;
        int          iPacketsCaptured           = 0;
        bool         fStartPatternMatch         = false;
        bool         fFirstPatternDetected      = false;
        long         lLastTicksObtained         = 0;
        int          iCurrentPattern            = 0;
        bool         fppvDurationErrorDisplayed = false;

        ComboBox      [] ppvOpCodeArray   = new ComboBox     [MaxPatterns];
        NumericUpDown [] ppvAddressArray  = new NumericUpDown[MaxPatterns];
        NumericUpDown [] ppvDurationArray = new NumericUpDown[MaxPatterns];
        CheckBox      [] ppvOnOffArray    = new CheckBox     [MaxPatterns];
        Label         [] ppvLabelArray    = new Label        [MaxPatterns];

        // The main control for communicating through the RS-232 port
        //
        SerialPort comport    = new SerialPort();
        SerialPort comportDCC = new SerialPort();

        // Work buffer used to store serial data read in
        //
        byte[] SerialBuffer = new byte[1024];

        // Various colors for logging info
        //
        Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fFileOpen == true)
                captureFile.Close();

            if (RailNetKey != null)
            {
                RailNetKey.SetValue("COMportLocoNet", szCOMportLocoNet);
                RailNetKey.SetValue("BAUDrate", iBAUDrateLocoNet);
                RailNetKey.SetValue("COMportDCC", szCOMportDCC);
                RailNetKey.SetValue("SaveFileName", szSaveFileName);
                RailNetKey.SetValue("ppvFileName", szPpvFileName);
                RailNetKey.Close();
            }

            System.Windows.Forms.Application.Exit();
        }

        void BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortLocoNet.BaudRate = Convert.ToInt32(BaudRateLocoNet.Text);
            iBAUDrateLocoNet = serialPortLocoNet.BaudRate;

            if (comport.IsOpen)
            {
                comport.Close();

                // Set the port's settings
                //
                comport.BaudRate = iBAUDrateLocoNet;
                comport.PortName = szCOMportLocoNet;
                comport.RtsEnable = false;
                comport.Handshake = System.IO.Ports.Handshake.RequestToSend;

                try
                {
                    comport.Open(); // Open the port
                }
                catch
                {
                    MessageBox.Show("Unable to open COM port");
                    return;
                }

                // If the port is open, send focus to the send data box
                if (comport.IsOpen)
                {
                    rtf_disCapture.Focus();
                    disStartContinue.Enabled = false;
                    disPause.Enabled = true;
                }
            }
        }

        void COMport_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortLocoNet.PortName = COMportLocoNet.Text;
            szCOMportLocoNet = COMportLocoNet.Text;

            if (comport.IsOpen)
            {
                comport.Close();

                // Set the port's settings
                //
                comport.BaudRate  = iBAUDrateLocoNet;
                comport.PortName  = szCOMportLocoNet;
                comport.RtsEnable = false;
                comport.Handshake = System.IO.Ports.Handshake.RequestToSend;

                try
                {
                    comport.Open(); // Open the port
                }
                catch
                {
                    MessageBox.Show("Unable to open COM port");
                    return;
                }

                // If the port is open, send focus to the send data box
                if (comport.IsOpen)
                {
                    rtf_disCapture.Focus();
                    disStartContinue.Enabled = false;
                    disPause.Enabled = true;
                }
            }
        }

        void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fFileOpen)
            {
                MessageBox.Show("File currently open, close file first");
                return;
            }

            saveFileDialog1.FileName   = szSaveFileName;
            saveFileDialog1.DefaultExt = ".loc";
            saveFileDialog1.Filter     = "LocoNet Capture Files (*.loc)|*.loc|All files (*.*)|*.*";
            DialogResult buttonClicked = saveFileDialog1.ShowDialog();

            if (buttonClicked.Equals(DialogResult.OK))
            {
                Stream captureFileName = saveFileDialog1.OpenFile();
                captureFile = new BinaryWriter(captureFileName);

                if (captureFile != null)
                {
                    captureFile.Write(LocoNetMonVersion);
                    szSaveFileName = saveFileDialog1.FileName;
                    fFileOpen = true;
                    disCaptureFile.Text = szSaveFileName;
                    rtf_disCapture.Clear();
                    rtf_disDetail.Clear();
                    iCheckSumErrors = 0;
                    iBytesReceived = 0;
                    iPacketsReceived = 0;
                    iPacketsCaptured = 0;
                    disStartContinue.Enabled = true;
                    disButtonReScan.Enabled = false;
                    disButtonReScan.Visible = false;
                    ppvButtonReScan.Enabled = false;
                    ppvButtonReScan.Visible = false;
                }
            }
        }

        void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the port is open, close it.
            //
            if (comport.IsOpen)
                comport.Close();

            if (fFileOpen)
                captureFile.Close();

            fFileOpen = false;

            iPacketsReceived         = 0;
            iBytesReceived           = 0;
            iCheckSumErrors          = 0;
            disCaptureFile.Text      = " ";
            disPacketsReceived.Text  = " ";
            disBytesReceived.Text    = " ";
            disChecksumErrors.Text   = " ";
            disStartContinue.Enabled = true;
            disPause.Enabled         = false;
            disButtonReScan.Enabled  = false;
            disButtonReScan.Visible  = false;
            ppvButtonReScan.Enabled  = false;
            ppvButtonReScan.Visible  = false;
        }

        void LocoNetMon_Load(object sender, EventArgs e)
        {
            // Attempt to open the key
            //
            RailNetKey = Registry.CurrentUser.OpenSubKey("Software\\RailNet\\LocoNetMon", true);

            // If the return value is null, the key doesn't exist
            //
            if (RailNetKey == null)
            {
                // The key doesn't exist; create it / open it, and save default values
                //
                RailNetKey = Registry.CurrentUser.CreateSubKey("Software\\RailNet\\LocoNetMon");
                RailNetKey.SetValue( "COMportLocoNet",  "COM1" );
                RailNetKey.SetValue( "BAUDrateLocoNet", 57600  );
                RailNetKey.SetValue( "COMportDCC",      "COM2" );
            }
            else
            {
                // Attempt to retrieve the COM port values; if null is returned, the value
                // doesn't exist in the registry (set it to its default value).
                //
                if (RailNetKey.GetValue("COMportLocoNet") == null)
                {
                    RailNetKey.SetValue("COMportLocoNet", "COM1");
                    szCOMportLocoNet = "COM1";
                }
                else
                {
                    // The value exists; move the form to the coordinates stored in the
                    // registry.
                    //
                    szCOMportLocoNet = (string)RailNetKey.GetValue("COMportLocoNet");
                }

                if (RailNetKey.GetValue("COMportDCC") == null)
                {
                    RailNetKey.SetValue("COMportDCC", "COM2");
                    szCOMportDCC = "COM2";
                }
                else
                {
                    // The value exists; move the form to the coordinates stored in the
                    // registry.
                    //
                    szCOMportDCC = (string)RailNetKey.GetValue("COMportDCC");
                }

                if (RailNetKey.GetValue("BAUDrate") == null)
                {
                    RailNetKey.SetValue("BAUDrate", 56700);
                    iBAUDrateLocoNet = 56700;
                }
                else
                {
                    // The value exists; move the form to the coordinates stored in the
                    // registry.
                    //
                    iBAUDrateLocoNet = (int)RailNetKey.GetValue("BAUDrate");
                }

                if (RailNetKey.GetValue("SaveFileName") == null)
                {
                    RailNetKey.SetValue("SaveFileName", "LocoNet.loc");
                    szSaveFileName = "LocoNet.loc";
                }
                else
                {
                    // The value exists; move the form to the coordinates stored in the
                    // registry.
                    //
                    szSaveFileName = (string)RailNetKey.GetValue("SaveFileName");
                }
                
                if (RailNetKey.GetValue("ppvFileName") == null)
                {
                    RailNetKey.SetValue("ppvFileName", "PatternPacketVerifier.ppv");
                    szPpvFileName = "PatternPacketVerifier.ppv";
                }
                else
                {
                    // The value exists; move the form to the coordinates stored in the
                    // registry.
                    //
                    szPpvFileName = (string)RailNetKey.GetValue("ppvFileName");
                }
            }

            COMportLocoNet.Text = szCOMportLocoNet;
            BaudRateLocoNet.Text = iBAUDrateLocoNet.ToString();
            COMportDCC.Text = szCOMportDCC;

            COMportLocoNet.Items.Clear();
            COMportDCC.Items.Clear();
 
            foreach (string s in SerialPort.GetPortNames())
            {
                COMportLocoNet.Items.Add(s);
                COMportDCC.Items.Add(s);
            }

            if (COMportLocoNet.Items.Contains(szCOMportLocoNet)) 
                COMportLocoNet.Text = szCOMportLocoNet;
            else if (COMportLocoNet.Items.Count > 0) 
                COMportLocoNet.SelectedIndex = 0;
            else
            {
                MessageBox.Show( this, 
                                 "There are no COM Ports detected on this computer.\nNo capture capability supported", 
                                 "No COM Ports Installed", 
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Error );
            }

            if (COMportDCC.Items.Contains(szCOMportDCC))
                COMportDCC.Text = szCOMportDCC;
            else if (COMportDCC.Items.Count > 0)
                COMportDCC.SelectedIndex = 0;
                
            // Initialize our Pattern Arrays
            //
            ppvOpCodeArray   [0] = ppvOpCode1;
            ppvAddressArray  [0] = ppvAddress1;
            ppvOnOffArray    [0] = ppvOnOff1;
            ppvDurationArray [0] = ppvDuration1;
            ppvLabelArray    [0] = labelPattern1;

            ppvOpCodeArray   [1] = ppvOpCode2;
            ppvAddressArray  [1] = ppvAddress2;
            ppvOnOffArray    [1] = ppvOnOff2;
            ppvDurationArray [1] = ppvDuration2;
            ppvLabelArray    [1] = labelPattern2;

            ppvOpCodeArray   [2] = ppvOpCode3;
            ppvAddressArray  [2] = ppvAddress3;
            ppvOnOffArray    [2] = ppvOnOff3;
            ppvDurationArray [2] = ppvDuration3;
            ppvLabelArray    [2] = labelPattern3;

            ppvOpCodeArray   [3] = ppvOpCode4;
            ppvAddressArray  [3] = ppvAddress4;
            ppvOnOffArray    [3] = ppvOnOff4;
            ppvDurationArray [3] = ppvDuration4;
            ppvLabelArray    [3] = labelPattern4;

            ppvOpCodeArray   [4] = ppvOpCode5;
            ppvAddressArray  [4] = ppvAddress5;
            ppvOnOffArray    [4] = ppvOnOff5;
            ppvDurationArray [4] = ppvDuration5;
            ppvLabelArray    [4] = labelPattern5;

            ppvOpCodeArray   [5] = ppvOpCode6;
            ppvAddressArray  [5] = ppvAddress6;
            ppvOnOffArray    [5] = ppvOnOff6;
            ppvDurationArray [5] = ppvDuration6;
            ppvLabelArray    [5] = labelPattern6;

            ppvOpCodeArray   [6] = ppvOpCode7;
            ppvAddressArray  [6] = ppvAddress7;
            ppvOnOffArray    [6] = ppvOnOff7;
            ppvDurationArray [6] = ppvDuration7;
            ppvLabelArray    [6] = labelPattern7;

            ppvOpCodeArray   [7] = ppvOpCode8;
            ppvAddressArray  [7] = ppvAddress8;
            ppvOnOffArray    [7] = ppvOnOff8;
            ppvDurationArray [7] = ppvDuration8;
            ppvLabelArray    [7] = labelPattern8;

            ppvOpCodeArray   [8] = ppvOpCode9;
            ppvAddressArray  [8] = ppvAddress9;
            ppvOnOffArray    [8] = ppvOnOff9;
            ppvDurationArray [8] = ppvDuration9;
            ppvLabelArray    [8] = labelPattern9;

            ppvOpCodeArray   [9] = ppvOpCode10;
            ppvAddressArray  [9] = ppvAddress10;
            ppvOnOffArray    [9] = ppvOnOff10;
            ppvDurationArray [9] = ppvDuration10;
            ppvLabelArray    [9] = labelPattern10;

            ppvOpCodeArray  [10] = ppvOpCode11;
            ppvAddressArray [10] = ppvAddress11;
            ppvOnOffArray   [10] = ppvOnOff11;
            ppvDurationArray[10] = ppvDuration11;
            ppvLabelArray   [10] = labelPattern11;

            ppvOpCodeArray  [11] = ppvOpCode12;
            ppvAddressArray [11] = ppvAddress12;
            ppvOnOffArray   [11] = ppvOnOff12;
            ppvDurationArray[11] = ppvDuration12;
            ppvLabelArray   [11] = labelPattern12;

            ppvOpCodeArray  [12] = ppvOpCode13;
            ppvAddressArray [12] = ppvAddress13;
            ppvOnOffArray   [12] = ppvOnOff13;
            ppvDurationArray[12] = ppvDuration13;
            ppvLabelArray   [12] = labelPattern13;

            ppvOpCodeArray  [13] = ppvOpCode14;
            ppvAddressArray [13] = ppvAddress14;
            ppvOnOffArray   [13] = ppvOnOff14;
            ppvDurationArray[13] = ppvDuration14;
            ppvLabelArray   [13] = labelPattern14;

            ppvOpCodeArray  [14] = ppvOpCode15;
            ppvAddressArray [14] = ppvAddress15;
            ppvOnOffArray   [14] = ppvOnOff15;
            ppvDurationArray[14] = ppvDuration15;
            ppvLabelArray   [14] = labelPattern15;

            ppvOpCodeArray  [15] = ppvOpCode16;
            ppvAddressArray [15] = ppvAddress16;
            ppvOnOffArray   [15] = ppvOnOff16;
            ppvDurationArray[15] = ppvDuration16;
            ppvLabelArray   [15] = labelPattern16;

            ppvOpCodeArray  [16] = ppvOpCode17;
            ppvAddressArray [16] = ppvAddress17;
            ppvOnOffArray   [16] = ppvOnOff17;
            ppvDurationArray[16] = ppvDuration17;
            ppvLabelArray   [16] = labelPattern17;

            ppvOpCodeArray  [17] = ppvOpCode18;
            ppvAddressArray [17] = ppvAddress18;
            ppvOnOffArray   [17] = ppvOnOff18;
            ppvDurationArray[17] = ppvDuration18;
            ppvLabelArray   [17] = labelPattern18;

            ppvOpCodeArray  [18] = ppvOpCode19;
            ppvAddressArray [18] = ppvAddress19;
            ppvOnOffArray   [18] = ppvOnOff19;
            ppvDurationArray[18] = ppvDuration19;
            ppvLabelArray   [18] = labelPattern19;

            ppvOpCodeArray  [19] = ppvOpCode20;
            ppvAddressArray [19] = ppvAddress20;
            ppvOnOffArray   [19] = ppvOnOff20;
            ppvDurationArray[19] = ppvDuration20;
            ppvLabelArray   [19] = labelPattern20;
        }

        #region LogData

        /// <summary> Log data to the terminal window. </summary>
        /// <param name="msgtype"> The type of message to be written. </param>
        /// <param name="msg"> The string containing the message to be shown. </param>
        void Log(DateTime CurrentDateTime, byte [] outBuffer, bool bLoadedFile )
        {
            string     msg     = ByteArrayToHexString(outBuffer);
            LogMsgType msgtype = LogMsgType.Incoming;

            // Let's check the "Include Filters"
            //
            if((capALL.Checked)
            || (capB0.Checked   && (outBuffer[0] == 0xB0))
            || (capB1.Checked   && (outBuffer[0] == 0xB1))
            || (capB2.Checked   && (outBuffer[0] == 0xB2))
            || (capB4.Checked   && (outBuffer[0] == 0xB4))
            || (capB5.Checked   && (outBuffer[0] == 0xB5))
            || (capBB.Checked   && (outBuffer[0] == 0xBB))
            || (capBF.Checked   && (outBuffer[0] == 0xBF))
            || (capE5.Checked   && (outBuffer[0] == 0xE5))
            || (capE7.Checked   && (outBuffer[0] == 0xE7))
            || (capEEEF.Checked && (outBuffer[0] == 0xEE))
            || (capEEEF.Checked && (outBuffer[0] == 0xEF)) )
            {
                // Let's check the "Exclude Filters"
                //
                if( capA0exclude.Checked && (outBuffer[0] == 0xA0) )
                {
                    disPacketsReceived.Text = iPacketsReceived.ToString();
                    disBytesReceived.Text   = iBytesReceived.ToString();
                    disChecksumErrors.Text  = iCheckSumErrors.ToString();
                    return;
                }
                
                iPacketsCaptured++;

                // Let's get the packet destination address
                //
                int iPacketCnt      = (outBuffer[0] & 0x60);
                int iAddDestination = -1;   // Default of -1 = "unknown"
                string szStatus     = "        ";

                switch (iPacketCnt)
                {
                    case 0x00:  // 2 byte packets
                        iPacketCnt = 2;

                        switch (outBuffer[0])
                        {
                            case 0x85:  // FORCE IDLE state, B'cast emerg. STOP
                                szStatus = "EmrgSTOP";
                                break;

                            case 0x83:  // GLOBAL power ON request
                                szStatus = "POWER on";
                                break;

                            case 0x82:  // GLOBAL power OFF req
                                szStatus = "POWERoff";
                                break;
                        }
                        break;
                 
                    case 0x20:  // 4 byte packets
                        iPacketCnt = 4;

                        switch (outBuffer[0])
                        {
                            case 0xBF:  // REQ loco ADR
                                szStatus = "REQaddr ";
                                break;

                            case 0xBD:  // REQ SWITCH WITH acknowledge function (not DT200)
                                iAddDestination = ((outBuffer[2] & 0x0F) << 7) 
                                                | ((outBuffer[1] & 0x7F)) + 1;
                                szStatus = "thrown  ";

                                if ((outBuffer[2] & 0x20) != 0) // Test thrown/closed value
                                    szStatus = "closed  ";
                                break;

                            case 0xBC:  // REQ state of SWITCH
                                szStatus = "REQsw   ";
                                break;

                            case 0xBB:  // Request SLOT DATA/status block
                                iAddDestination = outBuffer[1];
                                szStatus = "REQdata ";
                                break;

                            case 0xBA:  // MOVE slot SRC to DEST
                                szStatus = "MOVEslot";
                                break;

                            case 0xB9:  // LINK slot ARG1 to slot ARG2
                                szStatus = "LINK    ";
                                break;

                            case 0xB8:  // UNLINK slot ARG1 from slot ARG2
                                szStatus = "UNLINK  ";
                                break;

                            case 0xB6:  // SET FUNC bits in a CONSIST uplink element
                                szStatus = "Set Func";
                                break;

                            case 0xB4:  // Long acknowledge
                                szStatus = "Long ACK";
                                break;

                            case 0xB2:  // General SENSOR Input codes
                                if( IbitChecked.Checked )   // See if we are using the "I" bit to calculate address
                                {
                                    iAddDestination   = (outBuffer[2] & 0x0F) << 7; // Get high 4 bits
                                    iAddDestination  |= (outBuffer[1] & 0x7F);      // OR in low 7 bits
                                    iAddDestination <<= 1;                          // Shift everything left 1 bit
                                    iAddDestination  |= (outBuffer[2] >> 5) & 0x01; // Get "I" bit
                                    iAddDestination  += 1;                          // Addresses are zero-based (0 = 1)
                                }
                                else
                                {
                                    iAddDestination = ((outBuffer[2] & 0x0F) << 7)
                                                    | ((outBuffer[1] & 0x7F)) + 1;
                                }

                                szStatus = "(LO)    ";

                                if( (outBuffer[2] & 0x10) != 0 )    // Test Input Sensor
                                    szStatus = "(HI)    ";
                                break;

                            case 0xB1:  // Turnout SENSOR state REPORT
                                iAddDestination = ((outBuffer[2] & 0x0F) << 7)
                                                | ((outBuffer[1] << 1)) + 1;

                                if ( (outBuffer[2] & 0x20) == 0 )   // Test the "I" bit
                                    iAddDestination |= 0x01;        // ...if it's 0, then set low bit to 1

                                if ((outBuffer[2] & 0x40) != 0) // Normal B1 packet?
                                {
                                    szStatus = "(LO)    ";

                                    if ((outBuffer[2] & 0x10) != 0) // Test LO/HI value
                                        szStatus = "(HI)    ";
                                }
                                else                            // Alternate B1 packet
                                {
                                    szStatus = "thrown  ";

                                    if ((outBuffer[2] & 0x10) != 0) // Test "thrown" output line
                                        szStatus = "closed  ";
                                }
                                break;

                            case 0xB0:  // REQ SWITCH function
                                iAddDestination = ((outBuffer[2] & 0x0F) << 7) 
                                                | ((outBuffer[1] & 0x7F)) + 1;
                                szStatus = "thrown  ";

                                if ((outBuffer[2] & 0x20) != 0) // Test thrown/closed value
                                    szStatus = "closed  ";
                                break;

                            case 0xA2:  // SET SLOT sound functions
                                iAddDestination = outBuffer[1];
                                szStatus = "SetSound";
                                break;

                            case 0x1:  // SET SLOT dir,F0-4 state
                                iAddDestination = outBuffer[1];
                                szStatus = "Set Dir ";
                                break;

                            case 0xA0:  // SET SLOT speed
                                iAddDestination = outBuffer[1];
                                szStatus = "SetSpeed";
                                break;
                        }
                        break;

                    case 0x40:  // Six byte packets
                        iPacketCnt = 6;
                        szStatus = "Reserved";
                        break;

                    case 0x60:  // Variable length packets
                        iPacketCnt = outBuffer[1] & 0x7F;

                        switch (outBuffer[0])
                        {
                            case 0xEF:  // WRITE SLOT DATA, 10 bytes
                                if (iPacketCnt != 14)
                                {
                                    szStatus = "BAD pkt ";
                                    msgtype = LogMsgType.Error;
                                    break;
                                }

                                iAddDestination = outBuffer[2];
                                szStatus = "WRT Slot";
                                break;

                            case 0xE7:  // SLOT DATA return, 10 bytes
                                if (iPacketCnt != 14)
                                {
                                    szStatus = "BAD pkt ";
                                    msgtype = LogMsgType.Error;
                                    break;
                                }

                                iAddDestination = outBuffer[2];
                                szStatus = "RD slot ";
                                break;
                        }
                        break;
                }

                if( disALL.Checked     // "All" checked
                || (disB0.Checked   && (outBuffer[0] == 0xB0))
                || (disB1.Checked   && (outBuffer[0] == 0xB1))
                || (disB2.Checked   && (outBuffer[0] == 0xB2))
                || (disB4.Checked   && (outBuffer[0] == 0xB4))
                || (disB5.Checked   && (outBuffer[0] == 0xB5))
                || (disBB.Checked   && (outBuffer[0] == 0xBB))
                || (disBF.Checked   && (outBuffer[0] == 0xBF))
                || (disE5.Checked   && (outBuffer[0] == 0xE5))
                || (disE7.Checked   && (outBuffer[0] == 0xE7))
                || (disEEEF.Checked && (outBuffer[0] == 0xEE))
                || (disEEEF.Checked && (outBuffer[0] == 0xEF)) )
                {
                    if( (disAddAll.Checked)
                    ||  (disIncludeChk1.Checked && (disAdd1.Value == iAddDestination))
                    ||  (disIncludeChk2.Checked && (disAdd2.Value == iAddDestination))
                    ||  (disIncludeChk3.Checked && (disAdd3.Value == iAddDestination))
                    ||  (disIncludeChk4.Checked && (disAdd4.Value == iAddDestination))
                    ||  (disIncludeChk5.Checked && (disAdd5.Value == iAddDestination))
                    ||  (disIncludeChk6.Checked && (disAdd6.Value == iAddDestination))
                    ||  (disIncludeChk7.Checked && (disAdd7.Value == iAddDestination))
                    ||  (disIncludeChk8.Checked && (disAdd8.Value == iAddDestination)) )
                    {
                        rtf_disCapture.SelectionLength = 0;
                        rtf_disCapture.AppendText(" ");     // Move cursor to end of text buffer

                        rtf_disCapture.Invoke(new EventHandler(delegate
                        {
                            rtf_disCapture.SelectionFont = new Font(rtf_disCapture.SelectionFont, FontStyle.Regular);
                            rtf_disCapture.Font = new System.Drawing.Font("Courier New", 8);
                            rtf_disCapture.SelectionColor = Color.DarkOrange;
                            rtf_disCapture.AppendText(String.Format("{0,7}", iPacketsCaptured.ToString()) + "  ");
                            rtf_disCapture.SelectionColor = Color.Black;
                            rtf_disCapture.AppendText(String.Format("{0,22}", CurrentDateTime.ToString()) + "   ");
                            rtf_disCapture.SelectionColor = Color.Firebrick;

                            if( iAddDestination == -1 )
                                rtf_disCapture.AppendText("       ");
                            else
                                rtf_disCapture.AppendText(String.Format("{0,6}", iAddDestination.ToString()) + " ");

                            rtf_disCapture.SelectionColor = Color.DarkGreen;
                            rtf_disCapture.AppendText( szStatus + "  ");
                            rtf_disCapture.SelectionColor = LogMsgTypeColor[(int)msgtype];
                            rtf_disCapture.AppendText(msg + "\n");
                            if( bLoadedFile != true )
                                rtf_disCapture.ScrollToCaret();
                        }));
                    }
                }

                if (fStartPatternMatch == true)
                {
                    ProcessPatternMatches(iPacketsCaptured, CurrentDateTime, iAddDestination, msg);
                }

                if (bLoadedFile == false)      // if we are NOT reading in a captured file
                {
                    if (fFileOpen)
                    {
                        captureFile.Write(CurrentDateTime.ToBinary());
                        captureFile.Write(iPacketCnt);
                        captureFile.Write(outBuffer, 0, iPacketCnt);
                        captureFile.Flush();
                    }
                }
            }
            disPacketsReceived.Text = iPacketsReceived.ToString();
            disBytesReceived.Text   = iBytesReceived.ToString();
            disChecksumErrors.Text  = iCheckSumErrors.ToString();
        }

        /// <summary> Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>
        /// <param name="s"> The string containing the hex digits (with or without spaces). </param>
        /// <returns> Returns an array of bytes. </returns>
        byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
        /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
        /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
        string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            return sb.ToString().ToUpper();
        }
        #endregion

        #region Event Handlers

        void button3_Click(object sender, EventArgs e)
        {
            // If the port is open, close it.
            //
            if (comport.IsOpen)
                comport.Close();

            disStartContinue.Enabled = true;
            disPause.Enabled = false;
        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // This method will be called when there is at least 1 byte of data waiting in the port's buffer

            // The OPCODES may be examined to determine message length and if subsequent response message is
            // required. Data bits D6 and D5 encode the message length. D3=1 implies Follow-on message/reply:
            // D7 D6 D5 D4 -- D3 D2 D1 D0
            // (Opcode Flag)
            // 1 0 0 F D C B A Message is 2 bytes, including Checksum
            // 1 0 1 F D C B A Message is 4 bytes, inc. checksum
            // 1 1 0 F D C B A Message is 6 bytes, inc checksum
            // 1 1 1 F D C B A Message in N bytes, where next byte in message is a 7 bit BYTE COUNT.
            //                 The F,D,C,B,A are bits available to encode 32 OPCODES per message length.

            byte[] COMbyte = new byte[2];
            byte bCheckSum = 0x00;

            while (comport.BytesToRead > 1)
            {
                comport.Read(COMbyte, 0, 1);

                // Let's assume this is the first byte in a LocoNet Packet
                //
                if ((COMbyte[0] & 0x80) == 0)
                {
                    // Invalid first packet byte found, discard data and read next byte
                    //
                    continue;
                }

                comport.Read(COMbyte, 1, 1);    // Let's read next byte (should be checksum or byte count)

                int iPacketCnt = (COMbyte[0] & 0x60);

                switch (iPacketCnt)
                {
                    case 0x00: iPacketCnt = 2;
                        break;
                    case 0x20: iPacketCnt = 4;
                        break;
                    case 0x40: iPacketCnt = 6;
                        break;
                    case 0x60:
                        iPacketCnt = COMbyte[1] & 0x7F;
                        break;
                    default:
                        // Invalid first packet byte found, discard data and read another byte
                        //
                        continue;
                }

                byte[] outBuffer = new byte[iPacketCnt];

                outBuffer[0] = COMbyte[0];
                outBuffer[1] = COMbyte[1];

                int iBytesRead = 0;

                do
                {
                    iBytesRead += comport.Read(outBuffer,
                                                2 + iBytesRead,
                                                iPacketCnt - iBytesRead - 2);
                }
                while (iBytesRead < (iPacketCnt - 2));

                int iLen = outBuffer.Length;
                bCheckSum = 0x00;

                while (iLen > 0)
                {
                    bCheckSum ^= outBuffer[iLen - 1];
                    iLen--;
                }

                if (bCheckSum != 0xFF)
                {
                    // Invalid packet found, discard data and read next byte
                    //
                    iCheckSumErrors++;
                    continue;
                }

                iBytesReceived += outBuffer.Length;

                iPacketsReceived++;

                // Process, Display, and Save the incoming LocoNet Data
                //
                DateTime CurrentDateTime = DateTime.Now;
                Log(CurrentDateTime, outBuffer, false );
            }
        }

        #endregion

        public     // ===========================================================================

        LocoNetMon()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            // When data is recieved through the port, call this method
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            capB0.Checked   = false;
            capB1.Checked   = false;
            capB2.Checked   = false;
            capB4.Checked   = false;
            capB5.Checked   = false;
            capBB.Checked   = false;
            capBF.Checked   = false;
            capE5.Checked   = false;
            capE7.Checked   = false;
            capEEEF.Checked = false;
            capALL.Checked  = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comport.IsOpen)
                return;
                
            // Set the port's settings
            //
            comport.BaudRate = iBAUDrateLocoNet;
            comport.PortName = szCOMportLocoNet;
            comport.RtsEnable = false;
            comport.Handshake = System.IO.Ports.Handshake.RequestToSend;

            try
            {
                comport.Open(); // Open the port
            }
            catch
            {
                MessageBox.Show("Unable to open COM port");
                return;
            }

            // If the port is open, send focus to the send data box
            if (comport.IsOpen)
            {
                rtf_disCapture.Focus();
                disStartContinue.Enabled = false;
                disPause.Enabled = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // If the port is open, close it.
            //
            if (comport.IsOpen)
                comport.Close();

            disStartContinue.Enabled = true;
            disPause.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disB0.Checked = false;
            disB1.Checked = false;
            disB2.Checked = false;
            disB4.Checked = false;
            disB5.Checked = false;
            disBB.Checked = false;
            disBF.Checked = false;
            disE5.Checked = false;
            disE7.Checked = false;
            disEEEF.Checked = false;
            disALL.Checked = true;
        }

        private void disClearAdd_Click(object sender, EventArgs e)
        {
            disIncludeChk1.Checked = false;
            disIncludeChk2.Checked = false;
            disIncludeChk3.Checked = false;
            disIncludeChk4.Checked = false;
            disIncludeChk5.Checked = false;
            disIncludeChk6.Checked = false;
            disIncludeChk7.Checked = false;
            disIncludeChk8.Checked = false;

            disAdd1.Value = 0;
            disAdd2.Value = 0;
            disAdd3.Value = 0;
            disAdd4.Value = 0;
            disAdd5.Value = 0;
            disAdd6.Value = 0;
            disAdd7.Value = 0;
            disAdd8.Value = 0;

            disAddAll.Checked = true;
        }

        private void rtf_disCapture_Click(object sender, EventArgs e)
        {
            disCaptureSelected(0);
        }

        private void rtf_disCapture_KeyDown(object sender, KeyEventArgs e)
        {
            disCaptureSelected(e.KeyValue);
            e.Handled = true;
        }

        private void disCaptureSelected(int iKeyVal)
        {
            int    iSelectionIndex;
            int    iSlot = 0;
            int    iStatus = 0;
            int    iAddress = 0;
            int    iDIRF = 0x00;
            int    iSpeed = 0;
            int    iTrackStatus = 0;
            int    iSlotSound = 0;
            int    iByte = 0;
            int    iLine = 0;
            int    iSelectionStart = 0;
            string current;
            int    stringcount = 0;
            string DetailItem;
            int    iOpCode = 0;
            int    iSW2 = 0;
            int    iID1 = 0;
            int    iID2 = 0;
            int    iDeviceID = 0;

            iSelectionIndex = rtf_disCapture.SelectionStart;
            iLine = rtf_disCapture.GetLineFromCharIndex(iSelectionIndex);

            if (iKeyVal != 0)
            {
                switch (iKeyVal)
                {
                    case 0x26:  // Up-arrow
                        iLine--;
                        break;
                    case 0x28:  // Down-arrow
                        iLine++;
                        break;
                }
            }

            if (iLine < 0)
                return;

            iSelectionStart = rtf_disCapture.GetFirstCharIndexFromLine(iLine);

            if (iSelectionStart < 0)
                return;

            for (int i = iSelectionStart; i < rtf_disCapture.TextLength; i++)
            {
                current = rtf_disCapture.Text.Substring(i, 1);

                if (current == "\n")
                    break;

                stringcount += 1;
            }

            if (stringcount > 0)
            {
                rtf_disCapture.Select(iSelectionStart, stringcount);
                current = rtf_disCapture.SelectedText;

                rtf_disDetail.Clear();
                rtf_disDetail.SelectionFont = new Font(rtf_disCapture.SelectionFont, FontStyle.Regular);
                rtf_disDetail.Font = new System.Drawing.Font("Courier New", 8);
                rtf_disDetail.SelectionColor = Color.DarkOrange;
                DetailItem = current.Substring(0, 8);
                rtf_disDetail.AppendText("Packet Number = " + DetailItem + "\n");
                rtf_disDetail.SelectionColor = Color.Black;
                DetailItem = current.Substring(10, 22);
                rtf_disDetail.AppendText("Date/Time = " + DetailItem + "\n");

                // Let's get the 1st Hex byte and determine LocoNet OpCode
                //
                DetailItem = current.Substring(52, 2);

                iOpCode = GetHexValue(DetailItem);
                int iPacketCnt = (iOpCode & 0x60);

                switch (iPacketCnt)
                {
                    case 0x00:  // 2 byte packets
                        iPacketCnt = 2;

                        switch (iOpCode)
                        {
                            case 0x85:  // FORCE IDLE state, B'cast emerg. STOP
                                rtf_disDetail.SelectionColor = Color.DarkRed;
                                rtf_disDetail.AppendText("Force Idle state, Emergency Stop!" + "\n");
                                return;

                            case 0x83:  // GLOBAL power ON request
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("GLOBAL power ON" + "\n");
                                return;

                            case 0x82:  // GLOBAL power OFF req
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("GLOBAL power OFF" + "\n");
                                return;
                        }
                        break;

                    case 0x20:  // 4 byte packets
                        iPacketCnt = 4;

                        switch (iOpCode)
                        {
                            case 0xBF:  // REQ loco ADR
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Request LocoNet Address" + "\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Address Requested = " + DetailItem + "\n");
                                return;

                            case 0xBD:  // REQ SWITCH WITH acknowledge function (not DT200)
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Request State of Switch with Acknowledgement\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Switch Address = " + DetailItem + "\n");

                                // Let's get the SW2 Hex byte value
                                //
                                DetailItem = current.Substring(58, 2);

                                iSW2 = iOpCode = GetHexValue(DetailItem);

                                if ((iSW2 & 0x20) == 0)
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkRed;
                                    rtf_disDetail.AppendText("Switch is Thrown\n");
                                }
                                else
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkGreen;
                                    rtf_disDetail.AppendText("Switch is Closed\n");
                                }
                                return;

                            case 0xBC:  // REQ state of SWITCH
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Request State of Switch\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Switch Address = " + DetailItem + "\n");

                                // Let's get the SW2 Hex byte value
                                //
                                DetailItem = current.Substring(58, 2);

                                iSW2 = iOpCode = GetHexValue(DetailItem);

                                if ((iSW2 & 0x20) == 0)
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkRed;
                                    rtf_disDetail.AppendText("Switch is Thrown\n");
                                }
                                else
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkGreen;
                                    rtf_disDetail.AppendText("Switch is Closed\n");
                                }
                                return;

                            case 0xBB:  // Request SLOT DATA/status block
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Request Slot Data/Status Block\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + DetailItem + "\n");
                                return;

                            case 0xBA:  // MOVE slot SRC to DEST
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Move Source Slot to Destination Slot\n");
                                DetailItem = current.Substring(55, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Source Slot = " + iSlot.ToString() + "\n");
                                DetailItem = current.Substring(58, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.AppendText("Destination Slot = " + iSlot.ToString() + "\n");
                                return;

                            case 0xB9:  // LINK slot ARG1 to slot ARG2
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Link Source Slot to Destination Slot\n");
                                DetailItem = current.Substring(55, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Source Slot = " + iSlot.ToString() + "\n");
                                DetailItem = current.Substring(58, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.AppendText("Destination Slot = " + iSlot.ToString() + "\n");
                                return;

                            case 0xB8:  // UNLINK slot ARG1 from slot ARG2
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("UnLink Source Slot from Destination Slot\n");
                                DetailItem = current.Substring(55, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Source Slot = " + iSlot.ToString() + "\n");
                                DetailItem = current.Substring(58, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.AppendText("Destination Slot = " + iSlot.ToString() + "\n");
                                return;

                            case 0xB6:  // SET FUNC bits in a CONSIST uplink element
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Set Function Bits in a CONSIST UpLink Element\n");
                                DetailItem = current.Substring(55, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + iSlot.ToString() + "\n");
                                DetailItem = current.Substring(58, 2);
                                iDIRF = GetHexValue(DetailItem);
                                Set_disDetail_DIRF( iDIRF );
                                return;

                            case 0xB5:  // WRITE slot stat1
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Write Status into Specified Slot\n");
                                DetailItem = current.Substring(55, 2);
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + iSlot.ToString() + "\n");
                                DetailItem = current.Substring(58, 2);
                                rtf_disDetail.AppendText("Status bits = 0x" + DetailItem + "\n");
                                return;

                            case 0xB4:  // Long acknowledge
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Long Acknowledge\n");
                                DetailItem = current.Substring(55, 2);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("OpCode Responding to = 0x" + DetailItem + "\n");
                                DetailItem = current.Substring(58, 2);
                                rtf_disDetail.AppendText("Response to OpCode = 0x" + DetailItem + "\n");
                                return;

                            case 0xB2:  // General SENSOR Input codes

                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("General Sensor Input Codes\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Address = " + DetailItem + "\n");

                                DetailItem = current.Substring(58, 2);
                                iByte = GetHexValue(DetailItem);

                                if( (iByte & 0x20) == 0 )
                                    rtf_disDetail.AppendText("Control bit (X) = 0\n");
                                else
                                    rtf_disDetail.AppendText("Control bit (X) = 1\n");

                                if ((iByte & 0x10) == 0)
                                    rtf_disDetail.AppendText("Sensor Input Low (0v)\n");
                                else
                                    rtf_disDetail.AppendText("Sensor Input High (>+6V)\n");

                                return;

                            case 0xB1:  // Turnout SENSOR state REPORT

                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Turnout Sensor State Report\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Address = " + DetailItem + "\n");

                                DetailItem = current.Substring(58, 2);
                                iByte = GetHexValue(DetailItem);

                                if ((iByte & 0x40) != 0)        // Normal B1 packet?
                                {
                                    if ((iByte & 0x10) == 0)    // Test LO/HI value
                                        rtf_disDetail.AppendText("Turnout Sensor is Low (0v)\n");
                                    else
                                        rtf_disDetail.AppendText("Turnout Sensor is High (>6v)\n");
                                }
                                else                            // Alternate B1 packet
                                {
                                    if ((iByte & 0x10) == 0)    // Test LO/HI value
                                        rtf_disDetail.AppendText("Turnout output line is Low (0v)\n");
                                    else
                                        rtf_disDetail.AppendText("Turnout output line is High (>6v\n");
                                }
                                return;

                            case 0xB0:  // REQ SWITCH function
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Request Switch Function\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Address = " + DetailItem + "\n");

                                DetailItem = current.Substring(58, 2);
                                iByte = GetHexValue(DetailItem);

                                if ((iByte & 0x20) == 0)
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkRed;
                                    rtf_disDetail.AppendText("Thrown/Red\n");
                                }
                                else
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkGreen;
                                    rtf_disDetail.AppendText("Closed/Green\n");
                                }

                                rtf_disDetail.SelectionColor = Color.DarkGreen;

                                if ((iByte & 0x10) == 0)
                                {
                                    rtf_disDetail.AppendText("Output Off\n");
                                }
                                else
                                {
                                    rtf_disDetail.AppendText("Output On\n");
                                }
                                return;

                            case 0xA2:  // SET SLOT sound functions
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Set Slot Sound Value\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + DetailItem + "\n");

                                DetailItem = current.Substring(58, 2);
                                iByte = GetHexValue(DetailItem);

                                rtf_disDetail.SelectionColor = Color.DarkBlue;
                                rtf_disDetail.AppendText("Sound Value = " + iByte.ToString() + "\n" );
                                return;

                            case 0xA1:  // SET SLOT dir,F0-4 state
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Set Slot Direction and F0 - F4 State\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + DetailItem + "\n");

                                DetailItem = current.Substring(58, 2);
                                iByte = GetHexValue(DetailItem);

                                rtf_disDetail.SelectionColor = Color.DarkBlue;
                                Set_disDetail_DIRF(iByte);
                                return;


                            case 0xA0:  // SET SLOT speed
                                rtf_disDetail.SelectionColor = Color.DarkGreen;
                                rtf_disDetail.AppendText("Set Slot Speed Value\n");
                                DetailItem = current.Substring(33, 8);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + DetailItem + "\n");

                                DetailItem = current.Substring(58, 2);
                                iByte = GetHexValue(DetailItem);

                                rtf_disDetail.SelectionColor = Color.DarkBlue;
                                rtf_disDetail.AppendText("Speed Value = " + iByte.ToString() + "\n");
                                return;

                        }
                        break;

                    case 0x40:  // Six byte packets
                        rtf_disDetail.SelectionColor = Color.DarkGreen;
                        rtf_disDetail.AppendText("Six byte packet (Reserved)\n");
                        return;

                    case 0x60:  // Variable length packets
                        DetailItem = current.Substring(55, 2);
                        iPacketCnt = GetHexValue(DetailItem);

                        switch (iOpCode)
                        {
                            case 0xEF:  // WRITE SLOT DATA, 10 bytes
                            case 0xE7:  // SLOT DATA return, 10 bytes
                                if (iPacketCnt != 14)
                                {
                                    rtf_disDetail.SelectionColor = Color.DarkRed;
                                    rtf_disDetail.AppendText("OpCode 0x" + DetailItem + " has an invalid packed count\n");
                                    rtf_disDetail.AppendText("  Total Packet count should be 14, actual vaule = " );
                                    rtf_disDetail.AppendText( iPacketCnt.ToString() + "\n");
                                    return;
                                }

                                rtf_disDetail.SelectionColor = Color.DarkGreen;

                                if( iOpCode == 0xEF )
                                    rtf_disDetail.AppendText("Write 10 bytes of Slot Data\n");
                                else
                                    rtf_disDetail.AppendText("Read 10 bytes of Slot Data\n");

                                DetailItem = current.Substring(58, 2);      // Get & Display Slot #
                                iSlot = GetHexValue(DetailItem);
                                rtf_disDetail.SelectionColor = Color.Firebrick;
                                rtf_disDetail.AppendText("Slot = " + iSlot.ToString() + "\n");

                                DetailItem = current.Substring(61, 2);      // Get & Display Status Byte
                                iStatus = GetHexValue(DetailItem);
                                SlotStatus(iStatus);

                                DetailItem = current.Substring(64, 2);      // Get Low Address
                                iAddress = GetHexValue(DetailItem) & 0x7F;

                                DetailItem = current.Substring(79, 2);      // Get High Address
                                iByte = GetHexValue(DetailItem) & 0x7F;

                                rtf_disDetail.SelectionColor = Color.Firebrick;

                                if (iByte == 0)
                                {
                                    rtf_disDetail.AppendText("Address (Short) = " + iAddress.ToString() + "\n");
                                }
                                else
                                {
                                    iAddress |= iByte << 7;
                                    rtf_disDetail.AppendText("Address (Long) = " + iAddress.ToString() + "\n");
                                }

                                DetailItem = current.Substring(67, 2);      // Get Speed
                                iSpeed = GetHexValue(DetailItem) & 0x7F;

                                rtf_disDetail.SelectionColor = Color.DarkGray;

                                if (iSpeed == 0)
                                {
                                    rtf_disDetail.AppendText("Speed = 0 (Rolling Stop)\n");
                                }
                                else if( iSpeed == 1)
                                {
                                    rtf_disDetail.AppendText("Speed = 1 (Emergency Stop)\n");
                                }
                                else
                                {
                                    iSpeed &= 0x7F;
                                    rtf_disDetail.AppendText("Speed = " + iSpeed.ToString() + "\n");
                                }

                                DetailItem = current.Substring(70, 2);      // Get DIRF
                                iDIRF = GetHexValue(DetailItem);
                                Set_disDetail_DIRF(iDIRF);

                                DetailItem = current.Substring(73, 2);      // Get Track Status
                                iTrackStatus = GetHexValue(DetailItem) & 0x7F;
                                rtf_disDetail.SelectionColor = Color.DarkOliveGreen;

                                rtf_disDetail.AppendText("Track Status:\n");

                                if( (iTrackStatus & 0x08) != 0 )
                                    rtf_disDetail.AppendText("  Programming TRACK in this Master is BUSY\n");

                                if ((iTrackStatus & 0x04) != 0)
                                    rtf_disDetail.AppendText("  This Master IMPLEMENTS LocoNet 1.1 capability\n");
                                else
                                    rtf_disDetail.AppendText("  Master is DT200\n");

                                if ((iTrackStatus & 0x02) != 0)
                                    rtf_disDetail.AppendText("  TRACK is PAUSED, Broadcast EMERGENY STOP\n");

                                if ((iTrackStatus & 0x01) != 0)
                                    rtf_disDetail.AppendText("  DCC packets are ON in MASTER, Global POWER up\n");

                                DetailItem = current.Substring(76, 2);      // Get & Display Status2 Byte
                                iStatus = GetHexValue(DetailItem);

                                rtf_disDetail.AppendText("Slot Status 2:\n");

                                if ((iTrackStatus & 0x04) != 0)
                                    rtf_disDetail.AppendText("  Expansion in ID1/ID2\n");
                                else
                                    rtf_disDetail.AppendText("  ENCODED alias\n");

                                if ((iTrackStatus & 0x02) != 0)
                                    rtf_disDetail.AppendText("  Expansion ID1/ID2 is not ID usage\n");

                                if ((iTrackStatus & 0x01) != 0)
                                    rtf_disDetail.AppendText("  This slot has SUPPRESSED ADV consist\n");

                                DetailItem = current.Substring(82, 2);      // Get & Display Active Sound Functions
                                iSlotSound = GetHexValue(DetailItem);

                                rtf_disDetail.AppendText("Active Sound Functions:\n");

                                iSlotSound &= 0x0F;

                                if (iSlotSound == 0)
                                {
                                    rtf_disDetail.AppendText("  No Slot Sounds active\n");
                                }
                                else
                                {
                                    if ((iTrackStatus & 0x08) != 0)
                                        rtf_disDetail.AppendText("  Slot Sound 4 (F8) active\n");

                                    if ((iTrackStatus & 0x04) != 0)
                                        rtf_disDetail.AppendText("  Slot Sound 3 (F7) active\n");

                                    if ((iTrackStatus & 0x02) != 0)
                                        rtf_disDetail.AppendText("  Slot Sound 2 (F6) active\n");

                                    if ((iTrackStatus & 0x01) != 0)
                                        rtf_disDetail.AppendText("  Slot Sound 1 (F5) active\n");
                                }

                                DetailItem = current.Substring(85, 2);      // Get & Display ID1
                                iID1 = GetHexValue(DetailItem);
                                DetailItem = current.Substring(88, 2);      // Get & Display ID2
                                iID2 = GetHexValue(DetailItem);

                                rtf_disDetail.AppendText("Device ID:\n");

                                if( (iID1 == 0)
                                &&  (iID2 == 0) )
                                {
                                    rtf_disDetail.AppendText("  No ID being used (ID = 0)\n");
                                    return;
                                }

                                iDeviceID = ((iID2 & 0x7F) << 7) | (iID1 & 0x7F);
                                rtf_disDetail.AppendText("  Device ID = " + iDeviceID.ToString() + "\n");
                                return;

                            case 0xED:  // SEND n-byte packet immediate
                                rtf_disDetail.AppendText("SEND n-byte packet immediate (see Hex Value)\n");
                                return;

                            case 0xE5:  // Move 8 bytes PEER to PEER, SRC->DST
                                rtf_disDetail.AppendText("Move 8 bytes PEER to PEER, SRC->DST (see Hex Value)\n");
                                return;
                        }
                        break;
                }

                rtf_disDetail.SelectionColor = Color.DarkRed;
                DetailItem = current.Substring(52, 2);
                rtf_disDetail.AppendText("Unkown OpCode Found, OpCode = 0x" + DetailItem + "\n");
            }
        }

        private int GetHexValue( string HexString )
        {
            // Note that we expect the value to be a valid 2 character Hex value
            // with uppercase 'A' - 'F' or lowercase 'a' - 'f'

            int iHexNibble = 0;
            int iHexValue  = 0;

            iHexNibble = HexString[0].CompareTo('0');

            if (iHexNibble > 22)
                iHexNibble -= 39;   // Must be Hex char in range of 'a' - 'f'
            else if (iHexNibble > 9)
                iHexNibble -= 7;    // Must be Hex char in range of 'A' - 'F'

            iHexValue = iHexNibble << 4;

            iHexNibble = HexString[1].CompareTo('0');

            if (iHexNibble > 22)
                iHexNibble -= 39;   // Must be Hex char in range of 'a' - 'f'
            else if (iHexNibble > 9)
                iHexNibble -= 7;    // Must be Hex char in range of 'A' - 'F'

            iHexValue |= iHexNibble;

            return iHexValue;
        }

        //
        // Funcion Set_disDetail_DIRF writes to the detail info window
        // the appropriate message related to the bits set in the DIRF
        // byte as follows:
        //    DIRF byte:
        //    D7-0          ; always 0
        //    D6-SL_XCNT    ; reserved , set 0
        //    D5-SL_DIR     ; 1 = loco direction FORWARD
        //    D4-SL_F0      ; 1 = Directional lighting ON
        //    D3-SL_F4      ; 1 = F4 ON
        //    D2-SL_F3      ; 1 = F3 ON
        //    D1-SL_F2      ; 1 = F2 ON
        //    D0-SL_F1      ; 1 = F1 ON
        //
        void Set_disDetail_DIRF(int iDIRF)
        {
            if ((iDIRF & 0x20) == 0)
                rtf_disDetail.AppendText("Locomotive Direction = REVERSE\n");
            else
                rtf_disDetail.AppendText("Locomotive Direction = FORWARD\n");

            if ((iDIRF & 0x10) == 0)
                rtf_disDetail.AppendText("Directional Lighting = OFF\n");
            else
                rtf_disDetail.AppendText("Directional Lighting = ON\n");

            if ((iDIRF & 0x08) == 0)
                rtf_disDetail.AppendText("F4 = OFF\n");
            else
                rtf_disDetail.AppendText("F4 = ON\n");

            if ((iDIRF & 0x04) == 0)
                rtf_disDetail.AppendText("F3 = OFF\n");
            else
                rtf_disDetail.AppendText("F3 = ON\n");

            if ((iDIRF & 0x02) == 0)
                rtf_disDetail.AppendText("F2 = OFF\n");
            else
                rtf_disDetail.AppendText("F2 = ON\n");

            if ((iDIRF & 0x01) == 0)
                rtf_disDetail.AppendText("F1 = OFF\n");
            else
                rtf_disDetail.AppendText("F1 = ON\n");

            return;
        }

        // Function SlotStatus
        //
        // This function processes the "STAT" byte associated with OpCodes 0xEF 0xE7
        //
        // 1) SLOT STATUS1:
        //
        //    D7-SL_SPURGE ; 1 = SLOT purge en, ALSO adrSEL (INTERNAL use only)
        //                       (not seen on NET!)
        //
        //                   CONDN/CONUP: bit encoding-Control double linked Consist List
        //    D6-SL_CONUP  ; 11 = LOGICAL MID CONSIST , Linked up AND down
        //                   10 = LOGICAL CONSIST TOP, Only linked downwards
        //                   01 = LOGICAL CONSIST SUB-MEMBER, Only linked upwards
        //                   00 = FREE locomotive, no CONSIST indirection/linking 
        //
        //                   ALLOWS "CONSISTS of CONSISTS". Uplinked means that Slot SPD
        //                   number is now SLOT adr of SPD/DIR and STATUS of consist. i.e. is
        //                   an Indirect pointer. This Slot has same BUSY/ACTIVE bits as TOP of
        //                   Consist. TOP is loco with SPD/DIR for whole consist. (top of list).
        //
        //                   BUSY/ACTIVE: bit encoding for SLOT activity
        //    D5-SL_BUSY   ; 11 = IN_USE loco adr in SLOT - REFRESHED
        //    D4-SL_ACTIVE ; 10 = IDLE loco adr in SLOT    - NOT refreshed
        //                   01 = COMMON loco adr IN SLOT  - refreshed
        //                   00 = FREE SLOT, no valid DATA - not refreshed
        //
        //    D3-SL_CONDN  ; shows other SLOT Consist linked INTO this slot,see SL_CONUP
        //
        //    D2-SL_SPDEX  ; 3 BITS for Decoder TYPE encoding for this SLOT
        //    D1-SL_SPD14  ; 011 = send 128 speed mode packets
        //    D0-SL_SPD28  ; 010 = 14 step MODE
        //                   001 = 28 step. Generate Trinary packets for this Mobile ADR
        //                   000 = 28 step/ 3 BYTE PKT regular mode
        //                   111 = 128 Step decoder, Allow Advanced DCC consisting
        //                   100 = 28 Step decoder ,Allow Advanced DCC consisting
        //
        void SlotStatus(int iStatus)
        {
            int iCON = 0;
            int iBusyActive = 0;
            int iDecoderType = 0;

            rtf_disDetail.SelectionColor = Color.DarkBlue;

            if ((iStatus & 0x80) != 0)
                rtf_disDetail.AppendText("Slot Purge bit set\n");

            iCON  = ((iStatus & 0x40) >> 5);
            iCON |= ((iStatus & 0x08) >> 3);

            rtf_disDetail.SelectionColor = Color.DarkBlue;

            switch (iCON)
            {
                case 0x3:   // LOGICAL MID CONSIST , Linked up AND down
                    rtf_disDetail.AppendText("LOGICAL MID CONSIST , Linked up AND down\n");
                    break;

                case 0x2:   // LOGICAL CONSIST TOP, Only linked downwards
                    rtf_disDetail.AppendText("LOGICAL CONSIST TOP, Only linked downwards\n");
                    break;

                case 0x1:   // LOGICAL CONSIST SUB-MEMBER, Only linked upwards
                    rtf_disDetail.AppendText("LOGICAL CONSIST SUB-MEMBER, Only linked upwards\n");
                    break;

                case 0x00:  // FREE locomotive, no CONSIST indirection/linking
                    rtf_disDetail.AppendText("FREE locomotive, no CONSIST indirection/linking\n");
                    break;
            }

            iBusyActive  = ((iStatus & 0x20) >> 4);
            iBusyActive |= ((iStatus & 0x10) >> 4);

            rtf_disDetail.SelectionColor = Color.DarkBlue;

            switch (iBusyActive)
            {
                case 0x3:   // IN_USE loco adr in SLOT - REFRESHED
                    rtf_disDetail.AppendText("IN_USE LocoNet address in use.  Address is in Slot - REFRESHED\n");
                    break;

                case 0x2:   // IDLE loco adr in SLOT - NOT refreshed
                    rtf_disDetail.AppendText("IDLE LocoNet Address is in SLOT - NOT refreshed\n");
                    break;

                case 0x1:   // COMMON loco adr IN SLOT  - refreshed
                    rtf_disDetail.AppendText("COMMON LocoNet address is in Slot  - refreshed\n");
                    break;

                case 0x00:  // FREE SLOT, no valid DATA - not refreshed
                    rtf_disDetail.AppendText("FREE SLOT, no valid DATA - not refreshed\n");
                    break;
            }

            iDecoderType = iStatus & 0x07;

            rtf_disDetail.SelectionColor = Color.DarkBlue;

            switch (iDecoderType)
            {
                case 0x7:   // 128 Step decoder, Allow Advanced DCC consisting
                    rtf_disDetail.AppendText("128 Step decoder, allow advanced DCC consisting\n");
                    break;

                case 0x4:   // 28 Step decoder ,Allow Advanced DCC consisting
                    rtf_disDetail.AppendText("28 Step decoder, allow advanced DCC consisting\n");
                    break;

                case 0x3:   // send 128 speed mode packets
                    rtf_disDetail.AppendText("Send 128 speed mode packets\n");
                    break;

                case 0x2:   // 14 step MODE
                    rtf_disDetail.AppendText("14 step MODE\n");
                    break;

                case 0x1:   // 28 step. Generate Trinary packets for this Mobile ADR
                    rtf_disDetail.AppendText("28 step. Generate Trinary packets for this Mobile ADR\n");
                    break;

                case 0x00:  // 28 step/ 3 BYTE PKT regular mode
                    rtf_disDetail.AppendText("28 step/3 BYTE PKT regular mode\n");
                    break;
            }
        }

        // ProcessPatternMatches
        //
        // This routine validates the pattern specified in the "Packet Pattern Verification" tab.
        // 
        private void ProcessPatternMatches(int iPacketsCaptured, DateTime CurrentDateTime, int iAddress, string msg)
        {
            string OpCode;
            bool   fOnOff;
            long   lCurrentTicks = CurrentDateTime.Ticks;

            if (msg.Length < 7)
                return;

            OpCode   = msg.Substring(0, 2);   // Get OpCode
            fOnOff   = (((GetHexValue(msg.Substring(6, 2)) & 0x10) >> 4) == 1) ? true : false;

            long lDuration = (lCurrentTicks - lLastTicksObtained) / 10000000;

            if( ppvDurationArray[iCurrentPattern].Value != 0 )  // Ignore duration time if zero
            {
                if( lDuration > ppvDurationArray[iCurrentPattern].Value
                &&  fFirstPatternDetected == true )
                {
                    // Duration time exceeded before matching packet arrived
                    //
                    if( fppvDurationErrorDisplayed == false )
                    {
                        IndicatePatternError( "Pattern Duration Time Exceeded!" );
                        fppvDurationErrorDisplayed = true;
                    }
                    
                    if (ppvStopOnMisMatch.Checked)
                       return;
                }
            }
            
            // Let's see if we have a matching pattern
            //
            if (ppvOpCodeArray[iCurrentPattern].Text.ToUpper().CompareTo(OpCode) == 0
            && ppvAddressArray[iCurrentPattern].Value                            == iAddress
            && ppvOnOffArray  [iCurrentPattern].Checked                          == fOnOff)
            {
                if (fFirstPatternDetected == false)
                    fFirstPatternDetected = true;

                ppvPacketSummary.SelectionFont = new Font(rtf_disCapture.SelectionFont, FontStyle.Regular);
                ppvPacketSummary.Font = new System.Drawing.Font("Courier New", 8);
                
                if( fppvDurationErrorDisplayed == true )
                    ppvPacketSummary.SelectionColor = Color.Red;
                else
                    ppvPacketSummary.SelectionColor = Color.DarkBlue;

                fppvDurationErrorDisplayed = false;
                
                ppvPacketSummary.AppendText(String.Format("{0,7}",  iPacketsCaptured.ToString()) + "  ");
                ppvPacketSummary.AppendText(String.Format("{0,22}", CurrentDateTime.ToString())  + "   ");
                ppvPacketSummary.AppendText(String.Format("{0,6}",  iAddress.ToString())         + "   ");
                ppvPacketSummary.AppendText(msg + "\n");
                ppvPacketSummary.ScrollToCaret();

                lLastTicksObtained = lCurrentTicks;
                
                int iCurrentLabel  = iCurrentPattern + 1;
                ppvLabelArray[iCurrentPattern].Text = "Pattern " + iCurrentLabel.ToString();

                iCurrentPattern++;
                
                if (iCurrentPattern == MaxPatterns)
                    iCurrentPattern = 0;

                if (ppvOpCodeArray[iCurrentPattern].Text == "")
                    iCurrentPattern = 0;
                    
                ppvLabelArray[iCurrentPattern].Text = "Current->";
                return;
            }

            // Does not match current Pattern, let's see if we match any of the other "Pattern Packets" present
            //
            int i = 0;

            while( (i < MaxPatterns) && (ppvOpCodeArray[i].Text != "") )
            {
                if( i != iCurrentPattern )
                {
                    if( ppvOpCodeArray [i].Text.ToUpper().CompareTo(OpCode) == 0
                    &&  ppvAddressArray[i].Value                            == iAddress
                    &&  ppvOnOffArray  [i].Checked                          == fOnOff )
                    {
                        // We've encounted a "Pattern Packet" out of order
                        //
                        ppvPacketSummary.SelectionFont = new Font(rtf_disCapture.SelectionFont, FontStyle.Regular);
                        ppvPacketSummary.Font = new System.Drawing.Font("Courier New", 8);
                        ppvPacketSummary.SelectionColor = Color.Red;

                        IndicatePatternError( "Packet Pattern Mismatch!" );
                        ppvPacketSummary.SelectionColor = Color.Red;
                        ppvPacketSummary.AppendText(String.Format("{0,7}",  iPacketsCaptured.ToString()) + "  ");
                        ppvPacketSummary.AppendText(String.Format("{0,22}", CurrentDateTime.ToString())  + "   ");
                        ppvPacketSummary.AppendText(String.Format("{0,6}",  iAddress.ToString())         + "   ");
                        ppvPacketSummary.AppendText(msg + "\n");
                        ppvPacketSummary.ScrollToCaret();
                        
                        fppvDurationErrorDisplayed = false;
                        return;
                    }
                }
                i++;
            }
        }

        private void IndicatePatternError( string ErrorMsg )
        {
            if (ppvStopOnMisMatch.Checked)
            {
                // Let's stop on MisMatch
                //
                iCurrentPattern        = 0;
                fStartPatternMatch     = false;
                ppvStartButton.Enabled = true;
                ppvStopButton.Enabled  = false;
                fFirstPatternDetected  = false;
                MessageBox.Show( ErrorMsg );
                return;
            }
             
            ppvPatternErrorButton.BackColor = Color.Red;
            ppvPatternErrorButton.Text = "Pattern Error";

            ppvPacketSummary.SelectionColor = Color.Red;
            ppvPacketSummary.AppendText("            ****** " + ErrorMsg + " ******\n");
            ppvPacketSummary.ScrollToCaret();
        }
        
        private void ClearSummary_Click(object sender, EventArgs e)
        {
            rtf_disCapture.Clear();
            iCheckSumErrors  = 0;
            iBytesReceived   = 0;
            iPacketsReceived = 0;
            iPacketsCaptured = 0;
        }

        private void ppvClearPatterns_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxPatterns; i++)
            {
                ppvOpCodeArray[i].Text    = "";
                ppvAddressArray[i].Value  = 0;
                ppvOnOffArray[i].Checked  = false;
                ppvDurationArray[i].Value = 180;
                
                int iCurrentLabel = i+1;
                ppvLabelArray[i].Text = "Pattern" + iCurrentLabel.ToString();
            }
            ppvDurationArray[0].Value = 0;      // Set Pattern 1 duration to zero (ignore duration)
        }

        private void ppvStartButton_Click(object sender, EventArgs e)
        {
            fStartPatternMatch              = true;
            ppvStartButton.Enabled          = false;
            ppvStopButton.Enabled           = true; ;
            ppvPatternErrorButton.BackColor = Color.LightGreen;
            ppvPatternErrorButton.Text      = "No Pattern Error";
            
            int iCurrentLabel = iCurrentPattern + 1;
            ppvLabelArray[iCurrentPattern].Text = "Pattern " + iCurrentLabel.ToString();
            iCurrentPattern = 0;
        }

        private void ppvStopButton_Click(object sender, EventArgs e)
        {
            fStartPatternMatch     = false;
            ppvStartButton.Enabled = true;
            ppvStopButton.Enabled  = false;
        }

        private void ppvClearSummary_Click(object sender, EventArgs e)
        {
            ppvPacketSummary.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "       LocoNetMon \n        Version " 
                             + LocoNetMonVersion 
                             + "." + MinorVersion, 
                             "About LocoNetMon" );
        }

        private void loadCaptureFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fFileOpen)
            {
                MessageBox.Show("Capture File currently open, close file first");
                return;
            }
            openCapturedFileDialog1.FileName   = szSaveFileName;
            openCapturedFileDialog1.DefaultExt = ".loc";
            openCapturedFileDialog1.Filter     = "LocoNet Capture Files (*.loc)|*.loc|All files (*.*)|*.*";
            
            DialogResult buttonClicked = openCapturedFileDialog1.ShowDialog();

            if (buttonClicked.Equals(DialogResult.OK))
            {
                string loadedCaptureFilename = openCapturedFileDialog1.ToString();

                szLoadedFileName    = loadedCaptureFilename.Substring(56);
                disCaptureFile.Text = szLoadedFileName;

                ProcessLoadedFile();
            }
            disButtonReScan.Enabled = true;
            disButtonReScan.Visible = true;
            ppvButtonReScan.Enabled = true;
            ppvButtonReScan.Visible = true;
        }

        private void ProcessLoadedFile()
        {
            try
            {
                // Create an instance of BinaryReader to read from a file.
                // The using statement also closes the BinaryReader.
                //
                using (loadedCaptureFile = new BinaryReader(File.OpenRead(szLoadedFileName)))
                {
                    rtf_disCapture.Clear();
                    rtf_disDetail.Clear();
                    iCheckSumErrors  = 0;
                    iBytesReceived   = 0;
                    iPacketsReceived = 0;
                    iPacketsCaptured = 0;
                    
                    ppvPatternErrorButton.BackColor = Color.LightGreen;
                    ppvPatternErrorButton.Text      = "No Pattern Error";

                    string szVersion = loadedCaptureFile.ReadString();
                    
                    if (LocoNetMonVersion != szVersion)
                    {
                        MessageBox.Show("Loaded File is incompatible with this version of LocoNetMon \n" +
                                        "             File Version = " + szVersion);
                        return;
                    }
                    
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    //
                    while( true )
                    {
                        DateTime CurrentDateTime = DateTime.FromBinary(loadedCaptureFile.ReadInt64());
                        int      iPacketSize     = loadedCaptureFile.ReadInt32();
                        byte[]   outBuffer       = new byte[iPacketSize];

                        outBuffer = loadedCaptureFile.ReadBytes(iPacketSize);
                        iBytesReceived += outBuffer.Length;
                        iPacketsReceived++;
                        Log(CurrentDateTime, outBuffer, true );
                    }
                }
            }
            catch (Exception e1)
            {
                if( e1.Message.StartsWith("Unable to read beyond the end of the stream") != true )
                    MessageBox.Show("The file could not be read: " + e1.Message.ToString() );
            }
        }

        private void disButtonReScan_Click(object sender, EventArgs e)
        {
            ProcessLoadedFile();
        }

        private void ppvButtonReScan_Click(object sender, EventArgs e)
        {
            ppvPacketSummary.Clear();
            ProcessLoadedFile();
        }

        private void capClearExcludeButton_Click(object sender, EventArgs e)
        {
            capA0exclude.Checked = false;
        }

        private void ppvMisMatchButton_Click(object sender, EventArgs e)
        {
            ppvPatternErrorButton.BackColor = Color.LightGreen;
            ppvPatternErrorButton.Text      = "No Pattern Error";
        }

        private void savePacketPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile_ppv.FileName   = szPpvFileName;
            saveFile_ppv.DefaultExt = ".ppv";
            saveFile_ppv.Filter     = "Packet Pattern Files (*.ppv)|*.ppv|All files (*.*)|*.*";
            
            DialogResult buttonClicked = saveFile_ppv.ShowDialog();

            if (buttonClicked.Equals(DialogResult.OK))
            {
                Stream ppvFileName = saveFile_ppv.OpenFile();
                ppvFileOutput = new BinaryWriter(ppvFileName);
                
                if (ppvFileOutput == null)
                {
                    MessageBox.Show("Unable to create Packet Pattern Verification File");
                    return;
                }

                szPpvFileName = saveFile_ppv.FileName;
                
                ppvFileOutput.Write(LocoNetMonVersion);

                // Save "Packet Patterns" to file
                //
                for (int i = 0; i < MaxPatterns; i++)
                {
                    ppvFileOutput.Write(ppvOpCodeArray[i].Text.ToUpper());
                    ppvFileOutput.Write(ppvAddressArray[i].Value);
                    ppvFileOutput.Write(ppvOnOffArray[i].Checked);
                    ppvFileOutput.Write(ppvDurationArray[i].Value);
                }
                ppvFileOutput.Close();
            }
        }

        private void loadPacketPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile_ppv.FileName   = szPpvFileName;
            openFile_ppv.DefaultExt = ".ppv";
            openFile_ppv.Filter     = "Packet Pattern Files (*.ppv)|*.ppv|All files (*.*)|*.*";

            DialogResult buttonClicked = openFile_ppv.ShowDialog();

            if (buttonClicked.Equals(DialogResult.OK))
            {
                string szVersion;
                string loadedPpvFilename = openFile_ppv.ToString();
                szPpvFileName            = loadedPpvFilename.Substring(56);
                
                try
                {
                    // Create an instance of BinaryReader to read from a file.
                    // The using statement also closes the BinaryReader.
                    //
                    using (ppvFileInput = new BinaryReader(File.OpenRead(szPpvFileName)))
                    {
                        szVersion = ppvFileInput.ReadString();
                        
                        // Versions don't match, let's check for older compatible versions
                        //
                        if (szVersion != LocoNetMonVersion)
                        {
                            MessageBox.Show("Packet Pattern Verifier File is incompatible with this version of LocoNetMon \n" +
                                            "             File Version = " + szVersion);
                            return;
                        }
                        
                        // Read "Packet Patterns" from file
                        //
                        for (int i = 0; i < MaxPatterns; i++)
                        {

                            ppvOpCodeArray [i].Text   = ppvFileInput.ReadString();
                            ppvAddressArray[i].Value  = ppvFileInput.ReadDecimal();
                            ppvOnOffArray[i].Checked  = ppvFileInput.ReadBoolean();
                            ppvDurationArray[i].Value = ppvFileInput.ReadDecimal();
                        }
                        ppvFileInput.Close();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("The Packet Pattern Verifier file could not be read: " + e1.Message.ToString());
                }
            }
        }

        private void COMportDCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortDCC.PortName = COMportDCC.Text;
            szCOMportDCC = COMportDCC.Text;

            if (comportDCC.IsOpen)
            {
                comportDCC.Close();

                // Set the port's settings
                //
                comportDCC.BaudRate = 19200;
                comportDCC.PortName = szCOMportDCC;
                comportDCC.RtsEnable = false;
                comportDCC.Handshake = System.IO.Ports.Handshake.RequestToSend;

                try
                {
                    comportDCC.Open(); // Open the port
                }
                catch
                {
                    MessageBox.Show("Unable to open DCC COM port");
                    return;
                }

                // If the port is open, send focus to the send data box
                if (comportDCC.IsOpen)
                {
                    // rtf_disCapture.Focus();
                    // disStartContinue.Enabled = false;
                    // disPause.Enabled = true;
                }
            }

        }
    }
}