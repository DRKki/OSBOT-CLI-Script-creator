namespace OSBotCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBotUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOsbotVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRunBat = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.lblBlacklist = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbPresets = new System.Windows.Forms.ComboBox();
            this.tbPreset = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbScriptParams = new System.Windows.Forms.TextBox();
            this.tbNameScript = new System.Windows.Forms.TextBox();
            this.lblNameScript = new System.Windows.Forms.Label();
            this.tbProxyIp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLocalScript = new System.Windows.Forms.RadioButton();
            this.rbSdnScript = new System.Windows.Forms.RadioButton();
            this.tbOsbotJar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbWorld = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbProxyUsername = new System.Windows.Forms.TextBox();
            this.tbScriptIdName = new System.Windows.Forms.TextBox();
            this.tbProxyPassword = new System.Windows.Forms.TextBox();
            this.tbProxyPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBotPin = new System.Windows.Forms.TextBox();
            this.cbResource = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCpu = new System.Windows.Forms.CheckBox();
            this.tbBotPassword = new System.Windows.Forms.TextBox();
            this.cbReflection = new System.Windows.Forms.CheckBox();
            this.tbOsbotUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBotUsername = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbOsbotPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDebugPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMem = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbRandoms = new System.Windows.Forms.CheckBox();
            this.cbInterface = new System.Windows.Forms.CheckBox();
            this.cbRender = new System.Windows.Forms.CheckBox();
            this.lblRandomWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOverview.SuspendLayout();
            this.pnlCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OSBotCreator.Properties.Resources.B8hrJ5n;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chMemory,
            this.chBotUsername,
            this.chScript,
            this.chOsbotVersion});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(484, 500);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chMemory
            // 
            this.chMemory.Text = "Mem";
            this.chMemory.Width = 55;
            // 
            // chBotUsername
            // 
            this.chBotUsername.Text = "Account";
            this.chBotUsername.Width = 120;
            // 
            // chScript
            // 
            this.chScript.Text = "Script";
            this.chScript.Width = 80;
            // 
            // chOsbotVersion
            // 
            this.chOsbotVersion.Text = "jar";
            this.chOsbotVersion.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Script creator";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(167, 554);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(237, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 554);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlOverview
            // 
            this.pnlOverview.Controls.Add(this.button5);
            this.pnlOverview.Controls.Add(this.label13);
            this.pnlOverview.Controls.Add(this.label14);
            this.pnlOverview.Controls.Add(this.btnRunBat);
            this.pnlOverview.Controls.Add(this.listView1);
            this.pnlOverview.Controls.Add(this.btnCreate);
            this.pnlOverview.Controls.Add(this.btnEdit);
            this.pnlOverview.Controls.Add(this.btnDelete);
            this.pnlOverview.Location = new System.Drawing.Point(-1, 53);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(506, 580);
            this.pnlOverview.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(410, 554);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Update Jars...";
            this.toolTip1.SetToolTip(this.button5, "Update every script with a new OSBot jar\r\nIn a single action");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "V1.4.2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = "Scripts";
            // 
            // btnRunBat
            // 
            this.btnRunBat.Location = new System.Drawing.Point(89, 554);
            this.btnRunBat.Name = "btnRunBat";
            this.btnRunBat.Size = new System.Drawing.Size(75, 23);
            this.btnRunBat.TabIndex = 6;
            this.btnRunBat.Text = "Run";
            this.btnRunBat.UseVisualStyleBackColor = true;
            this.btnRunBat.Click += new System.EventHandler(this.btnRunBat_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(357, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by The Hero of Time";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlCreate
            // 
            this.pnlCreate.Controls.Add(this.lblRandomWarning);
            this.pnlCreate.Controls.Add(this.cbRender);
            this.pnlCreate.Controls.Add(this.cbInterface);
            this.pnlCreate.Controls.Add(this.cbRandoms);
            this.pnlCreate.Controls.Add(this.lblBlacklist);
            this.pnlCreate.Controls.Add(this.button4);
            this.pnlCreate.Controls.Add(this.label16);
            this.pnlCreate.Controls.Add(this.cbPresets);
            this.pnlCreate.Controls.Add(this.tbPreset);
            this.pnlCreate.Controls.Add(this.label15);
            this.pnlCreate.Controls.Add(this.button2);
            this.pnlCreate.Controls.Add(this.btnBack);
            this.pnlCreate.Controls.Add(this.tbScriptParams);
            this.pnlCreate.Controls.Add(this.tbNameScript);
            this.pnlCreate.Controls.Add(this.lblNameScript);
            this.pnlCreate.Controls.Add(this.tbProxyIp);
            this.pnlCreate.Controls.Add(this.groupBox1);
            this.pnlCreate.Controls.Add(this.tbOsbotJar);
            this.pnlCreate.Controls.Add(this.label12);
            this.pnlCreate.Controls.Add(this.button3);
            this.pnlCreate.Controls.Add(this.tbWorld);
            this.pnlCreate.Controls.Add(this.label7);
            this.pnlCreate.Controls.Add(this.label11);
            this.pnlCreate.Controls.Add(this.tbProxyUsername);
            this.pnlCreate.Controls.Add(this.tbScriptIdName);
            this.pnlCreate.Controls.Add(this.tbProxyPassword);
            this.pnlCreate.Controls.Add(this.tbProxyPort);
            this.pnlCreate.Controls.Add(this.label10);
            this.pnlCreate.Controls.Add(this.tbBotPin);
            this.pnlCreate.Controls.Add(this.cbResource);
            this.pnlCreate.Controls.Add(this.label8);
            this.pnlCreate.Controls.Add(this.cbCpu);
            this.pnlCreate.Controls.Add(this.tbBotPassword);
            this.pnlCreate.Controls.Add(this.cbReflection);
            this.pnlCreate.Controls.Add(this.tbOsbotUsername);
            this.pnlCreate.Controls.Add(this.label6);
            this.pnlCreate.Controls.Add(this.tbBotUsername);
            this.pnlCreate.Controls.Add(this.tbData);
            this.pnlCreate.Controls.Add(this.tbOsbotPassword);
            this.pnlCreate.Controls.Add(this.label5);
            this.pnlCreate.Controls.Add(this.label9);
            this.pnlCreate.Controls.Add(this.tbDebugPort);
            this.pnlCreate.Controls.Add(this.label4);
            this.pnlCreate.Controls.Add(this.label3);
            this.pnlCreate.Controls.Add(this.button1);
            this.pnlCreate.Controls.Add(this.tbMem);
            this.pnlCreate.Location = new System.Drawing.Point(540, 53);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(466, 580);
            this.pnlCreate.TabIndex = 7;
            // 
            // lblBlacklist
            // 
            this.lblBlacklist.AutoSize = true;
            this.lblBlacklist.Location = new System.Drawing.Point(233, 430);
            this.lblBlacklist.Name = "lblBlacklist";
            this.lblBlacklist.Size = new System.Drawing.Size(157, 13);
            this.lblBlacklist.TabIndex = 53;
            this.lblBlacklist.Text = "Blacklist:\\  /  :  *  ?  \\  <  >  |  [  ]";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(350, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 52;
            this.button4.Text = "Del Preset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Load Preset";
            // 
            // cbPresets
            // 
            this.cbPresets.FormattingEnabled = true;
            this.cbPresets.Location = new System.Drawing.Point(114, 24);
            this.cbPresets.Name = "cbPresets";
            this.cbPresets.Size = new System.Drawing.Size(230, 21);
            this.cbPresets.TabIndex = 50;
            this.cbPresets.SelectedIndexChanged += new System.EventHandler(this.cbPresets_SelectedIndexChanged);
            // 
            // tbPreset
            // 
            this.tbPreset.Location = new System.Drawing.Point(112, 460);
            this.tbPreset.Name = "tbPreset";
            this.tbPreset.Size = new System.Drawing.Size(112, 20);
            this.tbPreset.TabIndex = 22;
            this.tbPreset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPreset_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 463);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Preset name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 22);
            this.button2.TabIndex = 47;
            this.button2.Text = "Set these settings as preset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(122, 555);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 23);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbScriptParams
            // 
            this.tbScriptParams.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbScriptParams.Location = new System.Drawing.Point(354, 363);
            this.tbScriptParams.Name = "tbScriptParams";
            this.tbScriptParams.Size = new System.Drawing.Size(100, 20);
            this.tbScriptParams.TabIndex = 19;
            this.tbScriptParams.Text = "param1,param2";
            this.tbScriptParams.Enter += new System.EventHandler(this.tbScriptParams_Enter);
            this.tbScriptParams.Leave += new System.EventHandler(this.tbScriptParams_Leave);
            // 
            // tbNameScript
            // 
            this.tbNameScript.Location = new System.Drawing.Point(113, 428);
            this.tbNameScript.Name = "tbNameScript";
            this.tbNameScript.Size = new System.Drawing.Size(112, 20);
            this.tbNameScript.TabIndex = 21;
            this.tbNameScript.Enter += new System.EventHandler(this.tbNameScript_Enter);
            this.tbNameScript.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbNameScript_KeyUp);
            // 
            // lblNameScript
            // 
            this.lblNameScript.AutoSize = true;
            this.lblNameScript.Location = new System.Drawing.Point(17, 431);
            this.lblNameScript.Name = "lblNameScript";
            this.lblNameScript.Size = new System.Drawing.Size(85, 13);
            this.lblNameScript.TabIndex = 43;
            this.lblNameScript.Text = "Name this script:";
            // 
            // tbProxyIp
            // 
            this.tbProxyIp.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbProxyIp.Location = new System.Drawing.Point(113, 221);
            this.tbProxyIp.Name = "tbProxyIp";
            this.tbProxyIp.Size = new System.Drawing.Size(58, 20);
            this.tbProxyIp.TabIndex = 6;
            this.tbProxyIp.Text = "IP";
            this.toolTip1.SetToolTip(this.tbProxyIp, "Requires Osbot login ");
            this.tbProxyIp.Enter += new System.EventHandler(this.tbProxyIp_Enter);
            this.tbProxyIp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProxyIp_KeyPress);
            this.tbProxyIp.Leave += new System.EventHandler(this.tbProxyIp_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLocalScript);
            this.groupBox1.Controls.Add(this.rbSdnScript);
            this.groupBox1.Location = new System.Drawing.Point(113, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 28);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // rbLocalScript
            // 
            this.rbLocalScript.AutoSize = true;
            this.rbLocalScript.Location = new System.Drawing.Point(88, 10);
            this.rbLocalScript.Name = "rbLocalScript";
            this.rbLocalScript.Size = new System.Drawing.Size(79, 17);
            this.rbLocalScript.TabIndex = 17;
            this.rbLocalScript.Text = "Local script";
            this.rbLocalScript.UseVisualStyleBackColor = true;
            this.rbLocalScript.CheckedChanged += new System.EventHandler(this.rbLocalScript_CheckedChanged);
            // 
            // rbSdnScript
            // 
            this.rbSdnScript.AutoSize = true;
            this.rbSdnScript.Checked = true;
            this.rbSdnScript.Location = new System.Drawing.Point(6, 10);
            this.rbSdnScript.Name = "rbSdnScript";
            this.rbSdnScript.Size = new System.Drawing.Size(76, 17);
            this.rbSdnScript.TabIndex = 16;
            this.rbSdnScript.TabStop = true;
            this.rbSdnScript.Text = "SDN script";
            this.rbSdnScript.UseVisualStyleBackColor = true;
            this.rbSdnScript.CheckedChanged += new System.EventHandler(this.rbSdnScript_CheckedChanged);
            // 
            // tbOsbotJar
            // 
            this.tbOsbotJar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.tbOsbotJar.Location = new System.Drawing.Point(112, 84);
            this.tbOsbotJar.Name = "tbOsbotJar";
            this.tbOsbotJar.ReadOnly = true;
            this.tbOsbotJar.Size = new System.Drawing.Size(232, 18);
            this.tbOsbotJar.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Osbot jar:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button3.Location = new System.Drawing.Point(112, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Select OSBot jar...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbWorld
            // 
            this.tbWorld.Location = new System.Drawing.Point(113, 400);
            this.tbWorld.MaxLength = 3;
            this.tbWorld.Name = "tbWorld";
            this.tbWorld.Size = new System.Drawing.Size(58, 20);
            this.tbWorld.TabIndex = 20;
            this.toolTip1.SetToolTip(this.tbWorld, "Requires Osbot login AND bot login");
            this.tbWorld.Enter += new System.EventHandler(this.tbWorld_Enter);
            this.tbWorld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWorld_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Proxy:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "World:";
            // 
            // tbProxyUsername
            // 
            this.tbProxyUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbProxyUsername.Location = new System.Drawing.Point(241, 221);
            this.tbProxyUsername.Name = "tbProxyUsername";
            this.tbProxyUsername.Size = new System.Drawing.Size(58, 20);
            this.tbProxyUsername.TabIndex = 8;
            this.tbProxyUsername.Text = "Username";
            this.toolTip1.SetToolTip(this.tbProxyUsername, "Requires Osbot login ");
            this.tbProxyUsername.Enter += new System.EventHandler(this.tbProxyUsername_Enter);
            this.tbProxyUsername.Leave += new System.EventHandler(this.tbProxyUsername_Leave);
            // 
            // tbScriptIdName
            // 
            this.tbScriptIdName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbScriptIdName.Location = new System.Drawing.Point(290, 363);
            this.tbScriptIdName.Name = "tbScriptIdName";
            this.tbScriptIdName.Size = new System.Drawing.Size(58, 20);
            this.tbScriptIdName.TabIndex = 18;
            this.tbScriptIdName.Text = "ID";
            this.toolTip1.SetToolTip(this.tbScriptIdName, "Requireds Osbot login AND bot login");
            this.tbScriptIdName.Enter += new System.EventHandler(this.tbScriptIdName_Enter);
            this.tbScriptIdName.Leave += new System.EventHandler(this.tbScriptIdName_Leave);
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbProxyPassword.Location = new System.Drawing.Point(305, 221);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.Size = new System.Drawing.Size(58, 20);
            this.tbProxyPassword.TabIndex = 9;
            this.tbProxyPassword.Text = "Password";
            this.toolTip1.SetToolTip(this.tbProxyPassword, "Requires Osbot login ");
            this.tbProxyPassword.Enter += new System.EventHandler(this.tbProxyPassword_Enter);
            this.tbProxyPassword.Leave += new System.EventHandler(this.tbProxyPassword_Leave);
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbProxyPort.Location = new System.Drawing.Point(177, 221);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(58, 20);
            this.tbProxyPort.TabIndex = 7;
            this.tbProxyPort.Text = "Port";
            this.toolTip1.SetToolTip(this.tbProxyPort, "Requires Osbot login ");
            this.tbProxyPort.Enter += new System.EventHandler(this.tbProxyPort_Enter);
            this.tbProxyPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProxyPort_KeyPress);
            this.tbProxyPort.Leave += new System.EventHandler(this.tbProxyPort_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Script:";
            // 
            // tbBotPin
            // 
            this.tbBotPin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBotPin.Location = new System.Drawing.Point(241, 256);
            this.tbBotPin.MaxLength = 4;
            this.tbBotPin.Name = "tbBotPin";
            this.tbBotPin.Size = new System.Drawing.Size(43, 20);
            this.tbBotPin.TabIndex = 12;
            this.tbBotPin.Text = "Pin";
            this.toolTip1.SetToolTip(this.tbBotPin, "Requires Osbot login");
            this.tbBotPin.Enter += new System.EventHandler(this.tbBotPin_Enter);
            this.tbBotPin.Leave += new System.EventHandler(this.tbBotPin_Leave);
            // 
            // cbResource
            // 
            this.cbResource.AutoSize = true;
            this.cbResource.Location = new System.Drawing.Point(113, 335);
            this.cbResource.Name = "cbResource";
            this.cbResource.Size = new System.Drawing.Size(91, 17);
            this.cbResource.TabIndex = 15;
            this.cbResource.Text = "low resources";
            this.toolTip1.SetToolTip(this.cbResource, "Requires Osbot login AND bot login");
            this.cbResource.UseVisualStyleBackColor = true;
            this.cbResource.CheckedChanged += new System.EventHandler(this.cbResource_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Osbot login:";
            // 
            // cbCpu
            // 
            this.cbCpu.AutoSize = true;
            this.cbCpu.Location = new System.Drawing.Point(113, 312);
            this.cbCpu.Name = "cbCpu";
            this.cbCpu.Size = new System.Drawing.Size(63, 17);
            this.cbCpu.TabIndex = 14;
            this.cbCpu.Text = "low cpu";
            this.cbCpu.UseVisualStyleBackColor = true;
            // 
            // tbBotPassword
            // 
            this.tbBotPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBotPassword.Location = new System.Drawing.Point(177, 256);
            this.tbBotPassword.Name = "tbBotPassword";
            this.tbBotPassword.Size = new System.Drawing.Size(58, 20);
            this.tbBotPassword.TabIndex = 11;
            this.tbBotPassword.Text = "Password";
            this.toolTip1.SetToolTip(this.tbBotPassword, "Requires Osbot login");
            this.tbBotPassword.Enter += new System.EventHandler(this.tbBotPassword_Enter);
            this.tbBotPassword.Leave += new System.EventHandler(this.tbBotPassword_Leave);
            // 
            // cbReflection
            // 
            this.cbReflection.AutoSize = true;
            this.cbReflection.Location = new System.Drawing.Point(113, 289);
            this.cbReflection.Name = "cbReflection";
            this.cbReflection.Size = new System.Drawing.Size(74, 17);
            this.cbReflection.TabIndex = 13;
            this.cbReflection.Text = "Reflection";
            this.cbReflection.UseVisualStyleBackColor = true;
            // 
            // tbOsbotUsername
            // 
            this.tbOsbotUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOsbotUsername.Location = new System.Drawing.Point(113, 190);
            this.tbOsbotUsername.Name = "tbOsbotUsername";
            this.tbOsbotUsername.Size = new System.Drawing.Size(58, 20);
            this.tbOsbotUsername.TabIndex = 4;
            this.tbOsbotUsername.Text = "Username";
            this.tbOsbotUsername.Enter += new System.EventHandler(this.tbOsbotUsername_Enter);
            this.tbOsbotUsername.Leave += new System.EventHandler(this.tbOsbotUsername_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Permission:";
            // 
            // tbBotUsername
            // 
            this.tbBotUsername.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbBotUsername.Location = new System.Drawing.Point(113, 256);
            this.tbBotUsername.Name = "tbBotUsername";
            this.tbBotUsername.Size = new System.Drawing.Size(58, 20);
            this.tbBotUsername.TabIndex = 10;
            this.tbBotUsername.Text = "Username";
            this.toolTip1.SetToolTip(this.tbBotUsername, "Requires Osbot login");
            this.tbBotUsername.Enter += new System.EventHandler(this.tbBotUsername_Enter);
            this.tbBotUsername.Leave += new System.EventHandler(this.tbBotUsername_Leave);
            // 
            // tbData
            // 
            this.tbData.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbData.Location = new System.Drawing.Point(112, 164);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 20);
            this.tbData.TabIndex = 3;
            this.tbData.Text = "0 or 1";
            this.tbData.Enter += new System.EventHandler(this.tbData_Enter);
            this.tbData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbData_KeyPress);
            this.tbData.Leave += new System.EventHandler(this.tbData_Leave);
            // 
            // tbOsbotPassword
            // 
            this.tbOsbotPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbOsbotPassword.Location = new System.Drawing.Point(177, 190);
            this.tbOsbotPassword.Name = "tbOsbotPassword";
            this.tbOsbotPassword.Size = new System.Drawing.Size(58, 20);
            this.tbOsbotPassword.TabIndex = 5;
            this.tbOsbotPassword.Text = "Password";
            this.tbOsbotPassword.Enter += new System.EventHandler(this.tbOsbotPassword_Enter);
            this.tbOsbotPassword.Leave += new System.EventHandler(this.tbOsbotPassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Collect data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bot login:";
            // 
            // tbDebugPort
            // 
            this.tbDebugPort.Location = new System.Drawing.Point(112, 136);
            this.tbDebugPort.Name = "tbDebugPort";
            this.tbDebugPort.Size = new System.Drawing.Size(100, 20);
            this.tbDebugPort.TabIndex = 2;
            this.tbDebugPort.Text = "5005";
            this.tbDebugPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDebugPort_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Debug port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Memory(mb):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMem
            // 
            this.tbMem.Location = new System.Drawing.Point(112, 110);
            this.tbMem.Name = "tbMem";
            this.tbMem.Size = new System.Drawing.Size(100, 20);
            this.tbMem.TabIndex = 1;
            this.tbMem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMem_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // cbRandoms
            // 
            this.cbRandoms.AutoSize = true;
            this.cbRandoms.Location = new System.Drawing.Point(206, 290);
            this.cbRandoms.Name = "cbRandoms";
            this.cbRandoms.Size = new System.Drawing.Size(236, 17);
            this.cbRandoms.TabIndex = 54;
            this.cbRandoms.Text = "No OSBot Randoms(including OSBot\'s login)";
            this.cbRandoms.UseVisualStyleBackColor = true;
            this.cbRandoms.CheckedChanged += new System.EventHandler(this.cbRandoms_CheckedChanged);
            // 
            // cbInterface
            // 
            this.cbInterface.AutoSize = true;
            this.cbInterface.Location = new System.Drawing.Point(206, 313);
            this.cbInterface.Name = "cbInterface";
            this.cbInterface.Size = new System.Drawing.Size(85, 17);
            this.cbInterface.TabIndex = 55;
            this.cbInterface.Text = "No Interface";
            this.cbInterface.UseVisualStyleBackColor = true;
            this.cbInterface.CheckedChanged += new System.EventHandler(this.cbInterface_CheckedChanged);
            // 
            // cbRender
            // 
            this.cbRender.AutoSize = true;
            this.cbRender.Location = new System.Drawing.Point(206, 335);
            this.cbRender.Name = "cbRender";
            this.cbRender.Size = new System.Drawing.Size(73, 17);
            this.cbRender.TabIndex = 56;
            this.cbRender.Text = "No render";
            this.cbRender.UseVisualStyleBackColor = true;
            // 
            // lblRandomWarning
            // 
            this.lblRandomWarning.AutoSize = true;
            this.lblRandomWarning.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomWarning.ForeColor = System.Drawing.Color.Red;
            this.lblRandomWarning.Location = new System.Drawing.Point(3, 518);
            this.lblRandomWarning.Name = "lblRandomWarning";
            this.lblRandomWarning.Size = new System.Drawing.Size(241, 30);
            this.lblRandomWarning.TabIndex = 57;
            this.lblRandomWarning.Text = "Without an custom login handler\r\nthis bot will not login automatically";
            this.lblRandomWarning.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 744);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OSBot Script Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOverview.ResumeLayout(false);
            this.pnlOverview.PerformLayout();
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbResource;
        private System.Windows.Forms.CheckBox cbCpu;
        private System.Windows.Forms.CheckBox cbReflection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDebugPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOsbotPassword;
        private System.Windows.Forms.TextBox tbOsbotUsername;
        private System.Windows.Forms.TextBox tbProxyPassword;
        private System.Windows.Forms.TextBox tbProxyUsername;
        private System.Windows.Forms.TextBox tbProxyPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRunBat;
        private System.Windows.Forms.TextBox tbBotPin;
        private System.Windows.Forms.TextBox tbBotPassword;
        private System.Windows.Forms.TextBox tbBotUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbWorld;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbScriptIdName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbOsbotJar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLocalScript;
        private System.Windows.Forms.RadioButton rbSdnScript;
        private System.Windows.Forms.TextBox tbProxyIp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNameScript;
        private System.Windows.Forms.TextBox tbNameScript;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbScriptParams;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ColumnHeader chMemory;
        private System.Windows.Forms.ColumnHeader chBotUsername;
        private System.Windows.Forms.ColumnHeader chScript;
        private System.Windows.Forms.ColumnHeader chOsbotVersion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbPresets;
        private System.Windows.Forms.TextBox tbPreset;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblBlacklist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox cbRender;
        private System.Windows.Forms.CheckBox cbInterface;
        private System.Windows.Forms.CheckBox cbRandoms;
        private System.Windows.Forms.Label lblRandomWarning;
    }
}

