namespace TL_and_Alarm_Creator
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
            this.chkmatchAVInstance = new System.Windows.Forms.CheckBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.totobjsLABEL = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.firstdevLABEL = new System.Windows.Forms.Label();
            this.lastdevLABEL = new System.Windows.Forms.Label();
            this.rangeCHECK = new System.Windows.Forms.CheckBox();
            this.sampleInterval = new System.Windows.Forms.TextBox();
            this.txtSamples = new System.Windows.Forms.TextBox();
            this.lastdevTEXT = new System.Windows.Forms.TextBox();
            this.newobjLABEL = new System.Windows.Forms.Label();
            this.oldobjLABEL = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.newevtlVIEW = new System.Windows.Forms.ListView();
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oldevtlVIEW = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createdobjLABEL = new System.Windows.Forms.Label();
            this.srcobjVIEW = new System.Windows.Forms.ListView();
            this.objref = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createBUTTON = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.totalTL = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.singledevLABEL = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.hpBUTTON = new System.Windows.Forms.Button();
            this.clearBUTTON = new System.Windows.Forms.Button();
            this.totalrefLABEL = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.devTEXTBOX = new System.Windows.Forms.TextBox();
            this.trendRAD = new System.Windows.Forms.RadioButton();
            this.eventRAD = new System.Windows.Forms.RadioButton();
            this.objCOMBO = new System.Windows.Forms.ComboBox();
            this.dsnTEXTBOX = new System.Windows.Forms.TextBox();
            this.getBUTTON = new System.Windows.Forms.Button();
            this.chkIsRemote = new System.Windows.Forms.CheckBox();
            this.lblRemoteDevice = new System.Windows.Forms.Label();
            this.txtRemoteDevice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkmatchAVInstance
            // 
            this.chkmatchAVInstance.AutoSize = true;
            this.chkmatchAVInstance.Location = new System.Drawing.Point(266, 12);
            this.chkmatchAVInstance.Name = "chkmatchAVInstance";
            this.chkmatchAVInstance.Size = new System.Drawing.Size(117, 17);
            this.chkmatchAVInstance.TabIndex = 77;
            this.chkmatchAVInstance.Text = "Match AV Instance";
            this.chkmatchAVInstance.UseVisualStyleBackColor = true;
            this.chkmatchAVInstance.CheckedChanged += new System.EventHandler(this.rangeCHECK_CheckedChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(948, 564);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(13, 13);
            this.Label4.TabIndex = 76;
            this.Label4.Text = "0";
            // 
            // totobjsLABEL
            // 
            this.totobjsLABEL.AutoSize = true;
            this.totobjsLABEL.Location = new System.Drawing.Point(1201, 9);
            this.totobjsLABEL.Name = "totobjsLABEL";
            this.totobjsLABEL.Size = new System.Drawing.Size(13, 13);
            this.totobjsLABEL.TabIndex = 75;
            this.totobjsLABEL.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(1061, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 13);
            this.Label2.TabIndex = 74;
            this.Label2.Text = "Total Number of Objects = ";
            // 
            // firstdevLABEL
            // 
            this.firstdevLABEL.AutoSize = true;
            this.firstdevLABEL.Location = new System.Drawing.Point(11, 49);
            this.firstdevLABEL.Name = "firstdevLABEL";
            this.firstdevLABEL.Size = new System.Drawing.Size(104, 13);
            this.firstdevLABEL.TabIndex = 73;
            this.firstdevLABEL.Text = "First Device Address";
            this.firstdevLABEL.Visible = false;
            // 
            // lastdevLABEL
            // 
            this.lastdevLABEL.AutoSize = true;
            this.lastdevLABEL.Location = new System.Drawing.Point(11, 87);
            this.lastdevLABEL.Name = "lastdevLABEL";
            this.lastdevLABEL.Size = new System.Drawing.Size(105, 13);
            this.lastdevLABEL.TabIndex = 71;
            this.lastdevLABEL.Text = "Last Device Address";
            this.lastdevLABEL.Visible = false;
            // 
            // rangeCHECK
            // 
            this.rangeCHECK.AutoSize = true;
            this.rangeCHECK.Location = new System.Drawing.Point(266, 49);
            this.rangeCHECK.Name = "rangeCHECK";
            this.rangeCHECK.Size = new System.Drawing.Size(95, 17);
            this.rangeCHECK.TabIndex = 69;
            this.rangeCHECK.Text = "Device Range";
            this.rangeCHECK.UseVisualStyleBackColor = true;
            this.rangeCHECK.CheckedChanged += new System.EventHandler(this.rangeCHECK_CheckedChanged);
            // 
            // sampleInterval
            // 
            this.sampleInterval.Location = new System.Drawing.Point(139, 194);
            this.sampleInterval.Name = "sampleInterval";
            this.sampleInterval.Size = new System.Drawing.Size(121, 20);
            this.sampleInterval.TabIndex = 68;
            this.sampleInterval.Text = "90000";
            // 
            // txtSamples
            // 
            this.txtSamples.Location = new System.Drawing.Point(139, 141);
            this.txtSamples.Name = "txtSamples";
            this.txtSamples.Size = new System.Drawing.Size(121, 20);
            this.txtSamples.TabIndex = 67;
            this.txtSamples.Text = "2688";
            // 
            // lastdevTEXT
            // 
            this.lastdevTEXT.Location = new System.Drawing.Point(139, 87);
            this.lastdevTEXT.Name = "lastdevTEXT";
            this.lastdevTEXT.Size = new System.Drawing.Size(121, 20);
            this.lastdevTEXT.TabIndex = 66;
            this.lastdevTEXT.Visible = false;
            // 
            // newobjLABEL
            // 
            this.newobjLABEL.Location = new System.Drawing.Point(786, 9);
            this.newobjLABEL.Name = "newobjLABEL";
            this.newobjLABEL.Size = new System.Drawing.Size(230, 13);
            this.newobjLABEL.TabIndex = 65;
            this.newobjLABEL.Text = "Current TL/EV Objects";
            this.newobjLABEL.Visible = false;
            // 
            // oldobjLABEL
            // 
            this.oldobjLABEL.AutoSize = true;
            this.oldobjLABEL.Location = new System.Drawing.Point(786, 9);
            this.oldobjLABEL.Name = "oldobjLABEL";
            this.oldobjLABEL.Size = new System.Drawing.Size(230, 13);
            this.oldobjLABEL.TabIndex = 64;
            this.oldobjLABEL.Text = "Existing TL/EV Objects for selected object type";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(382, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(133, 13);
            this.Label5.TabIndex = 63;
            this.Label5.Text = "Select the Desired Objects";
            // 
            // newevtlVIEW
            // 
            this.newevtlVIEW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader2,
            this.ColumnHeader4,
            this.ColumnHeader7,
            this.ColumnHeader9});
            this.newevtlVIEW.FullRowSelect = true;
            this.newevtlVIEW.Location = new System.Drawing.Point(789, 29);
            this.newevtlVIEW.Name = "newevtlVIEW";
            this.newevtlVIEW.Size = new System.Drawing.Size(428, 413);
            this.newevtlVIEW.TabIndex = 62;
            this.newevtlVIEW.UseCompatibleStateImageBehavior = false;
            this.newevtlVIEW.View = System.Windows.Forms.View.Details;
            this.newevtlVIEW.Visible = false;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Object Ref";
            this.ColumnHeader2.Width = 99;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Name";
            this.ColumnHeader4.Width = 188;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Input Ref";
            this.ColumnHeader7.Width = 213;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Dev_ID";
            this.ColumnHeader9.Width = 0;
            // 
            // oldevtlVIEW
            // 
            this.oldevtlVIEW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader3,
            this.ColumnHeader6,
            this.ColumnHeader10});
            this.oldevtlVIEW.Location = new System.Drawing.Point(789, 29);
            this.oldevtlVIEW.Name = "oldevtlVIEW";
            this.oldevtlVIEW.Size = new System.Drawing.Size(428, 413);
            this.oldevtlVIEW.TabIndex = 61;
            this.oldevtlVIEW.UseCompatibleStateImageBehavior = false;
            this.oldevtlVIEW.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Object Ref";
            this.ColumnHeader1.Width = 99;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Name";
            this.ColumnHeader3.Width = 188;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Input Ref";
            this.ColumnHeader6.Width = 162;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "Dev_ID";
            this.ColumnHeader10.Width = 1;
            // 
            // createdobjLABEL
            // 
            this.createdobjLABEL.AutoSize = true;
            this.createdobjLABEL.Location = new System.Drawing.Point(14, 217);
            this.createdobjLABEL.Name = "createdobjLABEL";
            this.createdobjLABEL.Size = new System.Drawing.Size(0, 13);
            this.createdobjLABEL.TabIndex = 60;
            // 
            // srcobjVIEW
            // 
            this.srcobjVIEW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.objref,
            this.objname,
            this.ColumnHeader5,
            this.ColumnHeader8});
            this.srcobjVIEW.FullRowSelect = true;
            this.srcobjVIEW.Location = new System.Drawing.Point(385, 29);
            this.srcobjVIEW.Name = "srcobjVIEW";
            this.srcobjVIEW.Size = new System.Drawing.Size(398, 413);
            this.srcobjVIEW.TabIndex = 59;
            this.srcobjVIEW.UseCompatibleStateImageBehavior = false;
            this.srcobjVIEW.View = System.Windows.Forms.View.Details;
            // 
            // objref
            // 
            this.objref.Text = "Object Ref";
            this.objref.Width = 120;
            // 
            // objname
            // 
            this.objname.Text = "Name";
            this.objname.Width = 151;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Value";
            this.ColumnHeader5.Width = 120;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "DEV_ID";
            this.ColumnHeader8.Width = 0;
            // 
            // createBUTTON
            // 
            this.createBUTTON.Enabled = false;
            this.createBUTTON.Location = new System.Drawing.Point(5, 415);
            this.createBUTTON.Name = "createBUTTON";
            this.createBUTTON.Size = new System.Drawing.Size(88, 27);
            this.createBUTTON.TabIndex = 58;
            this.createBUTTON.Text = "Create Objects";
            this.createBUTTON.UseVisualStyleBackColor = true;
            this.createBUTTON.Click += new System.EventHandler(this.createButton_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(5, 494);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(761, 20);
            this.TextBox1.TabIndex = 57;
            this.TextBox1.Visible = false;
            // 
            // totalTL
            // 
            this.totalTL.AutoSize = true;
            this.totalTL.Location = new System.Drawing.Point(1251, 415);
            this.totalTL.Name = "totalTL";
            this.totalTL.Size = new System.Drawing.Size(13, 13);
            this.totalTL.TabIndex = 56;
            this.totalTL.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(116, 13);
            this.Label3.TabIndex = 55;
            this.Label3.Text = "ODBC DSN Reference";
            // 
            // singledevLABEL
            // 
            this.singledevLABEL.AutoSize = true;
            this.singledevLABEL.Location = new System.Drawing.Point(12, 49);
            this.singledevLABEL.Name = "singledevLABEL";
            this.singledevLABEL.Size = new System.Drawing.Size(110, 13);
            this.singledevLABEL.TabIndex = 54;
            this.singledevLABEL.Text = "Enter Device Address";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 170);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Select Object";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(214, 415);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 52;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // hpBUTTON
            // 
            this.hpBUTTON.Location = new System.Drawing.Point(304, 415);
            this.hpBUTTON.Name = "hpBUTTON";
            this.hpBUTTON.Size = new System.Drawing.Size(75, 27);
            this.hpBUTTON.TabIndex = 51;
            this.hpBUTTON.Text = "Help/About";
            this.hpBUTTON.UseVisualStyleBackColor = true;
            this.hpBUTTON.Click += new System.EventHandler(this.hpBUTTON_Click);
            // 
            // clearBUTTON
            // 
            this.clearBUTTON.Location = new System.Drawing.Point(107, 415);
            this.clearBUTTON.Name = "clearBUTTON";
            this.clearBUTTON.Size = new System.Drawing.Size(93, 27);
            this.clearBUTTON.TabIndex = 50;
            this.clearBUTTON.Text = "Clear Results";
            this.clearBUTTON.UseVisualStyleBackColor = true;
            this.clearBUTTON.Click += new System.EventHandler(this.clearBUTTON_Click);
            // 
            // totalrefLABEL
            // 
            this.totalrefLABEL.AutoSize = true;
            this.totalrefLABEL.Location = new System.Drawing.Point(2, 535);
            this.totalrefLABEL.Name = "totalrefLABEL";
            this.totalrefLABEL.Size = new System.Drawing.Size(13, 13);
            this.totalrefLABEL.TabIndex = 49;
            this.totalrefLABEL.Text = "0";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(14, 228);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(354, 27);
            this.ProgressBar1.TabIndex = 48;
            this.ProgressBar1.Visible = false;
            // 
            // devTEXTBOX
            // 
            this.devTEXTBOX.Location = new System.Drawing.Point(139, 46);
            this.devTEXTBOX.Name = "devTEXTBOX";
            this.devTEXTBOX.Size = new System.Drawing.Size(121, 20);
            this.devTEXTBOX.TabIndex = 47;
            // 
            // trendRAD
            // 
            this.trendRAD.AutoSize = true;
            this.trendRAD.Checked = true;
            this.trendRAD.Location = new System.Drawing.Point(14, 263);
            this.trendRAD.Name = "trendRAD";
            this.trendRAD.Size = new System.Drawing.Size(79, 17);
            this.trendRAD.TabIndex = 46;
            this.trendRAD.TabStop = true;
            this.trendRAD.Text = "Trend Logs";
            this.trendRAD.UseVisualStyleBackColor = true;
            // 
            // eventRAD
            // 
            this.eventRAD.AutoSize = true;
            this.eventRAD.Location = new System.Drawing.Point(14, 286);
            this.eventRAD.Name = "eventRAD";
            this.eventRAD.Size = new System.Drawing.Size(58, 17);
            this.eventRAD.TabIndex = 45;
            this.eventRAD.TabStop = true;
            this.eventRAD.Text = "Events";
            this.eventRAD.UseVisualStyleBackColor = true;
            // 
            // objCOMBO
            // 
            this.objCOMBO.DisplayMember = "260";
            this.objCOMBO.FormattingEnabled = true;
            this.objCOMBO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.objCOMBO.Location = new System.Drawing.Point(139, 167);
            this.objCOMBO.Name = "objCOMBO";
            this.objCOMBO.Size = new System.Drawing.Size(121, 21);
            this.objCOMBO.TabIndex = 44;
            this.objCOMBO.Text = "AO";
            this.objCOMBO.ValueMember = "260";
            this.objCOMBO.SelectedIndexChanged += new System.EventHandler(this.objCOMBO_SelectedIndexChanged);
            // 
            // dsnTEXTBOX
            // 
            this.dsnTEXTBOX.Location = new System.Drawing.Point(139, 9);
            this.dsnTEXTBOX.Name = "dsnTEXTBOX";
            this.dsnTEXTBOX.Size = new System.Drawing.Size(121, 20);
            this.dsnTEXTBOX.TabIndex = 43;
            this.dsnTEXTBOX.Text = "Delta Network";
            // 
            // getBUTTON
            // 
            this.getBUTTON.Location = new System.Drawing.Point(14, 318);
            this.getBUTTON.Name = "getBUTTON";
            this.getBUTTON.Size = new System.Drawing.Size(88, 23);
            this.getBUTTON.TabIndex = 42;
            this.getBUTTON.Text = "Get Object List";
            this.getBUTTON.UseVisualStyleBackColor = true;
            this.getBUTTON.Click += new System.EventHandler(this.getButton_Click);
            // 
            // chkIsRemote
            // 
            this.chkIsRemote.AutoSize = true;
            this.chkIsRemote.Location = new System.Drawing.Point(266, 72);
            this.chkIsRemote.Name = "chkIsRemote";
            this.chkIsRemote.Size = new System.Drawing.Size(100, 17);
            this.chkIsRemote.TabIndex = 78;
            this.chkIsRemote.Text = "Remote Device";
            this.chkIsRemote.UseVisualStyleBackColor = true;
            this.chkIsRemote.CheckedChanged += new System.EventHandler(this.chkIsRemote_CheckedChanged);
            // 
            // lblRemoteDevice
            // 
            this.lblRemoteDevice.AutoSize = true;
            this.lblRemoteDevice.Location = new System.Drawing.Point(11, 115);
            this.lblRemoteDevice.Name = "lblRemoteDevice";
            this.lblRemoteDevice.Size = new System.Drawing.Size(122, 13);
            this.lblRemoteDevice.TabIndex = 80;
            this.lblRemoteDevice.Text = "Remote Device Address";
            this.lblRemoteDevice.Visible = false;
            // 
            // txtRemoteDevice
            // 
            this.txtRemoteDevice.Location = new System.Drawing.Point(139, 115);
            this.txtRemoteDevice.Name = "txtRemoteDevice";
            this.txtRemoteDevice.Size = new System.Drawing.Size(121, 20);
            this.txtRemoteDevice.TabIndex = 79;
            this.txtRemoteDevice.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Max Samples";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Interval (milliseconds)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 445);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRemoteDevice);
            this.Controls.Add(this.txtRemoteDevice);
            this.Controls.Add(this.chkIsRemote);
            this.Controls.Add(this.chkmatchAVInstance);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.totobjsLABEL);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.firstdevLABEL);
            this.Controls.Add(this.lastdevLABEL);
            this.Controls.Add(this.rangeCHECK);
            this.Controls.Add(this.sampleInterval);
            this.Controls.Add(this.txtSamples);
            this.Controls.Add(this.lastdevTEXT);
            this.Controls.Add(this.newobjLABEL);
            this.Controls.Add(this.oldobjLABEL);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.newevtlVIEW);
            this.Controls.Add(this.oldevtlVIEW);
            this.Controls.Add(this.createdobjLABEL);
            this.Controls.Add(this.srcobjVIEW);
            this.Controls.Add(this.createBUTTON);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.totalTL);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.singledevLABEL);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.hpBUTTON);
            this.Controls.Add(this.clearBUTTON);
            this.Controls.Add(this.totalrefLABEL);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.devTEXTBOX);
            this.Controls.Add(this.trendRAD);
            this.Controls.Add(this.eventRAD);
            this.Controls.Add(this.objCOMBO);
            this.Controls.Add(this.dsnTEXTBOX);
            this.Controls.Add(this.getBUTTON);
            this.Name = "Form1";
            this.Text = "TL & Alarm Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkmatchAVInstance;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label totobjsLABEL;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label firstdevLABEL;
        internal System.Windows.Forms.Label lastdevLABEL;
        internal System.Windows.Forms.CheckBox rangeCHECK;
        internal System.Windows.Forms.TextBox sampleInterval;
        internal System.Windows.Forms.TextBox txtSamples;
        internal System.Windows.Forms.TextBox lastdevTEXT;
        internal System.Windows.Forms.Label newobjLABEL;
        internal System.Windows.Forms.Label oldobjLABEL;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListView newevtlVIEW;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.ColumnHeader ColumnHeader9;
        internal System.Windows.Forms.ListView oldevtlVIEW;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader10;
        internal System.Windows.Forms.Label createdobjLABEL;
        internal System.Windows.Forms.ListView srcobjVIEW;
        internal System.Windows.Forms.ColumnHeader objref;
        internal System.Windows.Forms.ColumnHeader objname;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader8;
        internal System.Windows.Forms.Button createBUTTON;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label totalTL;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label singledevLABEL;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.Button hpBUTTON;
        internal System.Windows.Forms.Button clearBUTTON;
        internal System.Windows.Forms.Label totalrefLABEL;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.TextBox devTEXTBOX;
        internal System.Windows.Forms.RadioButton trendRAD;
        internal System.Windows.Forms.RadioButton eventRAD;
        internal System.Windows.Forms.ComboBox objCOMBO;
        internal System.Windows.Forms.TextBox dsnTEXTBOX;
        internal System.Windows.Forms.Button getBUTTON;
        internal System.Windows.Forms.CheckBox chkIsRemote;
        internal System.Windows.Forms.Label lblRemoteDevice;
        internal System.Windows.Forms.TextBox txtRemoteDevice;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
    }
}

