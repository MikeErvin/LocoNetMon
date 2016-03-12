namespace LocoNetMon
{
    partial class LocoNetMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.disDCC = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.BaudRateDCC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.COMportDCC = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.disCaptureFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COMportLocoNet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BaudRateLocoNet = new System.Windows.Forms.ComboBox();
            this.tabCaptureFilters = new System.Windows.Forms.TabPage();
            this.capExcludeGroup = new System.Windows.Forms.GroupBox();
            this.capClearExcludeButton = new System.Windows.Forms.Button();
            this.capA0exclude = new System.Windows.Forms.CheckBox();
            this.capIncludeGroup = new System.Windows.Forms.GroupBox();
            this.capClearFilters = new System.Windows.Forms.Button();
            this.capALL = new System.Windows.Forms.CheckBox();
            this.capEEEF = new System.Windows.Forms.CheckBox();
            this.capE7 = new System.Windows.Forms.CheckBox();
            this.capE5 = new System.Windows.Forms.CheckBox();
            this.capBF = new System.Windows.Forms.CheckBox();
            this.capBB = new System.Windows.Forms.CheckBox();
            this.capB5 = new System.Windows.Forms.CheckBox();
            this.capB4 = new System.Windows.Forms.CheckBox();
            this.capB2 = new System.Windows.Forms.CheckBox();
            this.capB1 = new System.Windows.Forms.CheckBox();
            this.capB0 = new System.Windows.Forms.CheckBox();
            this.tabDisplayFilters = new System.Windows.Forms.TabPage();
            this.disButtonReScan = new System.Windows.Forms.Button();
            this.ClearSummary = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disPacketsReceived = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.disBytesReceived = new System.Windows.Forms.TextBox();
            this.disChecksumErrors = new System.Windows.Forms.TextBox();
            this.disPause = new System.Windows.Forms.Button();
            this.disStartContinue = new System.Windows.Forms.Button();
            this.rtf_disDetail = new System.Windows.Forms.RichTextBox();
            this.rtf_disCapture = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IbitChecked = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.disClearAdd = new System.Windows.Forms.Button();
            this.disAddAll = new System.Windows.Forms.CheckBox();
            this.disIncludeChk8 = new System.Windows.Forms.CheckBox();
            this.disAdd8 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk7 = new System.Windows.Forms.CheckBox();
            this.disAdd7 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk6 = new System.Windows.Forms.CheckBox();
            this.disAdd6 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk5 = new System.Windows.Forms.CheckBox();
            this.disAdd5 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk4 = new System.Windows.Forms.CheckBox();
            this.disAdd4 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk3 = new System.Windows.Forms.CheckBox();
            this.disAdd3 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk2 = new System.Windows.Forms.CheckBox();
            this.disAdd2 = new System.Windows.Forms.NumericUpDown();
            this.disIncludeChk1 = new System.Windows.Forms.CheckBox();
            this.disAdd1 = new System.Windows.Forms.NumericUpDown();
            this.disClearFilters = new System.Windows.Forms.Button();
            this.disALL = new System.Windows.Forms.CheckBox();
            this.disEEEF = new System.Windows.Forms.CheckBox();
            this.disE7 = new System.Windows.Forms.CheckBox();
            this.disE5 = new System.Windows.Forms.CheckBox();
            this.disBF = new System.Windows.Forms.CheckBox();
            this.disBB = new System.Windows.Forms.CheckBox();
            this.disB5 = new System.Windows.Forms.CheckBox();
            this.disB4 = new System.Windows.Forms.CheckBox();
            this.disB2 = new System.Windows.Forms.CheckBox();
            this.disB1 = new System.Windows.Forms.CheckBox();
            this.disB0 = new System.Windows.Forms.CheckBox();
            this.PacketVerifier = new System.Windows.Forms.TabPage();
            this.ppvPatternErrorButton = new System.Windows.Forms.Button();
            this.ppvButtonReScan = new System.Windows.Forms.Button();
            this.ppvStopOnMisMatch = new System.Windows.Forms.CheckBox();
            this.ppvClearSummary = new System.Windows.Forms.Button();
            this.ppvClearPatterns = new System.Windows.Forms.Button();
            this.ppvStopButton = new System.Windows.Forms.Button();
            this.ppvStartButton = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.ppvPacketSummary = new System.Windows.Forms.RichTextBox();
            this.ppvDuration20 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff20 = new System.Windows.Forms.CheckBox();
            this.ppvAddress20 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern20 = new System.Windows.Forms.Label();
            this.ppvOpCode20 = new System.Windows.Forms.ComboBox();
            this.ppvDuration19 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff19 = new System.Windows.Forms.CheckBox();
            this.ppvAddress19 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern19 = new System.Windows.Forms.Label();
            this.ppvOpCode19 = new System.Windows.Forms.ComboBox();
            this.ppvDuration18 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff18 = new System.Windows.Forms.CheckBox();
            this.ppvAddress18 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern18 = new System.Windows.Forms.Label();
            this.ppvOpCode18 = new System.Windows.Forms.ComboBox();
            this.ppvDuration17 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff17 = new System.Windows.Forms.CheckBox();
            this.ppvAddress17 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern17 = new System.Windows.Forms.Label();
            this.ppvOpCode17 = new System.Windows.Forms.ComboBox();
            this.ppvDuration16 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff16 = new System.Windows.Forms.CheckBox();
            this.ppvAddress16 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern16 = new System.Windows.Forms.Label();
            this.ppvOpCode16 = new System.Windows.Forms.ComboBox();
            this.ppvDuration15 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff15 = new System.Windows.Forms.CheckBox();
            this.ppvAddress15 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern15 = new System.Windows.Forms.Label();
            this.ppvOpCode15 = new System.Windows.Forms.ComboBox();
            this.ppvDuration14 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff14 = new System.Windows.Forms.CheckBox();
            this.ppvAddress14 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern14 = new System.Windows.Forms.Label();
            this.ppvOpCode14 = new System.Windows.Forms.ComboBox();
            this.ppvDuration13 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff13 = new System.Windows.Forms.CheckBox();
            this.ppvAddress13 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern13 = new System.Windows.Forms.Label();
            this.ppvOpCode13 = new System.Windows.Forms.ComboBox();
            this.ppvDuration12 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff12 = new System.Windows.Forms.CheckBox();
            this.ppvAddress12 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern12 = new System.Windows.Forms.Label();
            this.ppvOpCode12 = new System.Windows.Forms.ComboBox();
            this.ppvDuration11 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff11 = new System.Windows.Forms.CheckBox();
            this.ppvAddress11 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern11 = new System.Windows.Forms.Label();
            this.ppvOpCode11 = new System.Windows.Forms.ComboBox();
            this.ppvDuration10 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff10 = new System.Windows.Forms.CheckBox();
            this.ppvAddress10 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern10 = new System.Windows.Forms.Label();
            this.ppvOpCode10 = new System.Windows.Forms.ComboBox();
            this.ppvDuration9 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff9 = new System.Windows.Forms.CheckBox();
            this.ppvAddress9 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern9 = new System.Windows.Forms.Label();
            this.ppvOpCode9 = new System.Windows.Forms.ComboBox();
            this.ppvDuration8 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff8 = new System.Windows.Forms.CheckBox();
            this.ppvAddress8 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern8 = new System.Windows.Forms.Label();
            this.ppvOpCode8 = new System.Windows.Forms.ComboBox();
            this.ppvDuration7 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff7 = new System.Windows.Forms.CheckBox();
            this.ppvAddress7 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern7 = new System.Windows.Forms.Label();
            this.ppvOpCode7 = new System.Windows.Forms.ComboBox();
            this.ppvDuration6 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff6 = new System.Windows.Forms.CheckBox();
            this.ppvAddress6 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern6 = new System.Windows.Forms.Label();
            this.ppvOpCode6 = new System.Windows.Forms.ComboBox();
            this.ppvDuration5 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff5 = new System.Windows.Forms.CheckBox();
            this.ppvAddress5 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern5 = new System.Windows.Forms.Label();
            this.ppvOpCode5 = new System.Windows.Forms.ComboBox();
            this.ppvDuration4 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff4 = new System.Windows.Forms.CheckBox();
            this.ppvAddress4 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern4 = new System.Windows.Forms.Label();
            this.ppvOpCode4 = new System.Windows.Forms.ComboBox();
            this.ppvDuration3 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff3 = new System.Windows.Forms.CheckBox();
            this.ppvAddress3 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern3 = new System.Windows.Forms.Label();
            this.ppvOpCode3 = new System.Windows.Forms.ComboBox();
            this.ppvDuration2 = new System.Windows.Forms.NumericUpDown();
            this.ppvOnOff2 = new System.Windows.Forms.CheckBox();
            this.ppvAddress2 = new System.Windows.Forms.NumericUpDown();
            this.labelPattern2 = new System.Windows.Forms.Label();
            this.ppvOpCode2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ppvDuration1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.ppvOnOff1 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ppvAddress1 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.labelPattern1 = new System.Windows.Forms.Label();
            this.ppvOpCode1 = new System.Windows.Forms.ComboBox();
            this.tabDCCdisplay = new System.Windows.Forms.TabPage();
            this.serialPortLocoNet = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCaptureFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPacketPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePacketPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openCapturedFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile_ppv = new System.Windows.Forms.SaveFileDialog();
            this.openFile_ppv = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.serialPortDCC = new System.IO.Ports.SerialPort(this.components);
            this.disDCC.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabCaptureFilters.SuspendLayout();
            this.capExcludeGroup.SuspendLayout();
            this.capIncludeGroup.SuspendLayout();
            this.tabDisplayFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd1)).BeginInit();
            this.PacketVerifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress1)).BeginInit();
            this.tabDCCdisplay.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            this.SuspendLayout();
            // 
            // disDCC
            // 
            this.disDCC.Controls.Add(this.tabSetup);
            this.disDCC.Controls.Add(this.tabCaptureFilters);
            this.disDCC.Controls.Add(this.tabDisplayFilters);
            this.disDCC.Controls.Add(this.PacketVerifier);
            this.disDCC.Controls.Add(this.tabDCCdisplay);
            this.disDCC.Location = new System.Drawing.Point(3, 33);
            this.disDCC.Name = "disDCC";
            this.disDCC.SelectedIndex = 0;
            this.disDCC.Size = new System.Drawing.Size(965, 597);
            this.disDCC.TabIndex = 0;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.BaudRateDCC);
            this.tabSetup.Controls.Add(this.label17);
            this.tabSetup.Controls.Add(this.COMportDCC);
            this.tabSetup.Controls.Add(this.label22);
            this.tabSetup.Controls.Add(this.disCaptureFile);
            this.tabSetup.Controls.Add(this.label9);
            this.tabSetup.Controls.Add(this.label2);
            this.tabSetup.Controls.Add(this.COMportLocoNet);
            this.tabSetup.Controls.Add(this.label1);
            this.tabSetup.Controls.Add(this.BaudRateLocoNet);
            this.tabSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSetup.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabSetup.Location = new System.Drawing.Point(4, 22);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(957, 571);
            this.tabSetup.TabIndex = 0;
            this.tabSetup.Text = "Setup";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // BaudRateDCC
            // 
            this.BaudRateDCC.Enabled = false;
            this.BaudRateDCC.Location = new System.Drawing.Point(670, 270);
            this.BaudRateDCC.Name = "BaudRateDCC";
            this.BaudRateDCC.Size = new System.Drawing.Size(82, 23);
            this.BaudRateDCC.TabIndex = 38;
            this.BaudRateDCC.Text = "19200";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(527, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "COM Port (DCC)";
            // 
            // COMportDCC
            // 
            this.COMportDCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMportDCC.FormattingEnabled = true;
            this.COMportDCC.Location = new System.Drawing.Point(670, 211);
            this.COMportDCC.Name = "COMportDCC";
            this.COMportDCC.Size = new System.Drawing.Size(83, 24);
            this.COMportDCC.TabIndex = 36;
            this.COMportDCC.SelectedIndexChanged += new System.EventHandler(this.COMportDCC_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label22.Location = new System.Drawing.Point(527, 270);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 17);
            this.label22.TabIndex = 35;
            this.label22.Text = "Bits Per Second";
            // 
            // disCaptureFile
            // 
            this.disCaptureFile.Location = new System.Drawing.Point(107, 537);
            this.disCaptureFile.Name = "disCaptureFile";
            this.disCaptureFile.ReadOnly = true;
            this.disCaptureFile.Size = new System.Drawing.Size(836, 23);
            this.disCaptureFile.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Capture File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(140, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM Port (LocoNet)";
            // 
            // COMportLocoNet
            // 
            this.COMportLocoNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMportLocoNet.FormattingEnabled = true;
            this.COMportLocoNet.Location = new System.Drawing.Point(283, 208);
            this.COMportLocoNet.Name = "COMportLocoNet";
            this.COMportLocoNet.Size = new System.Drawing.Size(83, 24);
            this.COMportLocoNet.TabIndex = 2;
            this.COMportLocoNet.SelectedIndexChanged += new System.EventHandler(this.COMport_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(140, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bits Per Second";
            // 
            // BaudRateLocoNet
            // 
            this.BaudRateLocoNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateLocoNet.FormattingEnabled = true;
            this.BaudRateLocoNet.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.BaudRateLocoNet.Location = new System.Drawing.Point(283, 267);
            this.BaudRateLocoNet.Name = "BaudRateLocoNet";
            this.BaudRateLocoNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BaudRateLocoNet.Size = new System.Drawing.Size(83, 24);
            this.BaudRateLocoNet.TabIndex = 0;
            this.BaudRateLocoNet.TabStop = false;
            this.BaudRateLocoNet.Text = "57600";
            this.BaudRateLocoNet.SelectedIndexChanged += new System.EventHandler(this.BaudRate_SelectedIndexChanged);
            // 
            // tabCaptureFilters
            // 
            this.tabCaptureFilters.Controls.Add(this.capExcludeGroup);
            this.tabCaptureFilters.Controls.Add(this.capIncludeGroup);
            this.tabCaptureFilters.Location = new System.Drawing.Point(4, 22);
            this.tabCaptureFilters.Name = "tabCaptureFilters";
            this.tabCaptureFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaptureFilters.Size = new System.Drawing.Size(957, 571);
            this.tabCaptureFilters.TabIndex = 1;
            this.tabCaptureFilters.Text = "Capture Filters";
            this.tabCaptureFilters.UseVisualStyleBackColor = true;
            // 
            // capExcludeGroup
            // 
            this.capExcludeGroup.Controls.Add(this.capClearExcludeButton);
            this.capExcludeGroup.Controls.Add(this.capA0exclude);
            this.capExcludeGroup.Location = new System.Drawing.Point(559, 119);
            this.capExcludeGroup.Name = "capExcludeGroup";
            this.capExcludeGroup.Size = new System.Drawing.Size(200, 316);
            this.capExcludeGroup.TabIndex = 19;
            this.capExcludeGroup.TabStop = false;
            this.capExcludeGroup.Text = "Exclude Filters";
            // 
            // capClearExcludeButton
            // 
            this.capClearExcludeButton.Location = new System.Drawing.Point(43, 279);
            this.capClearExcludeButton.Name = "capClearExcludeButton";
            this.capClearExcludeButton.Size = new System.Drawing.Size(120, 23);
            this.capClearExcludeButton.TabIndex = 1;
            this.capClearExcludeButton.Text = "Clear Exlcude Filters";
            this.capClearExcludeButton.UseVisualStyleBackColor = true;
            this.capClearExcludeButton.Click += new System.EventHandler(this.capClearExcludeButton_Click);
            // 
            // capA0exclude
            // 
            this.capA0exclude.AutoSize = true;
            this.capA0exclude.Location = new System.Drawing.Point(15, 21);
            this.capA0exclude.Name = "capA0exclude";
            this.capA0exclude.Size = new System.Drawing.Size(84, 17);
            this.capA0exclude.TabIndex = 0;
            this.capA0exclude.Text = "A0 - Throttle";
            this.capA0exclude.UseVisualStyleBackColor = true;
            // 
            // capIncludeGroup
            // 
            this.capIncludeGroup.Controls.Add(this.capClearFilters);
            this.capIncludeGroup.Controls.Add(this.capALL);
            this.capIncludeGroup.Controls.Add(this.capEEEF);
            this.capIncludeGroup.Controls.Add(this.capE7);
            this.capIncludeGroup.Controls.Add(this.capE5);
            this.capIncludeGroup.Controls.Add(this.capBF);
            this.capIncludeGroup.Controls.Add(this.capBB);
            this.capIncludeGroup.Controls.Add(this.capB5);
            this.capIncludeGroup.Controls.Add(this.capB4);
            this.capIncludeGroup.Controls.Add(this.capB2);
            this.capIncludeGroup.Controls.Add(this.capB1);
            this.capIncludeGroup.Controls.Add(this.capB0);
            this.capIncludeGroup.Location = new System.Drawing.Point(253, 119);
            this.capIncludeGroup.Name = "capIncludeGroup";
            this.capIncludeGroup.Size = new System.Drawing.Size(200, 316);
            this.capIncludeGroup.TabIndex = 18;
            this.capIncludeGroup.TabStop = false;
            this.capIncludeGroup.Text = "Include Filters";
            // 
            // capClearFilters
            // 
            this.capClearFilters.Location = new System.Drawing.Point(47, 281);
            this.capClearFilters.Name = "capClearFilters";
            this.capClearFilters.Size = new System.Drawing.Size(107, 21);
            this.capClearFilters.TabIndex = 27;
            this.capClearFilters.Text = "Clear Include Filters";
            this.capClearFilters.UseVisualStyleBackColor = true;
            this.capClearFilters.Click += new System.EventHandler(this.button2_Click);
            // 
            // capALL
            // 
            this.capALL.AutoSize = true;
            this.capALL.Checked = true;
            this.capALL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.capALL.Location = new System.Drawing.Point(17, 258);
            this.capALL.Name = "capALL";
            this.capALL.Size = new System.Drawing.Size(79, 17);
            this.capALL.TabIndex = 26;
            this.capALL.Text = "All Packets";
            this.capALL.UseVisualStyleBackColor = true;
            // 
            // capEEEF
            // 
            this.capEEEF.AutoSize = true;
            this.capEEEF.Location = new System.Drawing.Point(17, 236);
            this.capEEEF.Name = "capEEEF";
            this.capEEEF.Size = new System.Drawing.Size(137, 17);
            this.capEEEF.TabIndex = 25;
            this.capEEEF.Text = "EE,EF - Write Slot Data";
            this.capEEEF.UseVisualStyleBackColor = true;
            // 
            // capE7
            // 
            this.capE7.AutoSize = true;
            this.capE7.Location = new System.Drawing.Point(17, 212);
            this.capE7.Name = "capE7";
            this.capE7.Size = new System.Drawing.Size(127, 17);
            this.capE7.TabIndex = 24;
            this.capE7.Text = "E7 - Slot Data Return";
            this.capE7.UseVisualStyleBackColor = true;
            // 
            // capE5
            // 
            this.capE5.AutoSize = true;
            this.capE5.Location = new System.Drawing.Point(17, 188);
            this.capE5.Name = "capE5";
            this.capE5.Size = new System.Drawing.Size(94, 17);
            this.capE5.TabIndex = 23;
            this.capE5.Text = "E5 - Unknown";
            this.capE5.UseVisualStyleBackColor = true;
            // 
            // capBF
            // 
            this.capBF.AutoSize = true;
            this.capBF.Location = new System.Drawing.Point(17, 164);
            this.capBF.Name = "capBF";
            this.capBF.Size = new System.Drawing.Size(156, 17);
            this.capBF.TabIndex = 22;
            this.capBF.Text = "BF - Request Loco Address";
            this.capBF.UseVisualStyleBackColor = true;
            // 
            // capBB
            // 
            this.capBB.AutoSize = true;
            this.capBB.Location = new System.Drawing.Point(17, 140);
            this.capBB.Name = "capBB";
            this.capBB.Size = new System.Drawing.Size(136, 17);
            this.capBB.TabIndex = 21;
            this.capBB.Text = "BB - Request Slot Data";
            this.capBB.UseVisualStyleBackColor = true;
            // 
            // capB5
            // 
            this.capB5.AutoSize = true;
            this.capB5.Location = new System.Drawing.Point(17, 116);
            this.capB5.Name = "capB5";
            this.capB5.Size = new System.Drawing.Size(104, 17);
            this.capB5.TabIndex = 20;
            this.capB5.Text = "B5 - Write Slot S";
            this.capB5.UseVisualStyleBackColor = true;
            // 
            // capB4
            // 
            this.capB4.AutoSize = true;
            this.capB4.Location = new System.Drawing.Point(17, 92);
            this.capB4.Name = "capB4";
            this.capB4.Size = new System.Drawing.Size(94, 17);
            this.capB4.TabIndex = 19;
            this.capB4.Text = "B4 - Long Ack";
            this.capB4.UseVisualStyleBackColor = true;
            // 
            // capB2
            // 
            this.capB2.AutoSize = true;
            this.capB2.Location = new System.Drawing.Point(17, 68);
            this.capB2.Name = "capB2";
            this.capB2.Size = new System.Drawing.Size(148, 17);
            this.capB2.TabIndex = 18;
            this.capB2.Text = "B2 - General Sensor Input";
            this.capB2.UseVisualStyleBackColor = true;
            // 
            // capB1
            // 
            this.capB1.AutoSize = true;
            this.capB1.Location = new System.Drawing.Point(17, 44);
            this.capB1.Name = "capB1";
            this.capB1.Size = new System.Drawing.Size(115, 17);
            this.capB1.TabIndex = 17;
            this.capB1.Text = "B1 - Switch Report";
            this.capB1.UseVisualStyleBackColor = true;
            // 
            // capB0
            // 
            this.capB0.AutoSize = true;
            this.capB0.Location = new System.Drawing.Point(17, 21);
            this.capB0.Name = "capB0";
            this.capB0.Size = new System.Drawing.Size(123, 17);
            this.capB0.TabIndex = 16;
            this.capB0.Text = "B0 - Switch Request";
            this.capB0.UseVisualStyleBackColor = true;
            // 
            // tabDisplayFilters
            // 
            this.tabDisplayFilters.Controls.Add(this.disButtonReScan);
            this.tabDisplayFilters.Controls.Add(this.ClearSummary);
            this.tabDisplayFilters.Controls.Add(this.label16);
            this.tabDisplayFilters.Controls.Add(this.label15);
            this.tabDisplayFilters.Controls.Add(this.label14);
            this.tabDisplayFilters.Controls.Add(this.label13);
            this.tabDisplayFilters.Controls.Add(this.label12);
            this.tabDisplayFilters.Controls.Add(this.label11);
            this.tabDisplayFilters.Controls.Add(this.label7);
            this.tabDisplayFilters.Controls.Add(this.label6);
            this.tabDisplayFilters.Controls.Add(this.label5);
            this.tabDisplayFilters.Controls.Add(this.disPacketsReceived);
            this.tabDisplayFilters.Controls.Add(this.label4);
            this.tabDisplayFilters.Controls.Add(this.label3);
            this.tabDisplayFilters.Controls.Add(this.disBytesReceived);
            this.tabDisplayFilters.Controls.Add(this.disChecksumErrors);
            this.tabDisplayFilters.Controls.Add(this.disPause);
            this.tabDisplayFilters.Controls.Add(this.disStartContinue);
            this.tabDisplayFilters.Controls.Add(this.rtf_disDetail);
            this.tabDisplayFilters.Controls.Add(this.rtf_disCapture);
            this.tabDisplayFilters.Controls.Add(this.groupBox2);
            this.tabDisplayFilters.Location = new System.Drawing.Point(4, 22);
            this.tabDisplayFilters.Name = "tabDisplayFilters";
            this.tabDisplayFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplayFilters.Size = new System.Drawing.Size(957, 571);
            this.tabDisplayFilters.TabIndex = 2;
            this.tabDisplayFilters.Text = "LocoNet Display";
            this.tabDisplayFilters.UseVisualStyleBackColor = true;
            // 
            // disButtonReScan
            // 
            this.disButtonReScan.Enabled = false;
            this.disButtonReScan.Location = new System.Drawing.Point(752, 8);
            this.disButtonReScan.Name = "disButtonReScan";
            this.disButtonReScan.Size = new System.Drawing.Size(76, 23);
            this.disButtonReScan.TabIndex = 42;
            this.disButtonReScan.Text = "Re-Scan File";
            this.disButtonReScan.UseVisualStyleBackColor = true;
            this.disButtonReScan.Visible = false;
            this.disButtonReScan.Click += new System.EventHandler(this.disButtonReScan_Click);
            // 
            // ClearSummary
            // 
            this.ClearSummary.Location = new System.Drawing.Point(854, 8);
            this.ClearSummary.Name = "ClearSummary";
            this.ClearSummary.Size = new System.Drawing.Size(90, 23);
            this.ClearSummary.TabIndex = 41;
            this.ClearSummary.Text = "Clear Summary";
            this.ClearSummary.UseVisualStyleBackColor = true;
            this.ClearSummary.Click += new System.EventHandler(this.ClearSummary_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(412, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(611, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Hex Representation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(479, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Address/Slot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Packet #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(653, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Packet Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Packet Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Packets Received";
            // 
            // disPacketsReceived
            // 
            this.disPacketsReceived.Location = new System.Drawing.Point(270, 415);
            this.disPacketsReceived.Name = "disPacketsReceived";
            this.disPacketsReceived.ReadOnly = true;
            this.disPacketsReceived.Size = new System.Drawing.Size(95, 20);
            this.disPacketsReceived.TabIndex = 28;
            this.disPacketsReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Checksum Errors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bytes Received";
            // 
            // disBytesReceived
            // 
            this.disBytesReceived.Location = new System.Drawing.Point(270, 457);
            this.disBytesReceived.Name = "disBytesReceived";
            this.disBytesReceived.ReadOnly = true;
            this.disBytesReceived.Size = new System.Drawing.Size(95, 20);
            this.disBytesReceived.TabIndex = 25;
            this.disBytesReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disChecksumErrors
            // 
            this.disChecksumErrors.Location = new System.Drawing.Point(270, 495);
            this.disChecksumErrors.Name = "disChecksumErrors";
            this.disChecksumErrors.ReadOnly = true;
            this.disChecksumErrors.Size = new System.Drawing.Size(95, 20);
            this.disChecksumErrors.TabIndex = 24;
            this.disChecksumErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disPause
            // 
            this.disPause.Enabled = false;
            this.disPause.Location = new System.Drawing.Point(265, 371);
            this.disPause.Name = "disPause";
            this.disPause.Size = new System.Drawing.Size(106, 23);
            this.disPause.TabIndex = 23;
            this.disPause.Text = "Pause Capture";
            this.disPause.UseVisualStyleBackColor = true;
            this.disPause.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // disStartContinue
            // 
            this.disStartContinue.Location = new System.Drawing.Point(247, 339);
            this.disStartContinue.Name = "disStartContinue";
            this.disStartContinue.Size = new System.Drawing.Size(141, 23);
            this.disStartContinue.TabIndex = 22;
            this.disStartContinue.Text = "Start/Continue Capture";
            this.disStartContinue.UseVisualStyleBackColor = true;
            this.disStartContinue.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rtf_disDetail
            // 
            this.rtf_disDetail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtf_disDetail.Location = new System.Drawing.Point(417, 339);
            this.rtf_disDetail.Name = "rtf_disDetail";
            this.rtf_disDetail.ReadOnly = true;
            this.rtf_disDetail.Size = new System.Drawing.Size(532, 225);
            this.rtf_disDetail.TabIndex = 21;
            this.rtf_disDetail.Text = "";
            this.rtf_disDetail.WordWrap = false;
            // 
            // rtf_disCapture
            // 
            this.rtf_disCapture.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.rtf_disCapture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtf_disCapture.Location = new System.Drawing.Point(247, 37);
            this.rtf_disCapture.Name = "rtf_disCapture";
            this.rtf_disCapture.ReadOnly = true;
            this.rtf_disCapture.Size = new System.Drawing.Size(702, 278);
            this.rtf_disCapture.TabIndex = 20;
            this.rtf_disCapture.Text = "";
            this.rtf_disCapture.WordWrap = false;
            this.rtf_disCapture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtf_disCapture_KeyDown);
            this.rtf_disCapture.Click += new System.EventHandler(this.rtf_disCapture_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IbitChecked);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.disClearFilters);
            this.groupBox2.Controls.Add(this.disALL);
            this.groupBox2.Controls.Add(this.disEEEF);
            this.groupBox2.Controls.Add(this.disE7);
            this.groupBox2.Controls.Add(this.disE5);
            this.groupBox2.Controls.Add(this.disBF);
            this.groupBox2.Controls.Add(this.disBB);
            this.groupBox2.Controls.Add(this.disB5);
            this.groupBox2.Controls.Add(this.disB4);
            this.groupBox2.Controls.Add(this.disB2);
            this.groupBox2.Controls.Add(this.disB1);
            this.groupBox2.Controls.Add(this.disB0);
            this.groupBox2.Location = new System.Drawing.Point(15, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 548);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Filters";
            // 
            // IbitChecked
            // 
            this.IbitChecked.AutoSize = true;
            this.IbitChecked.Checked = true;
            this.IbitChecked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IbitChecked.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbitChecked.Location = new System.Drawing.Point(167, 64);
            this.IbitChecked.Name = "IbitChecked";
            this.IbitChecked.Size = new System.Drawing.Size(57, 18);
            this.IbitChecked.TabIndex = 29;
            this.IbitChecked.Text = "\"I\" bit";
            this.IbitChecked.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.disClearAdd);
            this.groupBox3.Controls.Add(this.disAddAll);
            this.groupBox3.Controls.Add(this.disIncludeChk8);
            this.groupBox3.Controls.Add(this.disAdd8);
            this.groupBox3.Controls.Add(this.disIncludeChk7);
            this.groupBox3.Controls.Add(this.disAdd7);
            this.groupBox3.Controls.Add(this.disIncludeChk6);
            this.groupBox3.Controls.Add(this.disAdd6);
            this.groupBox3.Controls.Add(this.disIncludeChk5);
            this.groupBox3.Controls.Add(this.disAdd5);
            this.groupBox3.Controls.Add(this.disIncludeChk4);
            this.groupBox3.Controls.Add(this.disAdd4);
            this.groupBox3.Controls.Add(this.disIncludeChk3);
            this.groupBox3.Controls.Add(this.disAdd3);
            this.groupBox3.Controls.Add(this.disIncludeChk2);
            this.groupBox3.Controls.Add(this.disAdd2);
            this.groupBox3.Controls.Add(this.disIncludeChk1);
            this.groupBox3.Controls.Add(this.disAdd1);
            this.groupBox3.Location = new System.Drawing.Point(17, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 273);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display Packets from Addresses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Addresses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Include";
            // 
            // disClearAdd
            // 
            this.disClearAdd.Location = new System.Drawing.Point(132, 245);
            this.disClearAdd.Name = "disClearAdd";
            this.disClearAdd.Size = new System.Drawing.Size(53, 23);
            this.disClearAdd.TabIndex = 25;
            this.disClearAdd.Text = "Clear All";
            this.disClearAdd.UseVisualStyleBackColor = true;
            this.disClearAdd.Click += new System.EventHandler(this.disClearAdd_Click);
            // 
            // disAddAll
            // 
            this.disAddAll.AutoSize = true;
            this.disAddAll.Checked = true;
            this.disAddAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disAddAll.Location = new System.Drawing.Point(8, 249);
            this.disAddAll.Name = "disAddAll";
            this.disAddAll.Size = new System.Drawing.Size(126, 17);
            this.disAddAll.TabIndex = 24;
            this.disAddAll.Text = "Display All Addresses";
            this.disAddAll.UseVisualStyleBackColor = true;
            // 
            // disIncludeChk8
            // 
            this.disIncludeChk8.AutoSize = true;
            this.disIncludeChk8.Location = new System.Drawing.Point(128, 227);
            this.disIncludeChk8.Name = "disIncludeChk8";
            this.disIncludeChk8.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk8.TabIndex = 23;
            this.disIncludeChk8.UseVisualStyleBackColor = true;
            // 
            // disAdd8
            // 
            this.disAdd8.Location = new System.Drawing.Point(45, 224);
            this.disAdd8.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd8.Name = "disAdd8";
            this.disAdd8.Size = new System.Drawing.Size(55, 20);
            this.disAdd8.TabIndex = 22;
            this.disAdd8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk7
            // 
            this.disIncludeChk7.AutoSize = true;
            this.disIncludeChk7.Location = new System.Drawing.Point(128, 201);
            this.disIncludeChk7.Name = "disIncludeChk7";
            this.disIncludeChk7.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk7.TabIndex = 20;
            this.disIncludeChk7.UseVisualStyleBackColor = true;
            // 
            // disAdd7
            // 
            this.disAdd7.Location = new System.Drawing.Point(45, 198);
            this.disAdd7.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd7.Name = "disAdd7";
            this.disAdd7.Size = new System.Drawing.Size(55, 20);
            this.disAdd7.TabIndex = 19;
            this.disAdd7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk6
            // 
            this.disIncludeChk6.AutoSize = true;
            this.disIncludeChk6.Location = new System.Drawing.Point(128, 175);
            this.disIncludeChk6.Name = "disIncludeChk6";
            this.disIncludeChk6.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk6.TabIndex = 17;
            this.disIncludeChk6.UseVisualStyleBackColor = true;
            // 
            // disAdd6
            // 
            this.disAdd6.Location = new System.Drawing.Point(45, 172);
            this.disAdd6.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd6.Name = "disAdd6";
            this.disAdd6.Size = new System.Drawing.Size(55, 20);
            this.disAdd6.TabIndex = 16;
            this.disAdd6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk5
            // 
            this.disIncludeChk5.AutoSize = true;
            this.disIncludeChk5.Location = new System.Drawing.Point(128, 149);
            this.disIncludeChk5.Name = "disIncludeChk5";
            this.disIncludeChk5.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk5.TabIndex = 14;
            this.disIncludeChk5.UseVisualStyleBackColor = true;
            // 
            // disAdd5
            // 
            this.disAdd5.Location = new System.Drawing.Point(45, 146);
            this.disAdd5.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd5.Name = "disAdd5";
            this.disAdd5.Size = new System.Drawing.Size(55, 20);
            this.disAdd5.TabIndex = 13;
            this.disAdd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk4
            // 
            this.disIncludeChk4.AutoSize = true;
            this.disIncludeChk4.Location = new System.Drawing.Point(128, 123);
            this.disIncludeChk4.Name = "disIncludeChk4";
            this.disIncludeChk4.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk4.TabIndex = 11;
            this.disIncludeChk4.UseVisualStyleBackColor = true;
            // 
            // disAdd4
            // 
            this.disAdd4.Location = new System.Drawing.Point(45, 120);
            this.disAdd4.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd4.Name = "disAdd4";
            this.disAdd4.Size = new System.Drawing.Size(55, 20);
            this.disAdd4.TabIndex = 10;
            this.disAdd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk3
            // 
            this.disIncludeChk3.AutoSize = true;
            this.disIncludeChk3.Location = new System.Drawing.Point(128, 97);
            this.disIncludeChk3.Name = "disIncludeChk3";
            this.disIncludeChk3.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk3.TabIndex = 8;
            this.disIncludeChk3.UseVisualStyleBackColor = true;
            // 
            // disAdd3
            // 
            this.disAdd3.Location = new System.Drawing.Point(45, 94);
            this.disAdd3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd3.Name = "disAdd3";
            this.disAdd3.Size = new System.Drawing.Size(55, 20);
            this.disAdd3.TabIndex = 7;
            this.disAdd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk2
            // 
            this.disIncludeChk2.AutoSize = true;
            this.disIncludeChk2.Location = new System.Drawing.Point(128, 71);
            this.disIncludeChk2.Name = "disIncludeChk2";
            this.disIncludeChk2.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk2.TabIndex = 5;
            this.disIncludeChk2.UseVisualStyleBackColor = true;
            // 
            // disAdd2
            // 
            this.disAdd2.Location = new System.Drawing.Point(45, 68);
            this.disAdd2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd2.Name = "disAdd2";
            this.disAdd2.Size = new System.Drawing.Size(55, 20);
            this.disAdd2.TabIndex = 4;
            this.disAdd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disIncludeChk1
            // 
            this.disIncludeChk1.AutoSize = true;
            this.disIncludeChk1.Location = new System.Drawing.Point(128, 45);
            this.disIncludeChk1.Name = "disIncludeChk1";
            this.disIncludeChk1.Size = new System.Drawing.Size(15, 14);
            this.disIncludeChk1.TabIndex = 2;
            this.disIncludeChk1.UseVisualStyleBackColor = true;
            // 
            // disAdd1
            // 
            this.disAdd1.Location = new System.Drawing.Point(45, 42);
            this.disAdd1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.disAdd1.Name = "disAdd1";
            this.disAdd1.Size = new System.Drawing.Size(55, 20);
            this.disAdd1.TabIndex = 1;
            this.disAdd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disClearFilters
            // 
            this.disClearFilters.Location = new System.Drawing.Point(100, 236);
            this.disClearFilters.Name = "disClearFilters";
            this.disClearFilters.Size = new System.Drawing.Size(83, 21);
            this.disClearFilters.TabIndex = 27;
            this.disClearFilters.Text = "Clear Filters";
            this.disClearFilters.UseVisualStyleBackColor = true;
            this.disClearFilters.Click += new System.EventHandler(this.button4_Click);
            // 
            // disALL
            // 
            this.disALL.AutoSize = true;
            this.disALL.Checked = true;
            this.disALL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disALL.Location = new System.Drawing.Point(17, 238);
            this.disALL.Name = "disALL";
            this.disALL.Size = new System.Drawing.Size(79, 17);
            this.disALL.TabIndex = 26;
            this.disALL.Text = "All Packets";
            this.disALL.UseVisualStyleBackColor = true;
            // 
            // disEEEF
            // 
            this.disEEEF.AutoSize = true;
            this.disEEEF.Location = new System.Drawing.Point(17, 218);
            this.disEEEF.Name = "disEEEF";
            this.disEEEF.Size = new System.Drawing.Size(137, 17);
            this.disEEEF.TabIndex = 25;
            this.disEEEF.Text = "EE,EF - Write Slot Data";
            this.disEEEF.UseVisualStyleBackColor = true;
            // 
            // disE7
            // 
            this.disE7.AutoSize = true;
            this.disE7.Location = new System.Drawing.Point(17, 196);
            this.disE7.Name = "disE7";
            this.disE7.Size = new System.Drawing.Size(127, 17);
            this.disE7.TabIndex = 24;
            this.disE7.Text = "E7 - Slot Data Return";
            this.disE7.UseVisualStyleBackColor = true;
            // 
            // disE5
            // 
            this.disE5.AutoSize = true;
            this.disE5.Location = new System.Drawing.Point(17, 174);
            this.disE5.Name = "disE5";
            this.disE5.Size = new System.Drawing.Size(94, 17);
            this.disE5.TabIndex = 23;
            this.disE5.Text = "E5 - Unknown";
            this.disE5.UseVisualStyleBackColor = true;
            // 
            // disBF
            // 
            this.disBF.AutoSize = true;
            this.disBF.Location = new System.Drawing.Point(17, 152);
            this.disBF.Name = "disBF";
            this.disBF.Size = new System.Drawing.Size(156, 17);
            this.disBF.TabIndex = 22;
            this.disBF.Text = "BF - Request Loco Address";
            this.disBF.UseVisualStyleBackColor = true;
            // 
            // disBB
            // 
            this.disBB.AutoSize = true;
            this.disBB.Location = new System.Drawing.Point(17, 130);
            this.disBB.Name = "disBB";
            this.disBB.Size = new System.Drawing.Size(136, 17);
            this.disBB.TabIndex = 21;
            this.disBB.Text = "BB - Request Slot Data";
            this.disBB.UseVisualStyleBackColor = true;
            // 
            // disB5
            // 
            this.disB5.AutoSize = true;
            this.disB5.Location = new System.Drawing.Point(17, 108);
            this.disB5.Name = "disB5";
            this.disB5.Size = new System.Drawing.Size(104, 17);
            this.disB5.TabIndex = 20;
            this.disB5.Text = "B5 - Write Slot S";
            this.disB5.UseVisualStyleBackColor = true;
            // 
            // disB4
            // 
            this.disB4.AutoSize = true;
            this.disB4.Location = new System.Drawing.Point(17, 86);
            this.disB4.Name = "disB4";
            this.disB4.Size = new System.Drawing.Size(94, 17);
            this.disB4.TabIndex = 19;
            this.disB4.Text = "B4 - Long Ack";
            this.disB4.UseVisualStyleBackColor = true;
            // 
            // disB2
            // 
            this.disB2.AutoSize = true;
            this.disB2.Location = new System.Drawing.Point(17, 64);
            this.disB2.Name = "disB2";
            this.disB2.Size = new System.Drawing.Size(148, 17);
            this.disB2.TabIndex = 18;
            this.disB2.Text = "B2 - General Sensor Input";
            this.disB2.UseVisualStyleBackColor = true;
            // 
            // disB1
            // 
            this.disB1.AutoSize = true;
            this.disB1.Location = new System.Drawing.Point(17, 42);
            this.disB1.Name = "disB1";
            this.disB1.Size = new System.Drawing.Size(115, 17);
            this.disB1.TabIndex = 17;
            this.disB1.Text = "B1 - Switch Report";
            this.disB1.UseVisualStyleBackColor = true;
            // 
            // disB0
            // 
            this.disB0.AutoSize = true;
            this.disB0.Location = new System.Drawing.Point(17, 21);
            this.disB0.Name = "disB0";
            this.disB0.Size = new System.Drawing.Size(123, 17);
            this.disB0.TabIndex = 16;
            this.disB0.Text = "B0 - Switch Request";
            this.disB0.UseVisualStyleBackColor = true;
            // 
            // PacketVerifier
            // 
            this.PacketVerifier.Controls.Add(this.ppvPatternErrorButton);
            this.PacketVerifier.Controls.Add(this.ppvButtonReScan);
            this.PacketVerifier.Controls.Add(this.ppvStopOnMisMatch);
            this.PacketVerifier.Controls.Add(this.ppvClearSummary);
            this.PacketVerifier.Controls.Add(this.ppvClearPatterns);
            this.PacketVerifier.Controls.Add(this.ppvStopButton);
            this.PacketVerifier.Controls.Add(this.ppvStartButton);
            this.PacketVerifier.Controls.Add(this.label41);
            this.PacketVerifier.Controls.Add(this.label42);
            this.PacketVerifier.Controls.Add(this.label44);
            this.PacketVerifier.Controls.Add(this.label45);
            this.PacketVerifier.Controls.Add(this.label46);
            this.PacketVerifier.Controls.Add(this.label47);
            this.PacketVerifier.Controls.Add(this.ppvPacketSummary);
            this.PacketVerifier.Controls.Add(this.ppvDuration20);
            this.PacketVerifier.Controls.Add(this.ppvOnOff20);
            this.PacketVerifier.Controls.Add(this.ppvAddress20);
            this.PacketVerifier.Controls.Add(this.labelPattern20);
            this.PacketVerifier.Controls.Add(this.ppvOpCode20);
            this.PacketVerifier.Controls.Add(this.ppvDuration19);
            this.PacketVerifier.Controls.Add(this.ppvOnOff19);
            this.PacketVerifier.Controls.Add(this.ppvAddress19);
            this.PacketVerifier.Controls.Add(this.labelPattern19);
            this.PacketVerifier.Controls.Add(this.ppvOpCode19);
            this.PacketVerifier.Controls.Add(this.ppvDuration18);
            this.PacketVerifier.Controls.Add(this.ppvOnOff18);
            this.PacketVerifier.Controls.Add(this.ppvAddress18);
            this.PacketVerifier.Controls.Add(this.labelPattern18);
            this.PacketVerifier.Controls.Add(this.ppvOpCode18);
            this.PacketVerifier.Controls.Add(this.ppvDuration17);
            this.PacketVerifier.Controls.Add(this.ppvOnOff17);
            this.PacketVerifier.Controls.Add(this.ppvAddress17);
            this.PacketVerifier.Controls.Add(this.labelPattern17);
            this.PacketVerifier.Controls.Add(this.ppvOpCode17);
            this.PacketVerifier.Controls.Add(this.ppvDuration16);
            this.PacketVerifier.Controls.Add(this.ppvOnOff16);
            this.PacketVerifier.Controls.Add(this.ppvAddress16);
            this.PacketVerifier.Controls.Add(this.labelPattern16);
            this.PacketVerifier.Controls.Add(this.ppvOpCode16);
            this.PacketVerifier.Controls.Add(this.ppvDuration15);
            this.PacketVerifier.Controls.Add(this.ppvOnOff15);
            this.PacketVerifier.Controls.Add(this.ppvAddress15);
            this.PacketVerifier.Controls.Add(this.labelPattern15);
            this.PacketVerifier.Controls.Add(this.ppvOpCode15);
            this.PacketVerifier.Controls.Add(this.ppvDuration14);
            this.PacketVerifier.Controls.Add(this.ppvOnOff14);
            this.PacketVerifier.Controls.Add(this.ppvAddress14);
            this.PacketVerifier.Controls.Add(this.labelPattern14);
            this.PacketVerifier.Controls.Add(this.ppvOpCode14);
            this.PacketVerifier.Controls.Add(this.ppvDuration13);
            this.PacketVerifier.Controls.Add(this.ppvOnOff13);
            this.PacketVerifier.Controls.Add(this.ppvAddress13);
            this.PacketVerifier.Controls.Add(this.labelPattern13);
            this.PacketVerifier.Controls.Add(this.ppvOpCode13);
            this.PacketVerifier.Controls.Add(this.ppvDuration12);
            this.PacketVerifier.Controls.Add(this.ppvOnOff12);
            this.PacketVerifier.Controls.Add(this.ppvAddress12);
            this.PacketVerifier.Controls.Add(this.labelPattern12);
            this.PacketVerifier.Controls.Add(this.ppvOpCode12);
            this.PacketVerifier.Controls.Add(this.ppvDuration11);
            this.PacketVerifier.Controls.Add(this.ppvOnOff11);
            this.PacketVerifier.Controls.Add(this.ppvAddress11);
            this.PacketVerifier.Controls.Add(this.labelPattern11);
            this.PacketVerifier.Controls.Add(this.ppvOpCode11);
            this.PacketVerifier.Controls.Add(this.ppvDuration10);
            this.PacketVerifier.Controls.Add(this.ppvOnOff10);
            this.PacketVerifier.Controls.Add(this.ppvAddress10);
            this.PacketVerifier.Controls.Add(this.labelPattern10);
            this.PacketVerifier.Controls.Add(this.ppvOpCode10);
            this.PacketVerifier.Controls.Add(this.ppvDuration9);
            this.PacketVerifier.Controls.Add(this.ppvOnOff9);
            this.PacketVerifier.Controls.Add(this.ppvAddress9);
            this.PacketVerifier.Controls.Add(this.labelPattern9);
            this.PacketVerifier.Controls.Add(this.ppvOpCode9);
            this.PacketVerifier.Controls.Add(this.ppvDuration8);
            this.PacketVerifier.Controls.Add(this.ppvOnOff8);
            this.PacketVerifier.Controls.Add(this.ppvAddress8);
            this.PacketVerifier.Controls.Add(this.labelPattern8);
            this.PacketVerifier.Controls.Add(this.ppvOpCode8);
            this.PacketVerifier.Controls.Add(this.ppvDuration7);
            this.PacketVerifier.Controls.Add(this.ppvOnOff7);
            this.PacketVerifier.Controls.Add(this.ppvAddress7);
            this.PacketVerifier.Controls.Add(this.labelPattern7);
            this.PacketVerifier.Controls.Add(this.ppvOpCode7);
            this.PacketVerifier.Controls.Add(this.ppvDuration6);
            this.PacketVerifier.Controls.Add(this.ppvOnOff6);
            this.PacketVerifier.Controls.Add(this.ppvAddress6);
            this.PacketVerifier.Controls.Add(this.labelPattern6);
            this.PacketVerifier.Controls.Add(this.ppvOpCode6);
            this.PacketVerifier.Controls.Add(this.ppvDuration5);
            this.PacketVerifier.Controls.Add(this.ppvOnOff5);
            this.PacketVerifier.Controls.Add(this.ppvAddress5);
            this.PacketVerifier.Controls.Add(this.labelPattern5);
            this.PacketVerifier.Controls.Add(this.ppvOpCode5);
            this.PacketVerifier.Controls.Add(this.ppvDuration4);
            this.PacketVerifier.Controls.Add(this.ppvOnOff4);
            this.PacketVerifier.Controls.Add(this.ppvAddress4);
            this.PacketVerifier.Controls.Add(this.labelPattern4);
            this.PacketVerifier.Controls.Add(this.ppvOpCode4);
            this.PacketVerifier.Controls.Add(this.ppvDuration3);
            this.PacketVerifier.Controls.Add(this.ppvOnOff3);
            this.PacketVerifier.Controls.Add(this.ppvAddress3);
            this.PacketVerifier.Controls.Add(this.labelPattern3);
            this.PacketVerifier.Controls.Add(this.ppvOpCode3);
            this.PacketVerifier.Controls.Add(this.ppvDuration2);
            this.PacketVerifier.Controls.Add(this.ppvOnOff2);
            this.PacketVerifier.Controls.Add(this.ppvAddress2);
            this.PacketVerifier.Controls.Add(this.labelPattern2);
            this.PacketVerifier.Controls.Add(this.ppvOpCode2);
            this.PacketVerifier.Controls.Add(this.label21);
            this.PacketVerifier.Controls.Add(this.ppvDuration1);
            this.PacketVerifier.Controls.Add(this.label20);
            this.PacketVerifier.Controls.Add(this.ppvOnOff1);
            this.PacketVerifier.Controls.Add(this.label19);
            this.PacketVerifier.Controls.Add(this.ppvAddress1);
            this.PacketVerifier.Controls.Add(this.label18);
            this.PacketVerifier.Controls.Add(this.labelPattern1);
            this.PacketVerifier.Controls.Add(this.ppvOpCode1);
            this.PacketVerifier.Location = new System.Drawing.Point(4, 22);
            this.PacketVerifier.Name = "PacketVerifier";
            this.PacketVerifier.Padding = new System.Windows.Forms.Padding(3);
            this.PacketVerifier.Size = new System.Drawing.Size(957, 571);
            this.PacketVerifier.TabIndex = 3;
            this.PacketVerifier.Text = "LocoNet Patttern Verifier";
            this.PacketVerifier.UseVisualStyleBackColor = true;
            // 
            // ppvPatternErrorButton
            // 
            this.ppvPatternErrorButton.BackColor = System.Drawing.Color.LightGreen;
            this.ppvPatternErrorButton.CausesValidation = false;
            this.ppvPatternErrorButton.Location = new System.Drawing.Point(492, 536);
            this.ppvPatternErrorButton.Name = "ppvPatternErrorButton";
            this.ppvPatternErrorButton.Size = new System.Drawing.Size(98, 23);
            this.ppvPatternErrorButton.TabIndex = 118;
            this.ppvPatternErrorButton.Text = "No Pattern Error";
            this.ppvPatternErrorButton.UseVisualStyleBackColor = false;
            this.ppvPatternErrorButton.Click += new System.EventHandler(this.ppvMisMatchButton_Click);
            // 
            // ppvButtonReScan
            // 
            this.ppvButtonReScan.Enabled = false;
            this.ppvButtonReScan.Location = new System.Drawing.Point(757, 11);
            this.ppvButtonReScan.Name = "ppvButtonReScan";
            this.ppvButtonReScan.Size = new System.Drawing.Size(80, 23);
            this.ppvButtonReScan.TabIndex = 117;
            this.ppvButtonReScan.Text = "Re-Scan File";
            this.ppvButtonReScan.UseVisualStyleBackColor = true;
            this.ppvButtonReScan.Visible = false;
            this.ppvButtonReScan.Click += new System.EventHandler(this.ppvButtonReScan_Click);
            // 
            // ppvStopOnMisMatch
            // 
            this.ppvStopOnMisMatch.AutoSize = true;
            this.ppvStopOnMisMatch.Checked = true;
            this.ppvStopOnMisMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ppvStopOnMisMatch.Location = new System.Drawing.Point(606, 534);
            this.ppvStopOnMisMatch.Name = "ppvStopOnMisMatch";
            this.ppvStopOnMisMatch.Size = new System.Drawing.Size(100, 30);
            this.ppvStopOnMisMatch.TabIndex = 116;
            this.ppvStopOnMisMatch.Text = "Stop on Pattern\r\n         Error";
            this.ppvStopOnMisMatch.UseVisualStyleBackColor = true;
            // 
            // ppvClearSummary
            // 
            this.ppvClearSummary.Location = new System.Drawing.Point(853, 11);
            this.ppvClearSummary.Name = "ppvClearSummary";
            this.ppvClearSummary.Size = new System.Drawing.Size(91, 23);
            this.ppvClearSummary.TabIndex = 115;
            this.ppvClearSummary.Text = "Clear Summary";
            this.ppvClearSummary.UseVisualStyleBackColor = true;
            this.ppvClearSummary.Click += new System.EventHandler(this.ppvClearSummary_Click);
            // 
            // ppvClearPatterns
            // 
            this.ppvClearPatterns.Location = new System.Drawing.Point(327, 536);
            this.ppvClearPatterns.Name = "ppvClearPatterns";
            this.ppvClearPatterns.Size = new System.Drawing.Size(144, 23);
            this.ppvClearPatterns.TabIndex = 114;
            this.ppvClearPatterns.Text = "Clear Verification Patterns";
            this.ppvClearPatterns.UseVisualStyleBackColor = true;
            this.ppvClearPatterns.Click += new System.EventHandler(this.ppvClearPatterns_Click);
            // 
            // ppvStopButton
            // 
            this.ppvStopButton.Enabled = false;
            this.ppvStopButton.Location = new System.Drawing.Point(852, 536);
            this.ppvStopButton.Name = "ppvStopButton";
            this.ppvStopButton.Size = new System.Drawing.Size(96, 23);
            this.ppvStopButton.TabIndex = 113;
            this.ppvStopButton.Text = "Stop Verification";
            this.ppvStopButton.UseVisualStyleBackColor = true;
            this.ppvStopButton.Click += new System.EventHandler(this.ppvStopButton_Click);
            // 
            // ppvStartButton
            // 
            this.ppvStartButton.Location = new System.Drawing.Point(736, 536);
            this.ppvStartButton.Name = "ppvStartButton";
            this.ppvStartButton.Size = new System.Drawing.Size(101, 23);
            this.ppvStartButton.TabIndex = 112;
            this.ppvStartButton.Text = "Start Verification";
            this.ppvStartButton.UseVisualStyleBackColor = true;
            this.ppvStartButton.Click += new System.EventHandler(this.ppvStartButton_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(485, 24);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 111;
            this.label41.Text = "Time";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(624, 25);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(101, 13);
            this.label42.TabIndex = 110;
            this.label42.Text = "Hex Representation";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(552, 25);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(68, 13);
            this.label44.TabIndex = 108;
            this.label44.Text = "Address/Slot";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(414, 25);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(30, 13);
            this.label45.TabIndex = 107;
            this.label45.Text = "Date";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(331, 25);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(51, 13);
            this.label46.TabIndex = 106;
            this.label46.Text = "Packet #";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(543, 7);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(193, 13);
            this.label47.TabIndex = 105;
            this.label47.Text = "Packet Pattern Verified Summary";
            // 
            // ppvPacketSummary
            // 
            this.ppvPacketSummary.Location = new System.Drawing.Point(325, 42);
            this.ppvPacketSummary.Name = "ppvPacketSummary";
            this.ppvPacketSummary.Size = new System.Drawing.Size(626, 484);
            this.ppvPacketSummary.TabIndex = 104;
            this.ppvPacketSummary.Text = "";
            // 
            // ppvDuration20
            // 
            this.ppvDuration20.Location = new System.Drawing.Point(240, 537);
            this.ppvDuration20.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration20.Name = "ppvDuration20";
            this.ppvDuration20.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration20.TabIndex = 103;
            this.ppvDuration20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration20.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff20
            // 
            this.ppvOnOff20.AutoSize = true;
            this.ppvOnOff20.Location = new System.Drawing.Point(206, 540);
            this.ppvOnOff20.Name = "ppvOnOff20";
            this.ppvOnOff20.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff20.TabIndex = 102;
            this.ppvOnOff20.UseVisualStyleBackColor = true;
            // 
            // ppvAddress20
            // 
            this.ppvAddress20.Location = new System.Drawing.Point(119, 537);
            this.ppvAddress20.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress20.Name = "ppvAddress20";
            this.ppvAddress20.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress20.TabIndex = 101;
            this.ppvAddress20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern20
            // 
            this.labelPattern20.AutoSize = true;
            this.labelPattern20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPattern20.Location = new System.Drawing.Point(0, 539);
            this.labelPattern20.Name = "labelPattern20";
            this.labelPattern20.Size = new System.Drawing.Size(56, 13);
            this.labelPattern20.TabIndex = 100;
            this.labelPattern20.Text = "Pattern 20";
            // 
            // ppvOpCode20
            // 
            this.ppvOpCode20.FormattingEnabled = true;
            this.ppvOpCode20.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode20.Location = new System.Drawing.Point(69, 536);
            this.ppvOpCode20.MaxLength = 2;
            this.ppvOpCode20.Name = "ppvOpCode20";
            this.ppvOpCode20.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode20.TabIndex = 99;
            // 
            // ppvDuration19
            // 
            this.ppvDuration19.Location = new System.Drawing.Point(240, 511);
            this.ppvDuration19.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration19.Name = "ppvDuration19";
            this.ppvDuration19.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration19.TabIndex = 98;
            this.ppvDuration19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration19.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff19
            // 
            this.ppvOnOff19.AutoSize = true;
            this.ppvOnOff19.Location = new System.Drawing.Point(206, 514);
            this.ppvOnOff19.Name = "ppvOnOff19";
            this.ppvOnOff19.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff19.TabIndex = 97;
            this.ppvOnOff19.UseVisualStyleBackColor = true;
            // 
            // ppvAddress19
            // 
            this.ppvAddress19.Location = new System.Drawing.Point(119, 511);
            this.ppvAddress19.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress19.Name = "ppvAddress19";
            this.ppvAddress19.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress19.TabIndex = 96;
            this.ppvAddress19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern19
            // 
            this.labelPattern19.AutoSize = true;
            this.labelPattern19.Location = new System.Drawing.Point(0, 513);
            this.labelPattern19.Name = "labelPattern19";
            this.labelPattern19.Size = new System.Drawing.Size(56, 13);
            this.labelPattern19.TabIndex = 95;
            this.labelPattern19.Text = "Pattern 19";
            // 
            // ppvOpCode19
            // 
            this.ppvOpCode19.FormattingEnabled = true;
            this.ppvOpCode19.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode19.Location = new System.Drawing.Point(69, 510);
            this.ppvOpCode19.MaxLength = 2;
            this.ppvOpCode19.Name = "ppvOpCode19";
            this.ppvOpCode19.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode19.TabIndex = 94;
            // 
            // ppvDuration18
            // 
            this.ppvDuration18.Location = new System.Drawing.Point(240, 485);
            this.ppvDuration18.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration18.Name = "ppvDuration18";
            this.ppvDuration18.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration18.TabIndex = 93;
            this.ppvDuration18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration18.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff18
            // 
            this.ppvOnOff18.AutoSize = true;
            this.ppvOnOff18.Location = new System.Drawing.Point(206, 488);
            this.ppvOnOff18.Name = "ppvOnOff18";
            this.ppvOnOff18.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff18.TabIndex = 92;
            this.ppvOnOff18.UseVisualStyleBackColor = true;
            // 
            // ppvAddress18
            // 
            this.ppvAddress18.Location = new System.Drawing.Point(119, 485);
            this.ppvAddress18.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress18.Name = "ppvAddress18";
            this.ppvAddress18.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress18.TabIndex = 91;
            this.ppvAddress18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern18
            // 
            this.labelPattern18.AutoSize = true;
            this.labelPattern18.Location = new System.Drawing.Point(0, 487);
            this.labelPattern18.Name = "labelPattern18";
            this.labelPattern18.Size = new System.Drawing.Size(56, 13);
            this.labelPattern18.TabIndex = 90;
            this.labelPattern18.Text = "Pattern 18";
            // 
            // ppvOpCode18
            // 
            this.ppvOpCode18.FormattingEnabled = true;
            this.ppvOpCode18.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode18.Location = new System.Drawing.Point(69, 484);
            this.ppvOpCode18.MaxLength = 2;
            this.ppvOpCode18.Name = "ppvOpCode18";
            this.ppvOpCode18.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode18.TabIndex = 89;
            // 
            // ppvDuration17
            // 
            this.ppvDuration17.Location = new System.Drawing.Point(240, 459);
            this.ppvDuration17.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration17.Name = "ppvDuration17";
            this.ppvDuration17.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration17.TabIndex = 88;
            this.ppvDuration17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration17.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff17
            // 
            this.ppvOnOff17.AutoSize = true;
            this.ppvOnOff17.Location = new System.Drawing.Point(206, 462);
            this.ppvOnOff17.Name = "ppvOnOff17";
            this.ppvOnOff17.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff17.TabIndex = 87;
            this.ppvOnOff17.UseVisualStyleBackColor = true;
            // 
            // ppvAddress17
            // 
            this.ppvAddress17.Location = new System.Drawing.Point(119, 459);
            this.ppvAddress17.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress17.Name = "ppvAddress17";
            this.ppvAddress17.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress17.TabIndex = 86;
            this.ppvAddress17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern17
            // 
            this.labelPattern17.AutoSize = true;
            this.labelPattern17.Location = new System.Drawing.Point(0, 461);
            this.labelPattern17.Name = "labelPattern17";
            this.labelPattern17.Size = new System.Drawing.Size(56, 13);
            this.labelPattern17.TabIndex = 85;
            this.labelPattern17.Text = "Pattern 17";
            // 
            // ppvOpCode17
            // 
            this.ppvOpCode17.FormattingEnabled = true;
            this.ppvOpCode17.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode17.Location = new System.Drawing.Point(69, 458);
            this.ppvOpCode17.MaxLength = 2;
            this.ppvOpCode17.Name = "ppvOpCode17";
            this.ppvOpCode17.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode17.TabIndex = 84;
            // 
            // ppvDuration16
            // 
            this.ppvDuration16.Location = new System.Drawing.Point(240, 433);
            this.ppvDuration16.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration16.Name = "ppvDuration16";
            this.ppvDuration16.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration16.TabIndex = 83;
            this.ppvDuration16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration16.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff16
            // 
            this.ppvOnOff16.AutoSize = true;
            this.ppvOnOff16.Location = new System.Drawing.Point(206, 436);
            this.ppvOnOff16.Name = "ppvOnOff16";
            this.ppvOnOff16.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff16.TabIndex = 82;
            this.ppvOnOff16.UseVisualStyleBackColor = true;
            // 
            // ppvAddress16
            // 
            this.ppvAddress16.Location = new System.Drawing.Point(119, 433);
            this.ppvAddress16.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress16.Name = "ppvAddress16";
            this.ppvAddress16.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress16.TabIndex = 81;
            this.ppvAddress16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern16
            // 
            this.labelPattern16.AutoSize = true;
            this.labelPattern16.Location = new System.Drawing.Point(0, 435);
            this.labelPattern16.Name = "labelPattern16";
            this.labelPattern16.Size = new System.Drawing.Size(56, 13);
            this.labelPattern16.TabIndex = 80;
            this.labelPattern16.Text = "Pattern 16";
            // 
            // ppvOpCode16
            // 
            this.ppvOpCode16.FormattingEnabled = true;
            this.ppvOpCode16.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode16.Location = new System.Drawing.Point(69, 432);
            this.ppvOpCode16.MaxLength = 2;
            this.ppvOpCode16.Name = "ppvOpCode16";
            this.ppvOpCode16.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode16.TabIndex = 79;
            // 
            // ppvDuration15
            // 
            this.ppvDuration15.Location = new System.Drawing.Point(240, 407);
            this.ppvDuration15.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration15.Name = "ppvDuration15";
            this.ppvDuration15.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration15.TabIndex = 78;
            this.ppvDuration15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration15.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff15
            // 
            this.ppvOnOff15.AutoSize = true;
            this.ppvOnOff15.Location = new System.Drawing.Point(206, 410);
            this.ppvOnOff15.Name = "ppvOnOff15";
            this.ppvOnOff15.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff15.TabIndex = 77;
            this.ppvOnOff15.UseVisualStyleBackColor = true;
            // 
            // ppvAddress15
            // 
            this.ppvAddress15.Location = new System.Drawing.Point(119, 407);
            this.ppvAddress15.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress15.Name = "ppvAddress15";
            this.ppvAddress15.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress15.TabIndex = 76;
            this.ppvAddress15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern15
            // 
            this.labelPattern15.AutoSize = true;
            this.labelPattern15.Location = new System.Drawing.Point(0, 409);
            this.labelPattern15.Name = "labelPattern15";
            this.labelPattern15.Size = new System.Drawing.Size(56, 13);
            this.labelPattern15.TabIndex = 75;
            this.labelPattern15.Text = "Pattern 15";
            // 
            // ppvOpCode15
            // 
            this.ppvOpCode15.FormattingEnabled = true;
            this.ppvOpCode15.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode15.Location = new System.Drawing.Point(69, 406);
            this.ppvOpCode15.MaxLength = 2;
            this.ppvOpCode15.Name = "ppvOpCode15";
            this.ppvOpCode15.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode15.TabIndex = 74;
            // 
            // ppvDuration14
            // 
            this.ppvDuration14.Location = new System.Drawing.Point(240, 381);
            this.ppvDuration14.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration14.Name = "ppvDuration14";
            this.ppvDuration14.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration14.TabIndex = 73;
            this.ppvDuration14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration14.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff14
            // 
            this.ppvOnOff14.AutoSize = true;
            this.ppvOnOff14.Location = new System.Drawing.Point(206, 384);
            this.ppvOnOff14.Name = "ppvOnOff14";
            this.ppvOnOff14.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff14.TabIndex = 72;
            this.ppvOnOff14.UseVisualStyleBackColor = true;
            // 
            // ppvAddress14
            // 
            this.ppvAddress14.Location = new System.Drawing.Point(119, 381);
            this.ppvAddress14.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress14.Name = "ppvAddress14";
            this.ppvAddress14.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress14.TabIndex = 71;
            this.ppvAddress14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern14
            // 
            this.labelPattern14.AutoSize = true;
            this.labelPattern14.Location = new System.Drawing.Point(0, 383);
            this.labelPattern14.Name = "labelPattern14";
            this.labelPattern14.Size = new System.Drawing.Size(56, 13);
            this.labelPattern14.TabIndex = 70;
            this.labelPattern14.Text = "Pattern 14";
            // 
            // ppvOpCode14
            // 
            this.ppvOpCode14.FormattingEnabled = true;
            this.ppvOpCode14.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode14.Location = new System.Drawing.Point(69, 380);
            this.ppvOpCode14.MaxLength = 2;
            this.ppvOpCode14.Name = "ppvOpCode14";
            this.ppvOpCode14.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode14.TabIndex = 69;
            // 
            // ppvDuration13
            // 
            this.ppvDuration13.Location = new System.Drawing.Point(240, 355);
            this.ppvDuration13.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration13.Name = "ppvDuration13";
            this.ppvDuration13.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration13.TabIndex = 68;
            this.ppvDuration13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration13.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff13
            // 
            this.ppvOnOff13.AutoSize = true;
            this.ppvOnOff13.Location = new System.Drawing.Point(206, 358);
            this.ppvOnOff13.Name = "ppvOnOff13";
            this.ppvOnOff13.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff13.TabIndex = 67;
            this.ppvOnOff13.UseVisualStyleBackColor = true;
            // 
            // ppvAddress13
            // 
            this.ppvAddress13.Location = new System.Drawing.Point(119, 355);
            this.ppvAddress13.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress13.Name = "ppvAddress13";
            this.ppvAddress13.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress13.TabIndex = 66;
            this.ppvAddress13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern13
            // 
            this.labelPattern13.AutoSize = true;
            this.labelPattern13.Location = new System.Drawing.Point(0, 357);
            this.labelPattern13.Name = "labelPattern13";
            this.labelPattern13.Size = new System.Drawing.Size(56, 13);
            this.labelPattern13.TabIndex = 65;
            this.labelPattern13.Text = "Pattern 13";
            // 
            // ppvOpCode13
            // 
            this.ppvOpCode13.FormattingEnabled = true;
            this.ppvOpCode13.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode13.Location = new System.Drawing.Point(69, 354);
            this.ppvOpCode13.MaxLength = 2;
            this.ppvOpCode13.Name = "ppvOpCode13";
            this.ppvOpCode13.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode13.TabIndex = 64;
            // 
            // ppvDuration12
            // 
            this.ppvDuration12.Location = new System.Drawing.Point(240, 329);
            this.ppvDuration12.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration12.Name = "ppvDuration12";
            this.ppvDuration12.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration12.TabIndex = 63;
            this.ppvDuration12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration12.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff12
            // 
            this.ppvOnOff12.AutoSize = true;
            this.ppvOnOff12.Location = new System.Drawing.Point(206, 332);
            this.ppvOnOff12.Name = "ppvOnOff12";
            this.ppvOnOff12.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff12.TabIndex = 62;
            this.ppvOnOff12.UseVisualStyleBackColor = true;
            // 
            // ppvAddress12
            // 
            this.ppvAddress12.Location = new System.Drawing.Point(119, 329);
            this.ppvAddress12.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress12.Name = "ppvAddress12";
            this.ppvAddress12.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress12.TabIndex = 61;
            this.ppvAddress12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern12
            // 
            this.labelPattern12.AutoSize = true;
            this.labelPattern12.Location = new System.Drawing.Point(0, 331);
            this.labelPattern12.Name = "labelPattern12";
            this.labelPattern12.Size = new System.Drawing.Size(56, 13);
            this.labelPattern12.TabIndex = 60;
            this.labelPattern12.Text = "Pattern 12";
            // 
            // ppvOpCode12
            // 
            this.ppvOpCode12.FormattingEnabled = true;
            this.ppvOpCode12.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode12.Location = new System.Drawing.Point(69, 328);
            this.ppvOpCode12.MaxLength = 2;
            this.ppvOpCode12.Name = "ppvOpCode12";
            this.ppvOpCode12.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode12.TabIndex = 59;
            // 
            // ppvDuration11
            // 
            this.ppvDuration11.Location = new System.Drawing.Point(240, 303);
            this.ppvDuration11.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration11.Name = "ppvDuration11";
            this.ppvDuration11.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration11.TabIndex = 58;
            this.ppvDuration11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration11.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff11
            // 
            this.ppvOnOff11.AutoSize = true;
            this.ppvOnOff11.Location = new System.Drawing.Point(206, 306);
            this.ppvOnOff11.Name = "ppvOnOff11";
            this.ppvOnOff11.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff11.TabIndex = 57;
            this.ppvOnOff11.UseVisualStyleBackColor = true;
            // 
            // ppvAddress11
            // 
            this.ppvAddress11.Location = new System.Drawing.Point(119, 303);
            this.ppvAddress11.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress11.Name = "ppvAddress11";
            this.ppvAddress11.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress11.TabIndex = 56;
            this.ppvAddress11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern11
            // 
            this.labelPattern11.AutoSize = true;
            this.labelPattern11.Location = new System.Drawing.Point(0, 305);
            this.labelPattern11.Name = "labelPattern11";
            this.labelPattern11.Size = new System.Drawing.Size(56, 13);
            this.labelPattern11.TabIndex = 55;
            this.labelPattern11.Text = "Packet 11";
            // 
            // ppvOpCode11
            // 
            this.ppvOpCode11.FormattingEnabled = true;
            this.ppvOpCode11.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode11.Location = new System.Drawing.Point(69, 302);
            this.ppvOpCode11.MaxLength = 2;
            this.ppvOpCode11.Name = "ppvOpCode11";
            this.ppvOpCode11.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode11.TabIndex = 54;
            // 
            // ppvDuration10
            // 
            this.ppvDuration10.Location = new System.Drawing.Point(240, 277);
            this.ppvDuration10.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration10.Name = "ppvDuration10";
            this.ppvDuration10.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration10.TabIndex = 53;
            this.ppvDuration10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration10.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff10
            // 
            this.ppvOnOff10.AutoSize = true;
            this.ppvOnOff10.Location = new System.Drawing.Point(206, 280);
            this.ppvOnOff10.Name = "ppvOnOff10";
            this.ppvOnOff10.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff10.TabIndex = 52;
            this.ppvOnOff10.UseVisualStyleBackColor = true;
            // 
            // ppvAddress10
            // 
            this.ppvAddress10.Location = new System.Drawing.Point(119, 277);
            this.ppvAddress10.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress10.Name = "ppvAddress10";
            this.ppvAddress10.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress10.TabIndex = 51;
            this.ppvAddress10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern10
            // 
            this.labelPattern10.AutoSize = true;
            this.labelPattern10.Location = new System.Drawing.Point(0, 279);
            this.labelPattern10.Name = "labelPattern10";
            this.labelPattern10.Size = new System.Drawing.Size(56, 13);
            this.labelPattern10.TabIndex = 50;
            this.labelPattern10.Text = "Pattern 10";
            // 
            // ppvOpCode10
            // 
            this.ppvOpCode10.FormattingEnabled = true;
            this.ppvOpCode10.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode10.Location = new System.Drawing.Point(69, 276);
            this.ppvOpCode10.MaxLength = 2;
            this.ppvOpCode10.Name = "ppvOpCode10";
            this.ppvOpCode10.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode10.TabIndex = 49;
            // 
            // ppvDuration9
            // 
            this.ppvDuration9.Location = new System.Drawing.Point(240, 251);
            this.ppvDuration9.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration9.Name = "ppvDuration9";
            this.ppvDuration9.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration9.TabIndex = 48;
            this.ppvDuration9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration9.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff9
            // 
            this.ppvOnOff9.AutoSize = true;
            this.ppvOnOff9.Location = new System.Drawing.Point(206, 254);
            this.ppvOnOff9.Name = "ppvOnOff9";
            this.ppvOnOff9.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff9.TabIndex = 47;
            this.ppvOnOff9.UseVisualStyleBackColor = true;
            // 
            // ppvAddress9
            // 
            this.ppvAddress9.Location = new System.Drawing.Point(119, 251);
            this.ppvAddress9.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress9.Name = "ppvAddress9";
            this.ppvAddress9.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress9.TabIndex = 46;
            this.ppvAddress9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern9
            // 
            this.labelPattern9.AutoSize = true;
            this.labelPattern9.Location = new System.Drawing.Point(0, 253);
            this.labelPattern9.Name = "labelPattern9";
            this.labelPattern9.Size = new System.Drawing.Size(50, 13);
            this.labelPattern9.TabIndex = 45;
            this.labelPattern9.Text = "Pattern 9";
            // 
            // ppvOpCode9
            // 
            this.ppvOpCode9.FormattingEnabled = true;
            this.ppvOpCode9.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode9.Location = new System.Drawing.Point(69, 250);
            this.ppvOpCode9.MaxLength = 2;
            this.ppvOpCode9.Name = "ppvOpCode9";
            this.ppvOpCode9.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode9.TabIndex = 44;
            // 
            // ppvDuration8
            // 
            this.ppvDuration8.Location = new System.Drawing.Point(240, 225);
            this.ppvDuration8.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration8.Name = "ppvDuration8";
            this.ppvDuration8.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration8.TabIndex = 43;
            this.ppvDuration8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration8.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff8
            // 
            this.ppvOnOff8.AutoSize = true;
            this.ppvOnOff8.Location = new System.Drawing.Point(206, 228);
            this.ppvOnOff8.Name = "ppvOnOff8";
            this.ppvOnOff8.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff8.TabIndex = 42;
            this.ppvOnOff8.UseVisualStyleBackColor = true;
            // 
            // ppvAddress8
            // 
            this.ppvAddress8.Location = new System.Drawing.Point(119, 225);
            this.ppvAddress8.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress8.Name = "ppvAddress8";
            this.ppvAddress8.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress8.TabIndex = 41;
            this.ppvAddress8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern8
            // 
            this.labelPattern8.AutoSize = true;
            this.labelPattern8.Location = new System.Drawing.Point(0, 227);
            this.labelPattern8.Name = "labelPattern8";
            this.labelPattern8.Size = new System.Drawing.Size(50, 13);
            this.labelPattern8.TabIndex = 40;
            this.labelPattern8.Text = "Pattern 8";
            // 
            // ppvOpCode8
            // 
            this.ppvOpCode8.FormattingEnabled = true;
            this.ppvOpCode8.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode8.Location = new System.Drawing.Point(69, 224);
            this.ppvOpCode8.MaxLength = 2;
            this.ppvOpCode8.Name = "ppvOpCode8";
            this.ppvOpCode8.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode8.TabIndex = 39;
            // 
            // ppvDuration7
            // 
            this.ppvDuration7.Location = new System.Drawing.Point(240, 199);
            this.ppvDuration7.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration7.Name = "ppvDuration7";
            this.ppvDuration7.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration7.TabIndex = 38;
            this.ppvDuration7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration7.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff7
            // 
            this.ppvOnOff7.AutoSize = true;
            this.ppvOnOff7.Location = new System.Drawing.Point(206, 202);
            this.ppvOnOff7.Name = "ppvOnOff7";
            this.ppvOnOff7.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff7.TabIndex = 37;
            this.ppvOnOff7.UseVisualStyleBackColor = true;
            // 
            // ppvAddress7
            // 
            this.ppvAddress7.Location = new System.Drawing.Point(119, 199);
            this.ppvAddress7.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress7.Name = "ppvAddress7";
            this.ppvAddress7.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress7.TabIndex = 36;
            this.ppvAddress7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern7
            // 
            this.labelPattern7.AutoSize = true;
            this.labelPattern7.Location = new System.Drawing.Point(0, 201);
            this.labelPattern7.Name = "labelPattern7";
            this.labelPattern7.Size = new System.Drawing.Size(50, 13);
            this.labelPattern7.TabIndex = 35;
            this.labelPattern7.Text = "Pattern 7";
            // 
            // ppvOpCode7
            // 
            this.ppvOpCode7.FormattingEnabled = true;
            this.ppvOpCode7.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode7.Location = new System.Drawing.Point(69, 198);
            this.ppvOpCode7.MaxLength = 2;
            this.ppvOpCode7.Name = "ppvOpCode7";
            this.ppvOpCode7.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode7.TabIndex = 34;
            // 
            // ppvDuration6
            // 
            this.ppvDuration6.Location = new System.Drawing.Point(240, 173);
            this.ppvDuration6.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration6.Name = "ppvDuration6";
            this.ppvDuration6.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration6.TabIndex = 33;
            this.ppvDuration6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration6.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff6
            // 
            this.ppvOnOff6.AutoSize = true;
            this.ppvOnOff6.Location = new System.Drawing.Point(206, 176);
            this.ppvOnOff6.Name = "ppvOnOff6";
            this.ppvOnOff6.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff6.TabIndex = 32;
            this.ppvOnOff6.UseVisualStyleBackColor = true;
            // 
            // ppvAddress6
            // 
            this.ppvAddress6.Location = new System.Drawing.Point(119, 173);
            this.ppvAddress6.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress6.Name = "ppvAddress6";
            this.ppvAddress6.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress6.TabIndex = 31;
            this.ppvAddress6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern6
            // 
            this.labelPattern6.AutoSize = true;
            this.labelPattern6.Location = new System.Drawing.Point(0, 175);
            this.labelPattern6.Name = "labelPattern6";
            this.labelPattern6.Size = new System.Drawing.Size(50, 13);
            this.labelPattern6.TabIndex = 30;
            this.labelPattern6.Text = "Pattern 6";
            // 
            // ppvOpCode6
            // 
            this.ppvOpCode6.FormattingEnabled = true;
            this.ppvOpCode6.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode6.Location = new System.Drawing.Point(69, 172);
            this.ppvOpCode6.MaxLength = 2;
            this.ppvOpCode6.Name = "ppvOpCode6";
            this.ppvOpCode6.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode6.TabIndex = 29;
            // 
            // ppvDuration5
            // 
            this.ppvDuration5.Location = new System.Drawing.Point(240, 147);
            this.ppvDuration5.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration5.Name = "ppvDuration5";
            this.ppvDuration5.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration5.TabIndex = 28;
            this.ppvDuration5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration5.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff5
            // 
            this.ppvOnOff5.AutoSize = true;
            this.ppvOnOff5.Location = new System.Drawing.Point(206, 150);
            this.ppvOnOff5.Name = "ppvOnOff5";
            this.ppvOnOff5.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff5.TabIndex = 27;
            this.ppvOnOff5.UseVisualStyleBackColor = true;
            // 
            // ppvAddress5
            // 
            this.ppvAddress5.Location = new System.Drawing.Point(119, 147);
            this.ppvAddress5.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress5.Name = "ppvAddress5";
            this.ppvAddress5.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress5.TabIndex = 26;
            this.ppvAddress5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern5
            // 
            this.labelPattern5.AutoSize = true;
            this.labelPattern5.Location = new System.Drawing.Point(0, 149);
            this.labelPattern5.Name = "labelPattern5";
            this.labelPattern5.Size = new System.Drawing.Size(50, 13);
            this.labelPattern5.TabIndex = 25;
            this.labelPattern5.Text = "Pattern 5";
            // 
            // ppvOpCode5
            // 
            this.ppvOpCode5.FormattingEnabled = true;
            this.ppvOpCode5.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode5.Location = new System.Drawing.Point(69, 146);
            this.ppvOpCode5.MaxLength = 2;
            this.ppvOpCode5.Name = "ppvOpCode5";
            this.ppvOpCode5.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode5.TabIndex = 24;
            // 
            // ppvDuration4
            // 
            this.ppvDuration4.Location = new System.Drawing.Point(240, 121);
            this.ppvDuration4.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration4.Name = "ppvDuration4";
            this.ppvDuration4.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration4.TabIndex = 23;
            this.ppvDuration4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration4.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff4
            // 
            this.ppvOnOff4.AutoSize = true;
            this.ppvOnOff4.Location = new System.Drawing.Point(206, 124);
            this.ppvOnOff4.Name = "ppvOnOff4";
            this.ppvOnOff4.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff4.TabIndex = 22;
            this.ppvOnOff4.UseVisualStyleBackColor = true;
            // 
            // ppvAddress4
            // 
            this.ppvAddress4.Location = new System.Drawing.Point(119, 121);
            this.ppvAddress4.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress4.Name = "ppvAddress4";
            this.ppvAddress4.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress4.TabIndex = 21;
            this.ppvAddress4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern4
            // 
            this.labelPattern4.AutoSize = true;
            this.labelPattern4.Location = new System.Drawing.Point(0, 123);
            this.labelPattern4.Name = "labelPattern4";
            this.labelPattern4.Size = new System.Drawing.Size(50, 13);
            this.labelPattern4.TabIndex = 20;
            this.labelPattern4.Text = "Pattern 4";
            // 
            // ppvOpCode4
            // 
            this.ppvOpCode4.FormattingEnabled = true;
            this.ppvOpCode4.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode4.Location = new System.Drawing.Point(69, 120);
            this.ppvOpCode4.MaxLength = 2;
            this.ppvOpCode4.Name = "ppvOpCode4";
            this.ppvOpCode4.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode4.TabIndex = 19;
            // 
            // ppvDuration3
            // 
            this.ppvDuration3.Location = new System.Drawing.Point(240, 95);
            this.ppvDuration3.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration3.Name = "ppvDuration3";
            this.ppvDuration3.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration3.TabIndex = 18;
            this.ppvDuration3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration3.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff3
            // 
            this.ppvOnOff3.AutoSize = true;
            this.ppvOnOff3.Location = new System.Drawing.Point(206, 98);
            this.ppvOnOff3.Name = "ppvOnOff3";
            this.ppvOnOff3.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff3.TabIndex = 17;
            this.ppvOnOff3.UseVisualStyleBackColor = true;
            // 
            // ppvAddress3
            // 
            this.ppvAddress3.Location = new System.Drawing.Point(119, 95);
            this.ppvAddress3.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress3.Name = "ppvAddress3";
            this.ppvAddress3.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress3.TabIndex = 16;
            this.ppvAddress3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern3
            // 
            this.labelPattern3.AutoSize = true;
            this.labelPattern3.Location = new System.Drawing.Point(0, 97);
            this.labelPattern3.Name = "labelPattern3";
            this.labelPattern3.Size = new System.Drawing.Size(50, 13);
            this.labelPattern3.TabIndex = 15;
            this.labelPattern3.Text = "Pattern 3";
            // 
            // ppvOpCode3
            // 
            this.ppvOpCode3.FormattingEnabled = true;
            this.ppvOpCode3.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode3.Location = new System.Drawing.Point(69, 94);
            this.ppvOpCode3.MaxLength = 2;
            this.ppvOpCode3.Name = "ppvOpCode3";
            this.ppvOpCode3.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode3.TabIndex = 14;
            // 
            // ppvDuration2
            // 
            this.ppvDuration2.Location = new System.Drawing.Point(240, 69);
            this.ppvDuration2.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration2.Name = "ppvDuration2";
            this.ppvDuration2.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration2.TabIndex = 13;
            this.ppvDuration2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ppvDuration2.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // ppvOnOff2
            // 
            this.ppvOnOff2.AutoSize = true;
            this.ppvOnOff2.Location = new System.Drawing.Point(206, 72);
            this.ppvOnOff2.Name = "ppvOnOff2";
            this.ppvOnOff2.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff2.TabIndex = 12;
            this.ppvOnOff2.UseVisualStyleBackColor = true;
            // 
            // ppvAddress2
            // 
            this.ppvAddress2.Location = new System.Drawing.Point(119, 69);
            this.ppvAddress2.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress2.Name = "ppvAddress2";
            this.ppvAddress2.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress2.TabIndex = 11;
            this.ppvAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPattern2
            // 
            this.labelPattern2.AutoSize = true;
            this.labelPattern2.Location = new System.Drawing.Point(0, 71);
            this.labelPattern2.Name = "labelPattern2";
            this.labelPattern2.Size = new System.Drawing.Size(52, 13);
            this.labelPattern2.TabIndex = 10;
            this.labelPattern2.Text = "Patterm 2";
            // 
            // ppvOpCode2
            // 
            this.ppvOpCode2.FormattingEnabled = true;
            this.ppvOpCode2.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode2.Location = new System.Drawing.Point(69, 68);
            this.ppvOpCode2.MaxLength = 2;
            this.ppvOpCode2.Name = "ppvOpCode2";
            this.ppvOpCode2.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode2.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(231, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 26);
            this.label21.TabIndex = 8;
            this.label21.Text = "Maximum Duration\r\n      (seconds)";
            // 
            // ppvDuration1
            // 
            this.ppvDuration1.Location = new System.Drawing.Point(240, 43);
            this.ppvDuration1.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ppvDuration1.Name = "ppvDuration1";
            this.ppvDuration1.Size = new System.Drawing.Size(79, 20);
            this.ppvDuration1.TabIndex = 7;
            this.ppvDuration1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(195, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "On/Off";
            // 
            // ppvOnOff1
            // 
            this.ppvOnOff1.AutoSize = true;
            this.ppvOnOff1.Location = new System.Drawing.Point(206, 46);
            this.ppvOnOff1.Name = "ppvOnOff1";
            this.ppvOnOff1.Size = new System.Drawing.Size(15, 14);
            this.ppvOnOff1.TabIndex = 5;
            this.ppvOnOff1.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Address";
            // 
            // ppvAddress1
            // 
            this.ppvAddress1.Location = new System.Drawing.Point(119, 43);
            this.ppvAddress1.Maximum = new decimal(new int[] {
            16383,
            0,
            0,
            0});
            this.ppvAddress1.Name = "ppvAddress1";
            this.ppvAddress1.Size = new System.Drawing.Size(68, 20);
            this.ppvAddress1.TabIndex = 3;
            this.ppvAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(66, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "OpCode";
            // 
            // labelPattern1
            // 
            this.labelPattern1.AutoSize = true;
            this.labelPattern1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPattern1.Location = new System.Drawing.Point(0, 46);
            this.labelPattern1.Name = "labelPattern1";
            this.labelPattern1.Size = new System.Drawing.Size(50, 13);
            this.labelPattern1.TabIndex = 1;
            this.labelPattern1.Text = "Pattern 1";
            // 
            // ppvOpCode1
            // 
            this.ppvOpCode1.FormattingEnabled = true;
            this.ppvOpCode1.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2"});
            this.ppvOpCode1.Location = new System.Drawing.Point(69, 42);
            this.ppvOpCode1.MaxLength = 2;
            this.ppvOpCode1.Name = "ppvOpCode1";
            this.ppvOpCode1.Size = new System.Drawing.Size(40, 21);
            this.ppvOpCode1.TabIndex = 0;
            // 
            // tabDCCdisplay
            // 
            this.tabDCCdisplay.Controls.Add(this.button1);
            this.tabDCCdisplay.Controls.Add(this.button2);
            this.tabDCCdisplay.Controls.Add(this.label23);
            this.tabDCCdisplay.Controls.Add(this.label24);
            this.tabDCCdisplay.Controls.Add(this.label25);
            this.tabDCCdisplay.Controls.Add(this.label26);
            this.tabDCCdisplay.Controls.Add(this.label27);
            this.tabDCCdisplay.Controls.Add(this.label28);
            this.tabDCCdisplay.Controls.Add(this.label29);
            this.tabDCCdisplay.Controls.Add(this.label30);
            this.tabDCCdisplay.Controls.Add(this.label31);
            this.tabDCCdisplay.Controls.Add(this.textBox1);
            this.tabDCCdisplay.Controls.Add(this.label32);
            this.tabDCCdisplay.Controls.Add(this.label33);
            this.tabDCCdisplay.Controls.Add(this.textBox2);
            this.tabDCCdisplay.Controls.Add(this.textBox3);
            this.tabDCCdisplay.Controls.Add(this.button3);
            this.tabDCCdisplay.Controls.Add(this.button4);
            this.tabDCCdisplay.Controls.Add(this.richTextBox1);
            this.tabDCCdisplay.Controls.Add(this.richTextBox2);
            this.tabDCCdisplay.Controls.Add(this.groupBox1);
            this.tabDCCdisplay.Location = new System.Drawing.Point(4, 22);
            this.tabDCCdisplay.Name = "tabDCCdisplay";
            this.tabDCCdisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDCCdisplay.Size = new System.Drawing.Size(957, 571);
            this.tabDCCdisplay.TabIndex = 4;
            this.tabDCCdisplay.Text = "DCC Display";
            this.tabDCCdisplay.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadCaptureFileToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.loadPacketPatternToolStripMenuItem,
            this.savePacketPatternToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openToolStripMenuItem.Text = "New Capture File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // loadCaptureFileToolStripMenuItem
            // 
            this.loadCaptureFileToolStripMenuItem.Name = "loadCaptureFileToolStripMenuItem";
            this.loadCaptureFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadCaptureFileToolStripMenuItem.Text = "Load Capture File";
            this.loadCaptureFileToolStripMenuItem.Click += new System.EventHandler(this.loadCaptureFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeToolStripMenuItem.Text = "Close Capture File";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // loadPacketPatternToolStripMenuItem
            // 
            this.loadPacketPatternToolStripMenuItem.Name = "loadPacketPatternToolStripMenuItem";
            this.loadPacketPatternToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadPacketPatternToolStripMenuItem.Text = "Load Packet Patterns";
            this.loadPacketPatternToolStripMenuItem.Click += new System.EventHandler(this.loadPacketPatternToolStripMenuItem_Click);
            // 
            // savePacketPatternToolStripMenuItem
            // 
            this.savePacketPatternToolStripMenuItem.Name = "savePacketPatternToolStripMenuItem";
            this.savePacketPatternToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.savePacketPatternToolStripMenuItem.Text = "Save Packet Patterns";
            this.savePacketPatternToolStripMenuItem.Click += new System.EventHandler(this.savePacketPatternToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "About LocoNetMon";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFile_ppv
            // 
            this.openFile_ppv.DefaultExt = "ppv";
            this.openFile_ppv.FileName = "PacketPatternVerfier";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(752, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "Re-Scan File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Clear Summary";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(412, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(611, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 13);
            this.label24.TabIndex = 60;
            this.label24.Text = "Hex Representation";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(553, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 59;
            this.label25.Text = "Status";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(479, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 13);
            this.label26.TabIndex = 58;
            this.label26.Text = "Address/Slot";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(341, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 57;
            this.label27.Text = "Date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(258, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 56;
            this.label28.Text = "Packet #";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(653, 321);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 13);
            this.label29.TabIndex = 55;
            this.label29.Text = "Packet Details";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(553, 3);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 13);
            this.label30.TabIndex = 54;
            this.label30.Text = "Packet Summary";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(272, 400);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(95, 13);
            this.label31.TabIndex = 53;
            this.label31.Text = "Packets Received";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 415);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 52;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(276, 480);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 13);
            this.label32.TabIndex = 51;
            this.label32.Text = "Checksum Errors";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(278, 441);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 13);
            this.label33.TabIndex = 50;
            this.label33.Text = "Bytes Received";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 49;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 495);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 48;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(265, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Pause Capture";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Start/Continue Capture";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(417, 339);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(532, 225);
            this.richTextBox1.TabIndex = 45;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox2.Location = new System.Drawing.Point(247, 37);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(702, 278);
            this.richTextBox2.TabIndex = 44;
            this.richTextBox2.Text = "";
            this.richTextBox2.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.checkBox15);
            this.groupBox1.Controls.Add(this.checkBox16);
            this.groupBox1.Controls.Add(this.checkBox17);
            this.groupBox1.Controls.Add(this.checkBox18);
            this.groupBox1.Controls.Add(this.checkBox19);
            this.groupBox1.Controls.Add(this.checkBox20);
            this.groupBox1.Controls.Add(this.checkBox21);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 548);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Filters";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(167, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 18);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "\"I\" bit";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.numericUpDown3);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.numericUpDown4);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.numericUpDown5);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.numericUpDown6);
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.numericUpDown7);
            this.groupBox4.Controls.Add(this.checkBox10);
            this.groupBox4.Controls.Add(this.numericUpDown8);
            this.groupBox4.Location = new System.Drawing.Point(17, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 273);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Packets from Addresses";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(45, 22);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 13);
            this.label34.TabIndex = 27;
            this.label34.Text = "Addresses";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(114, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 13);
            this.label35.TabIndex = 26;
            this.label35.Text = "Include";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Clear All";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(8, 249);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Display All Addresses";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(128, 227);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(45, 224);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(128, 201);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(45, 198);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(128, 175);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(45, 172);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(128, 149);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(45, 146);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown4.TabIndex = 13;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(128, 123);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(45, 120);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown5.TabIndex = 10;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(128, 97);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(45, 94);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown6.TabIndex = 7;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(128, 71);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 5;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(45, 68);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown7.TabIndex = 4;
            this.numericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(128, 45);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(45, 42);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown8.TabIndex = 1;
            this.numericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 21);
            this.button6.TabIndex = 27;
            this.button6.Text = "Clear Filters";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(17, 238);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(79, 17);
            this.checkBox11.TabIndex = 26;
            this.checkBox11.Text = "All Packets";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(17, 218);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(137, 17);
            this.checkBox12.TabIndex = 25;
            this.checkBox12.Text = "EE,EF - Write Slot Data";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(17, 196);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(127, 17);
            this.checkBox13.TabIndex = 24;
            this.checkBox13.Text = "E7 - Slot Data Return";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(17, 174);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(94, 17);
            this.checkBox14.TabIndex = 23;
            this.checkBox14.Text = "E5 - Unknown";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(17, 152);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(156, 17);
            this.checkBox15.TabIndex = 22;
            this.checkBox15.Text = "BF - Request Loco Address";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(17, 130);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(136, 17);
            this.checkBox16.TabIndex = 21;
            this.checkBox16.Text = "BB - Request Slot Data";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(17, 108);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(104, 17);
            this.checkBox17.TabIndex = 20;
            this.checkBox17.Text = "B5 - Write Slot S";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(17, 86);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(94, 17);
            this.checkBox18.TabIndex = 19;
            this.checkBox18.Text = "B4 - Long Ack";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(17, 64);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(148, 17);
            this.checkBox19.TabIndex = 18;
            this.checkBox19.Text = "B2 - General Sensor Input";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(17, 42);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(115, 17);
            this.checkBox20.TabIndex = 17;
            this.checkBox20.Text = "B1 - Switch Report";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(17, 21);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(123, 17);
            this.checkBox21.TabIndex = 16;
            this.checkBox21.Text = "B0 - Switch Request";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // serialPortDCC
            // 
            this.serialPortDCC.PortName = "COM2";
            // 
            // LocoNetMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 631);
            this.Controls.Add(this.disDCC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LocoNetMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LocoNetMon";
            this.Load += new System.EventHandler(this.LocoNetMon_Load);
            this.disDCC.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.tabCaptureFilters.ResumeLayout(false);
            this.capExcludeGroup.ResumeLayout(false);
            this.capExcludeGroup.PerformLayout();
            this.capIncludeGroup.ResumeLayout(false);
            this.capIncludeGroup.PerformLayout();
            this.tabDisplayFilters.ResumeLayout(false);
            this.tabDisplayFilters.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disAdd1)).EndInit();
            this.PacketVerifier.ResumeLayout(false);
            this.PacketVerifier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvDuration1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ppvAddress1)).EndInit();
            this.tabDCCdisplay.ResumeLayout(false);
            this.tabDCCdisplay.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl disDCC;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabCaptureFilters;
        private System.Windows.Forms.ComboBox BaudRateLocoNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMportLocoNet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox capIncludeGroup;
        private System.Windows.Forms.CheckBox capB1;
        private System.Windows.Forms.CheckBox capB0;
        private System.Windows.Forms.CheckBox capB4;
        private System.Windows.Forms.CheckBox capB2;
        private System.Windows.Forms.CheckBox capALL;
        private System.Windows.Forms.CheckBox capEEEF;
        private System.Windows.Forms.CheckBox capE7;
        private System.Windows.Forms.CheckBox capE5;
        private System.Windows.Forms.CheckBox capBF;
        private System.Windows.Forms.CheckBox capBB;
        private System.Windows.Forms.CheckBox capB5;
        private System.Windows.Forms.Button capClearFilters;
        private System.Windows.Forms.TabPage tabDisplayFilters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button disClearFilters;
        private System.Windows.Forms.CheckBox disALL;
        private System.Windows.Forms.CheckBox disEEEF;
        private System.Windows.Forms.CheckBox disE7;
        private System.Windows.Forms.CheckBox disE5;
        private System.Windows.Forms.CheckBox disBF;
        private System.Windows.Forms.CheckBox disBB;
        private System.Windows.Forms.CheckBox disB5;
        private System.Windows.Forms.CheckBox disB4;
        private System.Windows.Forms.CheckBox disB2;
        private System.Windows.Forms.CheckBox disB1;
        private System.Windows.Forms.CheckBox disB0;
        private System.Windows.Forms.RichTextBox rtf_disDetail;
        private System.Windows.Forms.RichTextBox rtf_disCapture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox disPacketsReceived;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox disBytesReceived;
        private System.Windows.Forms.TextBox disChecksumErrors;
        private System.Windows.Forms.Button disPause;
        private System.Windows.Forms.Button disStartContinue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox disIncludeChk1;
        private System.Windows.Forms.NumericUpDown disAdd1;
        private System.Windows.Forms.CheckBox disIncludeChk2;
        private System.Windows.Forms.NumericUpDown disAdd2;
        private System.Windows.Forms.CheckBox disAddAll;
        private System.Windows.Forms.CheckBox disIncludeChk8;
        private System.Windows.Forms.NumericUpDown disAdd8;
        private System.Windows.Forms.CheckBox disIncludeChk7;
        private System.Windows.Forms.NumericUpDown disAdd7;
        private System.Windows.Forms.CheckBox disIncludeChk6;
        private System.Windows.Forms.NumericUpDown disAdd6;
        private System.Windows.Forms.CheckBox disIncludeChk5;
        private System.Windows.Forms.NumericUpDown disAdd5;
        private System.Windows.Forms.CheckBox disIncludeChk4;
        private System.Windows.Forms.NumericUpDown disAdd4;
        private System.Windows.Forms.CheckBox disIncludeChk3;
        private System.Windows.Forms.NumericUpDown disAdd3;
        private System.Windows.Forms.Button disClearAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox IbitChecked;
        private System.Windows.Forms.TabPage PacketVerifier;
        private System.Windows.Forms.Label labelPattern1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown ppvAddress1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown ppvDuration1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox ppvOnOff1;
        private System.Windows.Forms.NumericUpDown ppvDuration2;
        private System.Windows.Forms.CheckBox ppvOnOff2;
        private System.Windows.Forms.NumericUpDown ppvAddress2;
        private System.Windows.Forms.Label labelPattern2;
        private System.Windows.Forms.ComboBox ppvOpCode2;
        private System.Windows.Forms.ComboBox ppvOpCode1;
        private System.Windows.Forms.NumericUpDown ppvDuration20;
        private System.Windows.Forms.CheckBox ppvOnOff20;
        private System.Windows.Forms.NumericUpDown ppvAddress20;
        private System.Windows.Forms.Label labelPattern20;
        private System.Windows.Forms.ComboBox ppvOpCode20;
        private System.Windows.Forms.NumericUpDown ppvDuration19;
        private System.Windows.Forms.CheckBox ppvOnOff19;
        private System.Windows.Forms.NumericUpDown ppvAddress19;
        private System.Windows.Forms.Label labelPattern19;
        private System.Windows.Forms.ComboBox ppvOpCode19;
        private System.Windows.Forms.NumericUpDown ppvDuration18;
        private System.Windows.Forms.CheckBox ppvOnOff18;
        private System.Windows.Forms.NumericUpDown ppvAddress18;
        private System.Windows.Forms.Label labelPattern18;
        private System.Windows.Forms.ComboBox ppvOpCode18;
        private System.Windows.Forms.NumericUpDown ppvDuration17;
        private System.Windows.Forms.CheckBox ppvOnOff17;
        private System.Windows.Forms.NumericUpDown ppvAddress17;
        private System.Windows.Forms.Label labelPattern17;
        private System.Windows.Forms.ComboBox ppvOpCode17;
        private System.Windows.Forms.NumericUpDown ppvDuration16;
        private System.Windows.Forms.CheckBox ppvOnOff16;
        private System.Windows.Forms.NumericUpDown ppvAddress16;
        private System.Windows.Forms.Label labelPattern16;
        private System.Windows.Forms.ComboBox ppvOpCode16;
        private System.Windows.Forms.NumericUpDown ppvDuration15;
        private System.Windows.Forms.CheckBox ppvOnOff15;
        private System.Windows.Forms.NumericUpDown ppvAddress15;
        private System.Windows.Forms.Label labelPattern15;
        private System.Windows.Forms.ComboBox ppvOpCode15;
        private System.Windows.Forms.NumericUpDown ppvDuration14;
        private System.Windows.Forms.CheckBox ppvOnOff14;
        private System.Windows.Forms.NumericUpDown ppvAddress14;
        private System.Windows.Forms.Label labelPattern14;
        private System.Windows.Forms.ComboBox ppvOpCode14;
        private System.Windows.Forms.NumericUpDown ppvDuration13;
        private System.Windows.Forms.CheckBox ppvOnOff13;
        private System.Windows.Forms.NumericUpDown ppvAddress13;
        private System.Windows.Forms.Label labelPattern13;
        private System.Windows.Forms.ComboBox ppvOpCode13;
        private System.Windows.Forms.NumericUpDown ppvDuration12;
        private System.Windows.Forms.CheckBox ppvOnOff12;
        private System.Windows.Forms.NumericUpDown ppvAddress12;
        private System.Windows.Forms.Label labelPattern12;
        private System.Windows.Forms.ComboBox ppvOpCode12;
        private System.Windows.Forms.NumericUpDown ppvDuration11;
        private System.Windows.Forms.CheckBox ppvOnOff11;
        private System.Windows.Forms.NumericUpDown ppvAddress11;
        private System.Windows.Forms.Label labelPattern11;
        private System.Windows.Forms.ComboBox ppvOpCode11;
        private System.Windows.Forms.NumericUpDown ppvDuration10;
        private System.Windows.Forms.CheckBox ppvOnOff10;
        private System.Windows.Forms.NumericUpDown ppvAddress10;
        private System.Windows.Forms.Label labelPattern10;
        private System.Windows.Forms.ComboBox ppvOpCode10;
        private System.Windows.Forms.NumericUpDown ppvDuration9;
        private System.Windows.Forms.CheckBox ppvOnOff9;
        private System.Windows.Forms.NumericUpDown ppvAddress9;
        private System.Windows.Forms.Label labelPattern9;
        private System.Windows.Forms.ComboBox ppvOpCode9;
        private System.Windows.Forms.NumericUpDown ppvDuration8;
        private System.Windows.Forms.CheckBox ppvOnOff8;
        private System.Windows.Forms.NumericUpDown ppvAddress8;
        private System.Windows.Forms.Label labelPattern8;
        private System.Windows.Forms.ComboBox ppvOpCode8;
        private System.Windows.Forms.NumericUpDown ppvDuration7;
        private System.Windows.Forms.CheckBox ppvOnOff7;
        private System.Windows.Forms.NumericUpDown ppvAddress7;
        private System.Windows.Forms.Label labelPattern7;
        private System.Windows.Forms.ComboBox ppvOpCode7;
        private System.Windows.Forms.NumericUpDown ppvDuration6;
        private System.Windows.Forms.CheckBox ppvOnOff6;
        private System.Windows.Forms.NumericUpDown ppvAddress6;
        private System.Windows.Forms.Label labelPattern6;
        private System.Windows.Forms.ComboBox ppvOpCode6;
        private System.Windows.Forms.NumericUpDown ppvDuration5;
        private System.Windows.Forms.CheckBox ppvOnOff5;
        private System.Windows.Forms.NumericUpDown ppvAddress5;
        private System.Windows.Forms.Label labelPattern5;
        private System.Windows.Forms.ComboBox ppvOpCode5;
        private System.Windows.Forms.NumericUpDown ppvDuration4;
        private System.Windows.Forms.CheckBox ppvOnOff4;
        private System.Windows.Forms.NumericUpDown ppvAddress4;
        private System.Windows.Forms.Label labelPattern4;
        private System.Windows.Forms.ComboBox ppvOpCode4;
        private System.Windows.Forms.NumericUpDown ppvDuration3;
        private System.Windows.Forms.CheckBox ppvOnOff3;
        private System.Windows.Forms.NumericUpDown ppvAddress3;
        private System.Windows.Forms.Label labelPattern3;
        private System.Windows.Forms.ComboBox ppvOpCode3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.RichTextBox ppvPacketSummary;
        private System.Windows.Forms.Button ClearSummary;
        private System.Windows.Forms.Button ppvStopButton;
        private System.Windows.Forms.Button ppvStartButton;
        private System.Windows.Forms.Button ppvClearPatterns;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCaptureFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openCapturedFileDialog1;
        private System.Windows.Forms.Button disButtonReScan;
        private System.Windows.Forms.CheckBox ppvStopOnMisMatch;
        private System.Windows.Forms.Button ppvClearSummary;
        private System.Windows.Forms.Button ppvButtonReScan;
        private System.Windows.Forms.GroupBox capExcludeGroup;
        private System.Windows.Forms.CheckBox capA0exclude;
        private System.Windows.Forms.Button capClearExcludeButton;
        private System.Windows.Forms.Button ppvPatternErrorButton;
        private System.Windows.Forms.TextBox disCaptureFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem savePacketPatternToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFile_ppv;
        private System.Windows.Forms.ToolStripMenuItem loadPacketPatternToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile_ppv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox COMportDCC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox BaudRateDCC;
        private System.IO.Ports.SerialPort serialPortLocoNet;
        private System.Windows.Forms.TabPage tabDCCdisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.IO.Ports.SerialPort serialPortDCC;
    }
}

