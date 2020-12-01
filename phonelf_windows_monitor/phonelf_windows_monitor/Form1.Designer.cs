namespace phonelf_windows_monitor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox GPsys;
            this.BOOLhdd = new System.Windows.Forms.CheckBox();
            this.clone_ip = new System.Windows.Forms.Button();
            this.file_des = new System.Windows.Forms.Label();
            this.file_sel = new System.Windows.Forms.Button();
            this.SVsat = new System.Windows.Forms.Label();
            this.LAB_99999010 = new System.Windows.Forms.Label();
            this.LAB_999999020 = new System.Windows.Forms.Label();
            this.LAB99001 = new System.Windows.Forms.Label();
            this.user_ip_inp = new System.Windows.Forms.TextBox();
            this.checkip = new System.Windows.Forms.Button();
            this.use_local_ip = new System.Windows.Forms.CheckBox();
            this.able_time_new = new System.Windows.Forms.CheckBox();
            this.LAB9999001 = new System.Windows.Forms.Label();
            this.renewTI = new System.Windows.Forms.NumericUpDown();
            this.noap = new System.Windows.Forms.CheckBox();
            this.svCLS = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SVon = new System.Windows.Forms.Button();
            this.conS = new System.Windows.Forms.RichTextBox();
            this.ipSHOW = new System.Windows.Forms.Label();
            this.LAB99997 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.LAB99999 = new System.Windows.Forms.Label();
            this.GPget = new System.Windows.Forms.GroupBox();
            this.GPsend = new System.Windows.Forms.GroupBox();
            this.LAB99000 = new System.Windows.Forms.Label();
            this.EndTHING = new System.Windows.Forms.Label();
            this.LAB99990 = new System.Windows.Forms.Label();
            this.LAB99980 = new System.Windows.Forms.Label();
            this.da4 = new System.Windows.Forms.TextBox();
            this.da3 = new System.Windows.Forms.TextBox();
            this.da2 = new System.Windows.Forms.TextBox();
            this.da1 = new System.Windows.Forms.TextBox();
            this.satBOXsub = new System.Windows.Forms.Button();
            this.LAB99994 = new System.Windows.Forms.Label();
            this.LAB99993 = new System.Windows.Forms.Label();
            this.LAB99992 = new System.Windows.Forms.Label();
            this.LAB99991 = new System.Windows.Forms.Label();
            this.da0 = new System.Windows.Forms.TextBox();
            this.LAB99970 = new System.Windows.Forms.Label();
            this.hhmmssSHOW = new System.Windows.Forms.Label();
            this.STARTTHING = new System.Windows.Forms.Label();
            this.gui_group = new System.Windows.Forms.GroupBox();
            this.gui_stb = new System.Windows.Forms.Button();
            this.gui_set = new System.Windows.Forms.Button();
            this.gui_mt = new System.Windows.Forms.Button();
            this.gui_fly = new System.Windows.Forms.Button();
            GPsys = new System.Windows.Forms.GroupBox();
            GPsys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renewTI)).BeginInit();
            this.GPsend.SuspendLayout();
            this.gui_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPsys
            // 
            GPsys.Controls.Add(this.BOOLhdd);
            GPsys.Controls.Add(this.clone_ip);
            GPsys.Controls.Add(this.file_des);
            GPsys.Controls.Add(this.file_sel);
            GPsys.Controls.Add(this.SVsat);
            GPsys.Controls.Add(this.LAB_99999010);
            GPsys.Controls.Add(this.LAB_999999020);
            GPsys.Controls.Add(this.LAB99001);
            GPsys.Controls.Add(this.user_ip_inp);
            GPsys.Controls.Add(this.checkip);
            GPsys.Controls.Add(this.use_local_ip);
            GPsys.Controls.Add(this.able_time_new);
            GPsys.Controls.Add(this.LAB9999001);
            GPsys.Controls.Add(this.renewTI);
            GPsys.Controls.Add(this.noap);
            GPsys.Controls.Add(this.svCLS);
            GPsys.Controls.Add(this.txtPort);
            GPsys.Controls.Add(this.SVon);
            GPsys.Controls.Add(this.conS);
            GPsys.Controls.Add(this.ipSHOW);
            GPsys.Controls.Add(this.LAB99997);
            GPsys.Controls.Add(this.lblTime);
            GPsys.Controls.Add(this.LAB99999);
            GPsys.Location = new System.Drawing.Point(13, 324);
            GPsys.Name = "GPsys";
            GPsys.Size = new System.Drawing.Size(742, 155);
            GPsys.TabIndex = 2;
            GPsys.TabStop = false;
            GPsys.Text = "system";
            // 
            // BOOLhdd
            // 
            this.BOOLhdd.AutoSize = true;
            this.BOOLhdd.Location = new System.Drawing.Point(142, 132);
            this.BOOLhdd.Name = "BOOLhdd";
            this.BOOLhdd.Size = new System.Drawing.Size(72, 16);
            this.BOOLhdd.TabIndex = 24;
            this.BOOLhdd.Text = "硬碟紀錄";
            this.BOOLhdd.UseVisualStyleBackColor = true;
            // 
            // clone_ip
            // 
            this.clone_ip.Location = new System.Drawing.Point(198, 43);
            this.clone_ip.Name = "clone_ip";
            this.clone_ip.Size = new System.Drawing.Size(44, 23);
            this.clone_ip.TabIndex = 23;
            this.clone_ip.Text = "複製";
            this.clone_ip.UseVisualStyleBackColor = true;
            this.clone_ip.Click += new System.EventHandler(this.clone_ip_Click);
            // 
            // file_des
            // 
            this.file_des.AutoSize = true;
            this.file_des.Location = new System.Drawing.Point(318, 133);
            this.file_des.Name = "file_des";
            this.file_des.Size = new System.Drawing.Size(49, 12);
            this.file_des.TabIndex = 22;
            this.file_des.Text = "loading...";
            this.file_des.Click += new System.EventHandler(this.file_des_Click);
            // 
            // file_sel
            // 
            this.file_sel.Location = new System.Drawing.Point(237, 128);
            this.file_sel.Name = "file_sel";
            this.file_sel.Size = new System.Drawing.Size(75, 23);
            this.file_sel.TabIndex = 21;
            this.file_sel.Text = "後送";
            this.file_sel.UseVisualStyleBackColor = true;
            this.file_sel.Click += new System.EventHandler(this.file_sel_Click);
            // 
            // SVsat
            // 
            this.SVsat.AutoSize = true;
            this.SVsat.Location = new System.Drawing.Point(396, 80);
            this.SVsat.Name = "SVsat";
            this.SVsat.Size = new System.Drawing.Size(49, 12);
            this.SVsat.TabIndex = 20;
            this.SVsat.Text = "loading...";
            // 
            // LAB_99999010
            // 
            this.LAB_99999010.AutoSize = true;
            this.LAB_99999010.Location = new System.Drawing.Point(400, 54);
            this.LAB_99999010.Name = "LAB_99999010";
            this.LAB_99999010.Size = new System.Drawing.Size(29, 12);
            this.LAB_99999010.TabIndex = 19;
            this.LAB_99999010.Text = "狀態";
            // 
            // LAB_999999020
            // 
            this.LAB_999999020.AutoSize = true;
            this.LAB_999999020.Location = new System.Drawing.Point(94, 79);
            this.LAB_999999020.Name = "LAB_999999020";
            this.LAB_999999020.Size = new System.Drawing.Size(29, 12);
            this.LAB_999999020.TabIndex = 18;
            this.LAB_999999020.Text = "監聽";
            // 
            // LAB99001
            // 
            this.LAB99001.AutoSize = true;
            this.LAB99001.Location = new System.Drawing.Point(255, 22);
            this.LAB99001.Name = "LAB99001";
            this.LAB99001.Size = new System.Drawing.Size(57, 12);
            this.LAB99001.TabIndex = 17;
            this.LAB99001.Text = "port numb.";
            // 
            // user_ip_inp
            // 
            this.user_ip_inp.Enabled = false;
            this.user_ip_inp.Location = new System.Drawing.Point(142, 70);
            this.user_ip_inp.Name = "user_ip_inp";
            this.user_ip_inp.Size = new System.Drawing.Size(100, 22);
            this.user_ip_inp.TabIndex = 16;
            // 
            // checkip
            // 
            this.checkip.Location = new System.Drawing.Point(28, 43);
            this.checkip.Name = "checkip";
            this.checkip.Size = new System.Drawing.Size(50, 23);
            this.checkip.TabIndex = 15;
            this.checkip.Text = "check";
            this.checkip.UseVisualStyleBackColor = true;
            this.checkip.Click += new System.EventHandler(this.checkip_Click);
            // 
            // use_local_ip
            // 
            this.use_local_ip.AutoSize = true;
            this.use_local_ip.Location = new System.Drawing.Point(9, 72);
            this.use_local_ip.Name = "use_local_ip";
            this.use_local_ip.Size = new System.Drawing.Size(72, 16);
            this.use_local_ip.TabIndex = 14;
            this.use_local_ip.Text = "區域網路";
            this.use_local_ip.UseVisualStyleBackColor = true;
            this.use_local_ip.CheckedChanged += new System.EventHandler(this.use_local_ip_CheckedChanged);
            // 
            // able_time_new
            // 
            this.able_time_new.AutoSize = true;
            this.able_time_new.Checked = true;
            this.able_time_new.CheckState = System.Windows.Forms.CheckState.Checked;
            this.able_time_new.Location = new System.Drawing.Point(6, 128);
            this.able_time_new.Name = "able_time_new";
            this.able_time_new.Size = new System.Drawing.Size(72, 16);
            this.able_time_new.TabIndex = 13;
            this.able_time_new.Text = "定時刷新";
            this.able_time_new.UseVisualStyleBackColor = true;
            // 
            // LAB9999001
            // 
            this.LAB9999001.AutoSize = true;
            this.LAB9999001.Location = new System.Drawing.Point(92, 107);
            this.LAB9999001.Name = "LAB9999001";
            this.LAB9999001.Size = new System.Drawing.Size(53, 12);
            this.LAB9999001.TabIndex = 12;
            this.LAB9999001.Text = "刷新時間";
            // 
            // renewTI
            // 
            this.renewTI.Location = new System.Drawing.Point(161, 105);
            this.renewTI.Name = "renewTI";
            this.renewTI.Size = new System.Drawing.Size(120, 22);
            this.renewTI.TabIndex = 11;
            this.renewTI.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // noap
            // 
            this.noap.AutoSize = true;
            this.noap.Location = new System.Drawing.Point(7, 106);
            this.noap.Name = "noap";
            this.noap.Size = new System.Drawing.Size(60, 16);
            this.noap.TabIndex = 10;
            this.noap.Text = "無附加";
            this.noap.UseVisualStyleBackColor = true;
            // 
            // svCLS
            // 
            this.svCLS.Location = new System.Drawing.Point(318, 95);
            this.svCLS.Name = "svCLS";
            this.svCLS.Size = new System.Drawing.Size(75, 23);
            this.svCLS.TabIndex = 9;
            this.svCLS.Text = "伺服器關閉";
            this.svCLS.UseVisualStyleBackColor = true;
            this.svCLS.Click += new System.EventHandler(this.svCLS_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(318, 18);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "9999";
            // 
            // SVon
            // 
            this.SVon.Location = new System.Drawing.Point(318, 49);
            this.SVon.Name = "SVon";
            this.SVon.Size = new System.Drawing.Size(75, 39);
            this.SVon.TabIndex = 7;
            this.SVon.Text = "伺服器啟動";
            this.SVon.UseVisualStyleBackColor = true;
            this.SVon.Click += new System.EventHandler(this.SVon_Click);
            // 
            // conS
            // 
            this.conS.Location = new System.Drawing.Point(450, 18);
            this.conS.Name = "conS";
            this.conS.Size = new System.Drawing.Size(285, 96);
            this.conS.TabIndex = 6;
            this.conS.Text = "";
            // 
            // ipSHOW
            // 
            this.ipSHOW.AutoSize = true;
            this.ipSHOW.Location = new System.Drawing.Point(92, 54);
            this.ipSHOW.Name = "ipSHOW";
            this.ipSHOW.Size = new System.Drawing.Size(49, 12);
            this.ipSHOW.TabIndex = 5;
            this.ipSHOW.Text = "loading...";
            // 
            // LAB99997
            // 
            this.LAB99997.AutoSize = true;
            this.LAB99997.Location = new System.Drawing.Point(7, 54);
            this.LAB99997.Name = "LAB99997";
            this.LAB99997.Size = new System.Drawing.Size(14, 12);
            this.LAB99997.TabIndex = 3;
            this.LAB99997.Text = "ip";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(94, 22);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 12);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label2";
            // 
            // LAB99999
            // 
            this.LAB99999.AutoSize = true;
            this.LAB99999.Location = new System.Drawing.Point(7, 22);
            this.LAB99999.Name = "LAB99999";
            this.LAB99999.Size = new System.Drawing.Size(53, 12);
            this.LAB99999.TabIndex = 0;
            this.LAB99999.Text = "系統時間";
            // 
            // GPget
            // 
            this.GPget.Location = new System.Drawing.Point(13, 13);
            this.GPget.Name = "GPget";
            this.GPget.Size = new System.Drawing.Size(742, 100);
            this.GPget.TabIndex = 0;
            this.GPget.TabStop = false;
            this.GPget.Text = "get";
            // 
            // GPsend
            // 
            this.GPsend.CausesValidation = false;
            this.GPsend.Controls.Add(this.LAB99000);
            this.GPsend.Controls.Add(this.EndTHING);
            this.GPsend.Controls.Add(this.LAB99990);
            this.GPsend.Controls.Add(this.LAB99980);
            this.GPsend.Controls.Add(this.da4);
            this.GPsend.Controls.Add(this.da3);
            this.GPsend.Controls.Add(this.da2);
            this.GPsend.Controls.Add(this.da1);
            this.GPsend.Controls.Add(this.satBOXsub);
            this.GPsend.Controls.Add(this.LAB99994);
            this.GPsend.Controls.Add(this.LAB99993);
            this.GPsend.Controls.Add(this.LAB99992);
            this.GPsend.Controls.Add(this.LAB99991);
            this.GPsend.Controls.Add(this.da0);
            this.GPsend.Controls.Add(this.LAB99970);
            this.GPsend.Controls.Add(this.hhmmssSHOW);
            this.GPsend.Controls.Add(this.STARTTHING);
            this.GPsend.Location = new System.Drawing.Point(13, 120);
            this.GPsend.Name = "GPsend";
            this.GPsend.Size = new System.Drawing.Size(742, 184);
            this.GPsend.TabIndex = 1;
            this.GPsend.TabStop = false;
            this.GPsend.Text = "send";
            // 
            // LAB99000
            // 
            this.LAB99000.AutoSize = true;
            this.LAB99000.Location = new System.Drawing.Point(11, 91);
            this.LAB99000.Name = "LAB99000";
            this.LAB99000.Size = new System.Drawing.Size(29, 12);
            this.LAB99000.TabIndex = 16;
            this.LAB99000.Text = "結束";
            // 
            // EndTHING
            // 
            this.EndTHING.AutoSize = true;
            this.EndTHING.Location = new System.Drawing.Point(9, 122);
            this.EndTHING.Name = "EndTHING";
            this.EndTHING.Size = new System.Drawing.Size(11, 12);
            this.EndTHING.TabIndex = 15;
            this.EndTHING.Text = "~";
            // 
            // LAB99990
            // 
            this.LAB99990.AutoSize = true;
            this.LAB99990.Location = new System.Drawing.Point(402, 94);
            this.LAB99990.Name = "LAB99990";
            this.LAB99990.Size = new System.Drawing.Size(37, 12);
            this.LAB99990.TabIndex = 14;
            this.LAB99990.Text = "z/mot3";
            // 
            // LAB99980
            // 
            this.LAB99980.AutoSize = true;
            this.LAB99980.Location = new System.Drawing.Point(402, 60);
            this.LAB99980.Name = "LAB99980";
            this.LAB99980.Size = new System.Drawing.Size(38, 12);
            this.LAB99980.TabIndex = 13;
            this.LAB99980.Text = "y/mot2";
            // 
            // da4
            // 
            this.da4.Location = new System.Drawing.Point(441, 134);
            this.da4.Name = "da4";
            this.da4.Size = new System.Drawing.Size(100, 22);
            this.da4.TabIndex = 12;
            // 
            // da3
            // 
            this.da3.Location = new System.Drawing.Point(441, 91);
            this.da3.Name = "da3";
            this.da3.Size = new System.Drawing.Size(100, 22);
            this.da3.TabIndex = 11;
            // 
            // da2
            // 
            this.da2.Location = new System.Drawing.Point(441, 53);
            this.da2.Name = "da2";
            this.da2.Size = new System.Drawing.Size(100, 22);
            this.da2.TabIndex = 10;
            // 
            // da1
            // 
            this.da1.Location = new System.Drawing.Point(441, 18);
            this.da1.Name = "da1";
            this.da1.Size = new System.Drawing.Size(100, 22);
            this.da1.TabIndex = 9;
            // 
            // satBOXsub
            // 
            this.satBOXsub.Location = new System.Drawing.Point(651, 22);
            this.satBOXsub.Name = "satBOXsub";
            this.satBOXsub.Size = new System.Drawing.Size(75, 50);
            this.satBOXsub.TabIndex = 8;
            this.satBOXsub.Text = "狀態傳送";
            this.satBOXsub.UseVisualStyleBackColor = true;
            this.satBOXsub.Click += new System.EventHandler(this.satBOXsub_Click);
            // 
            // LAB99994
            // 
            this.LAB99994.AutoSize = true;
            this.LAB99994.Location = new System.Drawing.Point(392, 137);
            this.LAB99994.Name = "LAB99994";
            this.LAB99994.Size = new System.Drawing.Size(43, 12);
            this.LAB99994.TabIndex = 7;
            this.LAB99994.Text = "alt/mot4";
            // 
            // LAB99993
            // 
            this.LAB99993.AutoSize = true;
            this.LAB99993.Location = new System.Drawing.Point(250, 21);
            this.LAB99993.Name = "LAB99993";
            this.LAB99993.Size = new System.Drawing.Size(53, 12);
            this.LAB99993.TabIndex = 6;
            this.LAB99993.Text = "現實時間";
            // 
            // LAB99992
            // 
            this.LAB99992.AutoSize = true;
            this.LAB99992.Location = new System.Drawing.Point(94, 21);
            this.LAB99992.Name = "LAB99992";
            this.LAB99992.Size = new System.Drawing.Size(29, 12);
            this.LAB99992.TabIndex = 5;
            this.LAB99992.Text = "狀態";
            // 
            // LAB99991
            // 
            this.LAB99991.AutoSize = true;
            this.LAB99991.Location = new System.Drawing.Point(9, 22);
            this.LAB99991.Name = "LAB99991";
            this.LAB99991.Size = new System.Drawing.Size(29, 12);
            this.LAB99991.TabIndex = 4;
            this.LAB99991.Text = "起始";
            // 
            // da0
            // 
            this.da0.Location = new System.Drawing.Point(94, 50);
            this.da0.Name = "da0";
            this.da0.Size = new System.Drawing.Size(100, 22);
            this.da0.TabIndex = 3;
            // 
            // LAB99970
            // 
            this.LAB99970.AutoSize = true;
            this.LAB99970.Location = new System.Drawing.Point(402, 22);
            this.LAB99970.Name = "LAB99970";
            this.LAB99970.Size = new System.Drawing.Size(38, 12);
            this.LAB99970.TabIndex = 2;
            this.LAB99970.Text = "x/mot1";
            // 
            // hhmmssSHOW
            // 
            this.hhmmssSHOW.AutoSize = true;
            this.hhmmssSHOW.Location = new System.Drawing.Point(248, 53);
            this.hhmmssSHOW.Name = "hhmmssSHOW";
            this.hhmmssSHOW.Size = new System.Drawing.Size(33, 12);
            this.hhmmssSHOW.TabIndex = 1;
            this.hhmmssSHOW.Text = "label2";
            // 
            // STARTTHING
            // 
            this.STARTTHING.AutoSize = true;
            this.STARTTHING.Location = new System.Drawing.Point(7, 53);
            this.STARTTHING.Name = "STARTTHING";
            this.STARTTHING.Size = new System.Drawing.Size(11, 12);
            this.STARTTHING.TabIndex = 0;
            this.STARTTHING.Text = "$";
            // 
            // gui_group
            // 
            this.gui_group.Controls.Add(this.gui_stb);
            this.gui_group.Controls.Add(this.gui_set);
            this.gui_group.Controls.Add(this.gui_mt);
            this.gui_group.Controls.Add(this.gui_fly);
            this.gui_group.Location = new System.Drawing.Point(767, 120);
            this.gui_group.Name = "gui_group";
            this.gui_group.Size = new System.Drawing.Size(229, 183);
            this.gui_group.TabIndex = 3;
            this.gui_group.TabStop = false;
            this.gui_group.Text = "gui";
            // 
            // gui_stb
            // 
            this.gui_stb.Location = new System.Drawing.Point(87, 23);
            this.gui_stb.Name = "gui_stb";
            this.gui_stb.Size = new System.Drawing.Size(68, 141);
            this.gui_stb.TabIndex = 3;
            this.gui_stb.Text = "待命";
            this.gui_stb.UseVisualStyleBackColor = true;
            this.gui_stb.Click += new System.EventHandler(this.gui_stb_Click);
            // 
            // gui_set
            // 
            this.gui_set.Location = new System.Drawing.Point(13, 122);
            this.gui_set.Name = "gui_set";
            this.gui_set.Size = new System.Drawing.Size(68, 42);
            this.gui_set.TabIndex = 2;
            this.gui_set.Text = "設定";
            this.gui_set.UseVisualStyleBackColor = true;
            this.gui_set.Click += new System.EventHandler(this.gui_set_Click);
            // 
            // gui_mt
            // 
            this.gui_mt.Location = new System.Drawing.Point(13, 71);
            this.gui_mt.Name = "gui_mt";
            this.gui_mt.Size = new System.Drawing.Size(68, 42);
            this.gui_mt.TabIndex = 1;
            this.gui_mt.Text = "馬達控制";
            this.gui_mt.UseVisualStyleBackColor = true;
            this.gui_mt.Click += new System.EventHandler(this.gui_mt_Click);
            // 
            // gui_fly
            // 
            this.gui_fly.Location = new System.Drawing.Point(13, 22);
            this.gui_fly.Name = "gui_fly";
            this.gui_fly.Size = new System.Drawing.Size(68, 43);
            this.gui_fly.TabIndex = 0;
            this.gui_fly.Text = "飛行";
            this.gui_fly.UseVisualStyleBackColor = true;
            this.gui_fly.Click += new System.EventHandler(this.gui_fly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 491);
            this.Controls.Add(this.gui_group);
            this.Controls.Add(GPsys);
            this.Controls.Add(this.GPsend);
            this.Controls.Add(this.GPget);
            this.Name = "Form1";
            this.Text = "phonelf_windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            GPsys.ResumeLayout(false);
            GPsys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renewTI)).EndInit();
            this.GPsend.ResumeLayout(false);
            this.GPsend.PerformLayout();
            this.gui_group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPget;
        private System.Windows.Forms.GroupBox GPsend;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label LAB99999;
        private System.Windows.Forms.Label LAB99970;
        private System.Windows.Forms.Label hhmmssSHOW;
        private System.Windows.Forms.Label STARTTHING;
        private System.Windows.Forms.Button satBOXsub;
        private System.Windows.Forms.Label LAB99994;
        private System.Windows.Forms.Label LAB99993;
        private System.Windows.Forms.Label LAB99992;
        private System.Windows.Forms.Label LAB99991;
        private System.Windows.Forms.TextBox da0;
        private System.Windows.Forms.Label ipSHOW;
        private System.Windows.Forms.Label LAB99997;
        private System.Windows.Forms.RichTextBox conS;
        private System.Windows.Forms.Button SVon;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button svCLS;
        private System.Windows.Forms.Label LAB99990;
        private System.Windows.Forms.Label LAB99980;
        private System.Windows.Forms.TextBox da4;
        private System.Windows.Forms.TextBox da3;
        private System.Windows.Forms.TextBox da2;
        private System.Windows.Forms.TextBox da1;
        private System.Windows.Forms.Label LAB99000;
        private System.Windows.Forms.Label EndTHING;
        private System.Windows.Forms.CheckBox able_time_new;
        private System.Windows.Forms.Label LAB9999001;
        private System.Windows.Forms.NumericUpDown renewTI;
        private System.Windows.Forms.CheckBox noap;
        private System.Windows.Forms.CheckBox BOOLhdd;
        private System.Windows.Forms.Button clone_ip;
        private System.Windows.Forms.Label file_des;
        private System.Windows.Forms.Button file_sel;
        private System.Windows.Forms.Label SVsat;
        private System.Windows.Forms.Label LAB_99999010;
        private System.Windows.Forms.Label LAB_999999020;
        private System.Windows.Forms.Label LAB99001;
        private System.Windows.Forms.TextBox user_ip_inp;
        private System.Windows.Forms.Button checkip;
        private System.Windows.Forms.CheckBox use_local_ip;
        private System.Windows.Forms.GroupBox gui_group;
        private System.Windows.Forms.Button gui_stb;
        private System.Windows.Forms.Button gui_set;
        private System.Windows.Forms.Button gui_mt;
        private System.Windows.Forms.Button gui_fly;
    }
}

