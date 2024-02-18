namespace Code_WinForm
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.pictureBox_tick_Ok = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Logo_trường = new System.Windows.Forms.Label();
            this.groupBox_JOG = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.txt_Jog_SpeedZ = new System.Windows.Forms.TextBox();
            this.txt_Jog_SpeedY = new System.Windows.Forms.TextBox();
            this.txt_Jog_SpeedX = new System.Windows.Forms.TextBox();
            this.lbl_Jog_SpeedZ = new System.Windows.Forms.Label();
            this.lbl_Jog_SpeedY = new System.Windows.Forms.Label();
            this.lbl_Jog_SpeedX = new System.Windows.Forms.Label();
            this.txt_Z_Position = new System.Windows.Forms.TextBox();
            this.txt_Y_Position = new System.Windows.Forms.TextBox();
            this.txt_X_Position = new System.Windows.Forms.TextBox();
            this.btn_JOG_Z_sub = new System.Windows.Forms.Button();
            this.btn_JOG_Y_sub = new System.Windows.Forms.Button();
            this.btn_JOG_X_sub = new System.Windows.Forms.Button();
            this.btn_JOG_Z_add = new System.Windows.Forms.Button();
            this.btn_JOG_Y_add = new System.Windows.Forms.Button();
            this.btn_Jog_X_add = new System.Windows.Forms.Button();
            this.lbl_Axis_Z = new System.Windows.Forms.Label();
            this.lbl_Axis_Y = new System.Windows.Forms.Label();
            this.lbl_Axis_X = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Reset_Error = new System.Windows.Forms.Button();
            this.btn_Thoát = new System.Windows.Forms.Button();
            this.btn_find_Home = new System.Windows.Forms.Button();
            this.btn_On_Off = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.groupBox_Error_Code = new System.Windows.Forms.GroupBox();
            this.lbl_Error_Code_Axis3 = new System.Windows.Forms.Label();
            this.lbl_Error_Code_Axis2 = new System.Windows.Forms.Label();
            this.lbl_Error_Code_Axis1 = new System.Windows.Forms.Label();
            this.txt_Error_Code_Axis3 = new System.Windows.Forms.TextBox();
            this.txt_Error_Code_Axis2 = new System.Windows.Forms.TextBox();
            this.txt_Error_Code_Axis1 = new System.Windows.Forms.TextBox();
            this.groupBox_Nội_Suy = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Z_up = new System.Windows.Forms.TextBox();
            this.btn_END_nội_suy = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_SpeedZ_nội_suy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Toa_độ_Z_nội_suy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Speed_point1_to_point2 = new System.Windows.Forms.TextBox();
            this.btn_RUN = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.lbl_Điểm_trung_gian_cung_tròn = new System.Windows.Forms.Label();
            this.txt_Arc_Adress_Y = new System.Windows.Forms.TextBox();
            this.txt_Arc_Adress_X = new System.Windows.Forms.TextBox();
            this.lbl_P2 = new System.Windows.Forms.Label();
            this.txt_P2_Y = new System.Windows.Forms.TextBox();
            this.txt_P2_X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_P1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_P1_Y = new System.Windows.Forms.TextBox();
            this.txt_P1_X = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Đồng_hồ = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Đồ_thị_tọa_độ_XY = new ZedGraph.ZedGraphControl();
            this.rtbox_Nhập_code = new System.Windows.Forms.RichTextBox();
            this.btn_Save_File = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_Open_File = new System.Windows.Forms.Button();
            this.btn_RUN_Auto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Phần_trăm = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tick_Ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_JOG.SuspendLayout();
            this.groupBox_Error_Code.SuspendLayout();
            this.groupBox_Nội_Suy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.Lime;
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(48, 134);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(160, 52);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // pictureBox_tick_Ok
            // 
            this.pictureBox_tick_Ok.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_tick_Ok.Image")));
            this.pictureBox_tick_Ok.Location = new System.Drawing.Point(214, 134);
            this.pictureBox_tick_Ok.Name = "pictureBox_tick_Ok";
            this.pictureBox_tick_Ok.Size = new System.Drawing.Size(65, 52);
            this.pictureBox_tick_Ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_tick_Ok.TabIndex = 8;
            this.pictureBox_tick_Ok.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Logo_trường
            // 
            this.lbl_Logo_trường.AutoSize = true;
            this.lbl_Logo_trường.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo_trường.Location = new System.Drawing.Point(755, 31);
            this.lbl_Logo_trường.Name = "lbl_Logo_trường";
            this.lbl_Logo_trường.Size = new System.Drawing.Size(427, 32);
            this.lbl_Logo_trường.TabIndex = 10;
            this.lbl_Logo_trường.Text = "ĐẠI HỌC BÁCH KHOA HÀ NỘI";
            // 
            // groupBox_JOG
            // 
            this.groupBox_JOG.Controls.Add(this.label9);
            this.groupBox_JOG.Controls.Add(this.label8);
            this.groupBox_JOG.Controls.Add(this.label7);
            this.groupBox_JOG.Controls.Add(this.label5);
            this.groupBox_JOG.Controls.Add(this.label4);
            this.groupBox_JOG.Controls.Add(this.label3);
            this.groupBox_JOG.Controls.Add(this.lbl_Position);
            this.groupBox_JOG.Controls.Add(this.txt_Jog_SpeedZ);
            this.groupBox_JOG.Controls.Add(this.txt_Jog_SpeedY);
            this.groupBox_JOG.Controls.Add(this.txt_Jog_SpeedX);
            this.groupBox_JOG.Controls.Add(this.lbl_Jog_SpeedZ);
            this.groupBox_JOG.Controls.Add(this.lbl_Jog_SpeedY);
            this.groupBox_JOG.Controls.Add(this.lbl_Jog_SpeedX);
            this.groupBox_JOG.Controls.Add(this.txt_Z_Position);
            this.groupBox_JOG.Controls.Add(this.txt_Y_Position);
            this.groupBox_JOG.Controls.Add(this.txt_X_Position);
            this.groupBox_JOG.Controls.Add(this.btn_JOG_Z_sub);
            this.groupBox_JOG.Controls.Add(this.btn_JOG_Y_sub);
            this.groupBox_JOG.Controls.Add(this.btn_JOG_X_sub);
            this.groupBox_JOG.Controls.Add(this.btn_JOG_Z_add);
            this.groupBox_JOG.Controls.Add(this.btn_JOG_Y_add);
            this.groupBox_JOG.Controls.Add(this.btn_Jog_X_add);
            this.groupBox_JOG.Controls.Add(this.lbl_Axis_Z);
            this.groupBox_JOG.Controls.Add(this.lbl_Axis_Y);
            this.groupBox_JOG.Controls.Add(this.lbl_Axis_X);
            this.groupBox_JOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_JOG.Location = new System.Drawing.Point(48, 290);
            this.groupBox_JOG.Name = "groupBox_JOG";
            this.groupBox_JOG.Size = new System.Drawing.Size(609, 389);
            this.groupBox_JOG.TabIndex = 11;
            this.groupBox_JOG.TabStop = false;
            this.groupBox_JOG.Text = "JOG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(474, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "(mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "(mm)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "(mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "(mm/phút)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "(mm/phút)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "(mm/phút)";
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.Location = new System.Drawing.Point(341, 19);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(108, 29);
            this.lbl_Position.TabIndex = 18;
            this.lbl_Position.Text = "Position";
            // 
            // txt_Jog_SpeedZ
            // 
            this.txt_Jog_SpeedZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Jog_SpeedZ.Location = new System.Drawing.Point(320, 296);
            this.txt_Jog_SpeedZ.Name = "txt_Jog_SpeedZ";
            this.txt_Jog_SpeedZ.Size = new System.Drawing.Size(148, 38);
            this.txt_Jog_SpeedZ.TabIndex = 17;
            this.txt_Jog_SpeedZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Jog_SpeedZ.TextChanged += new System.EventHandler(this.txt_Jog_SpeedZ_TextChanged);
            // 
            // txt_Jog_SpeedY
            // 
            this.txt_Jog_SpeedY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Jog_SpeedY.Location = new System.Drawing.Point(320, 252);
            this.txt_Jog_SpeedY.Name = "txt_Jog_SpeedY";
            this.txt_Jog_SpeedY.Size = new System.Drawing.Size(148, 38);
            this.txt_Jog_SpeedY.TabIndex = 16;
            this.txt_Jog_SpeedY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Jog_SpeedY.TextChanged += new System.EventHandler(this.txt_Jog_SpeedY_TextChanged);
            // 
            // txt_Jog_SpeedX
            // 
            this.txt_Jog_SpeedX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Jog_SpeedX.Location = new System.Drawing.Point(320, 208);
            this.txt_Jog_SpeedX.Name = "txt_Jog_SpeedX";
            this.txt_Jog_SpeedX.Size = new System.Drawing.Size(148, 38);
            this.txt_Jog_SpeedX.TabIndex = 15;
            this.txt_Jog_SpeedX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Jog_SpeedX.TextChanged += new System.EventHandler(this.txt_Jog_SpeedX_TextChanged);
            // 
            // lbl_Jog_SpeedZ
            // 
            this.lbl_Jog_SpeedZ.AutoSize = true;
            this.lbl_Jog_SpeedZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jog_SpeedZ.Location = new System.Drawing.Point(133, 303);
            this.lbl_Jog_SpeedZ.Name = "lbl_Jog_SpeedZ";
            this.lbl_Jog_SpeedZ.Size = new System.Drawing.Size(157, 25);
            this.lbl_Jog_SpeedZ.TabIndex = 14;
            this.lbl_Jog_SpeedZ.Text = "JOG_Speed_Z";
            // 
            // lbl_Jog_SpeedY
            // 
            this.lbl_Jog_SpeedY.AutoSize = true;
            this.lbl_Jog_SpeedY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jog_SpeedY.Location = new System.Drawing.Point(132, 261);
            this.lbl_Jog_SpeedY.Name = "lbl_Jog_SpeedY";
            this.lbl_Jog_SpeedY.Size = new System.Drawing.Size(158, 25);
            this.lbl_Jog_SpeedY.TabIndex = 13;
            this.lbl_Jog_SpeedY.Text = "JOG_Speed_Y";
            // 
            // lbl_Jog_SpeedX
            // 
            this.lbl_Jog_SpeedX.AutoSize = true;
            this.lbl_Jog_SpeedX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jog_SpeedX.Location = new System.Drawing.Point(132, 213);
            this.lbl_Jog_SpeedX.Name = "lbl_Jog_SpeedX";
            this.lbl_Jog_SpeedX.Size = new System.Drawing.Size(159, 25);
            this.lbl_Jog_SpeedX.TabIndex = 12;
            this.lbl_Jog_SpeedX.Text = "JOG_Speed_X";
            // 
            // txt_Z_Position
            // 
            this.txt_Z_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Z_Position.Location = new System.Drawing.Point(320, 147);
            this.txt_Z_Position.Name = "txt_Z_Position";
            this.txt_Z_Position.ReadOnly = true;
            this.txt_Z_Position.Size = new System.Drawing.Size(148, 38);
            this.txt_Z_Position.TabIndex = 11;
            this.txt_Z_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Y_Position
            // 
            this.txt_Y_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y_Position.Location = new System.Drawing.Point(320, 103);
            this.txt_Y_Position.Name = "txt_Y_Position";
            this.txt_Y_Position.ReadOnly = true;
            this.txt_Y_Position.Size = new System.Drawing.Size(148, 38);
            this.txt_Y_Position.TabIndex = 10;
            this.txt_Y_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_X_Position
            // 
            this.txt_X_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X_Position.Location = new System.Drawing.Point(320, 51);
            this.txt_X_Position.Name = "txt_X_Position";
            this.txt_X_Position.ReadOnly = true;
            this.txt_X_Position.Size = new System.Drawing.Size(148, 38);
            this.txt_X_Position.TabIndex = 9;
            this.txt_X_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_JOG_Z_sub
            // 
            this.btn_JOG_Z_sub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_JOG_Z_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JOG_Z_sub.Location = new System.Drawing.Point(31, 147);
            this.btn_JOG_Z_sub.Name = "btn_JOG_Z_sub";
            this.btn_JOG_Z_sub.Size = new System.Drawing.Size(99, 42);
            this.btn_JOG_Z_sub.TabIndex = 8;
            this.btn_JOG_Z_sub.Text = "-";
            this.btn_JOG_Z_sub.UseVisualStyleBackColor = true;
            this.btn_JOG_Z_sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Z_sub_MouseDown);
            this.btn_JOG_Z_sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Z_sub_MouseUp);
            // 
            // btn_JOG_Y_sub
            // 
            this.btn_JOG_Y_sub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_JOG_Y_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JOG_Y_sub.Location = new System.Drawing.Point(31, 97);
            this.btn_JOG_Y_sub.Name = "btn_JOG_Y_sub";
            this.btn_JOG_Y_sub.Size = new System.Drawing.Size(99, 42);
            this.btn_JOG_Y_sub.TabIndex = 7;
            this.btn_JOG_Y_sub.Text = "-";
            this.btn_JOG_Y_sub.UseVisualStyleBackColor = true;
            this.btn_JOG_Y_sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Y_sub_MouseDown);
            this.btn_JOG_Y_sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Y_sub_MouseUp);
            // 
            // btn_JOG_X_sub
            // 
            this.btn_JOG_X_sub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_JOG_X_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JOG_X_sub.Location = new System.Drawing.Point(31, 51);
            this.btn_JOG_X_sub.Name = "btn_JOG_X_sub";
            this.btn_JOG_X_sub.Size = new System.Drawing.Size(99, 42);
            this.btn_JOG_X_sub.TabIndex = 6;
            this.btn_JOG_X_sub.Text = "-";
            this.btn_JOG_X_sub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_JOG_X_sub.UseVisualStyleBackColor = true;
            this.btn_JOG_X_sub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_X_sub_MouseDown);
            this.btn_JOG_X_sub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_X_sub_MouseUp);
            // 
            // btn_JOG_Z_add
            // 
            this.btn_JOG_Z_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_JOG_Z_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JOG_Z_add.Location = new System.Drawing.Point(192, 145);
            this.btn_JOG_Z_add.Name = "btn_JOG_Z_add";
            this.btn_JOG_Z_add.Size = new System.Drawing.Size(99, 42);
            this.btn_JOG_Z_add.TabIndex = 5;
            this.btn_JOG_Z_add.Text = "+";
            this.btn_JOG_Z_add.UseVisualStyleBackColor = true;
            this.btn_JOG_Z_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Z_add_MouseDown);
            this.btn_JOG_Z_add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Z_add_MouseUp);
            // 
            // btn_JOG_Y_add
            // 
            this.btn_JOG_Y_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_JOG_Y_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JOG_Y_add.Location = new System.Drawing.Point(192, 100);
            this.btn_JOG_Y_add.Name = "btn_JOG_Y_add";
            this.btn_JOG_Y_add.Size = new System.Drawing.Size(99, 42);
            this.btn_JOG_Y_add.TabIndex = 4;
            this.btn_JOG_Y_add.Text = "+";
            this.btn_JOG_Y_add.UseVisualStyleBackColor = true;
            this.btn_JOG_Y_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Y_add_MouseDown);
            this.btn_JOG_Y_add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOG_Y_add_MouseUp);
            // 
            // btn_Jog_X_add
            // 
            this.btn_Jog_X_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Jog_X_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jog_X_add.Location = new System.Drawing.Point(192, 51);
            this.btn_Jog_X_add.Name = "btn_Jog_X_add";
            this.btn_Jog_X_add.Size = new System.Drawing.Size(99, 42);
            this.btn_Jog_X_add.TabIndex = 3;
            this.btn_Jog_X_add.Text = "+";
            this.btn_Jog_X_add.UseVisualStyleBackColor = true;
            this.btn_Jog_X_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Jog_X_add_MouseDown);
            this.btn_Jog_X_add.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Jog_X_add_MouseUp);
            // 
            // lbl_Axis_Z
            // 
            this.lbl_Axis_Z.AutoSize = true;
            this.lbl_Axis_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Axis_Z.Location = new System.Drawing.Point(149, 157);
            this.lbl_Axis_Z.Name = "lbl_Axis_Z";
            this.lbl_Axis_Z.Size = new System.Drawing.Size(25, 25);
            this.lbl_Axis_Z.TabIndex = 2;
            this.lbl_Axis_Z.Text = "Z";
            // 
            // lbl_Axis_Y
            // 
            this.lbl_Axis_Y.AutoSize = true;
            this.lbl_Axis_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Axis_Y.Location = new System.Drawing.Point(148, 107);
            this.lbl_Axis_Y.Name = "lbl_Axis_Y";
            this.lbl_Axis_Y.Size = new System.Drawing.Size(26, 25);
            this.lbl_Axis_Y.TabIndex = 1;
            this.lbl_Axis_Y.Text = "Y";
            // 
            // lbl_Axis_X
            // 
            this.lbl_Axis_X.AutoSize = true;
            this.lbl_Axis_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Axis_X.Location = new System.Drawing.Point(147, 62);
            this.lbl_Axis_X.Name = "lbl_Axis_X";
            this.lbl_Axis_X.Size = new System.Drawing.Size(27, 25);
            this.lbl_Axis_X.TabIndex = 0;
            this.lbl_Axis_X.Text = "X";
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Lime;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(247, 694);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(170, 51);
            this.btn_Home.TabIndex = 12;
            this.btn_Home.Text = "HOME";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Home_MouseDown);
            this.btn_Home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Home_MouseUp);
            // 
            // btn_Reset_Error
            // 
            this.btn_Reset_Error.BackColor = System.Drawing.Color.Yellow;
            this.btn_Reset_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset_Error.Location = new System.Drawing.Point(423, 694);
            this.btn_Reset_Error.Name = "btn_Reset_Error";
            this.btn_Reset_Error.Size = new System.Drawing.Size(234, 51);
            this.btn_Reset_Error.TabIndex = 13;
            this.btn_Reset_Error.Text = "RESET ERROR";
            this.btn_Reset_Error.UseVisualStyleBackColor = false;
            this.btn_Reset_Error.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Reset_Error_MouseDown);
            this.btn_Reset_Error.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Reset_Error_MouseUp);
            // 
            // btn_Thoát
            // 
            this.btn_Thoát.BackColor = System.Drawing.Color.Cyan;
            this.btn_Thoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoát.Location = new System.Drawing.Point(1779, 898);
            this.btn_Thoát.Name = "btn_Thoát";
            this.btn_Thoát.Size = new System.Drawing.Size(208, 62);
            this.btn_Thoát.TabIndex = 14;
            this.btn_Thoát.Text = "EXIT";
            this.btn_Thoát.UseVisualStyleBackColor = false;
            this.btn_Thoát.Click += new System.EventHandler(this.btn_Thoát_Click);
            // 
            // btn_find_Home
            // 
            this.btn_find_Home.BackColor = System.Drawing.Color.Lime;
            this.btn_find_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find_Home.Location = new System.Drawing.Point(48, 694);
            this.btn_find_Home.Name = "btn_find_Home";
            this.btn_find_Home.Size = new System.Drawing.Size(193, 51);
            this.btn_find_Home.TabIndex = 15;
            this.btn_find_Home.Text = "FIND HOME";
            this.btn_find_Home.UseVisualStyleBackColor = false;
            this.btn_find_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_find_Home_MouseDown);
            this.btn_find_Home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_find_Home_MouseUp);
            // 
            // btn_On_Off
            // 
            this.btn_On_Off.BackColor = System.Drawing.Color.Lime;
            this.btn_On_Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_On_Off.Location = new System.Drawing.Point(47, 205);
            this.btn_On_Off.Name = "btn_On_Off";
            this.btn_On_Off.Size = new System.Drawing.Size(160, 52);
            this.btn_On_Off.TabIndex = 16;
            this.btn_On_Off.Text = "ON";
            this.btn_On_Off.UseVisualStyleBackColor = false;
            this.btn_On_Off.Click += new System.EventHandler(this.btn_On_Off_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(216, 205);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(160, 52);
            this.btn_Stop.TabIndex = 17;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Stop_MouseDown);
            this.btn_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Stop_MouseUp);
            // 
            // groupBox_Error_Code
            // 
            this.groupBox_Error_Code.Controls.Add(this.lbl_Error_Code_Axis3);
            this.groupBox_Error_Code.Controls.Add(this.lbl_Error_Code_Axis2);
            this.groupBox_Error_Code.Controls.Add(this.lbl_Error_Code_Axis1);
            this.groupBox_Error_Code.Controls.Add(this.txt_Error_Code_Axis3);
            this.groupBox_Error_Code.Controls.Add(this.txt_Error_Code_Axis2);
            this.groupBox_Error_Code.Controls.Add(this.txt_Error_Code_Axis1);
            this.groupBox_Error_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Error_Code.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_Error_Code.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox_Error_Code.Location = new System.Drawing.Point(1108, 138);
            this.groupBox_Error_Code.Name = "groupBox_Error_Code";
            this.groupBox_Error_Code.Size = new System.Drawing.Size(262, 139);
            this.groupBox_Error_Code.TabIndex = 18;
            this.groupBox_Error_Code.TabStop = false;
            this.groupBox_Error_Code.Text = "ERROR CODE";
            // 
            // lbl_Error_Code_Axis3
            // 
            this.lbl_Error_Code_Axis3.AutoSize = true;
            this.lbl_Error_Code_Axis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Code_Axis3.Location = new System.Drawing.Point(37, 98);
            this.lbl_Error_Code_Axis3.Name = "lbl_Error_Code_Axis3";
            this.lbl_Error_Code_Axis3.Size = new System.Drawing.Size(65, 22);
            this.lbl_Error_Code_Axis3.TabIndex = 22;
            this.lbl_Error_Code_Axis3.Text = "Axis 3";
            // 
            // lbl_Error_Code_Axis2
            // 
            this.lbl_Error_Code_Axis2.AutoSize = true;
            this.lbl_Error_Code_Axis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Code_Axis2.Location = new System.Drawing.Point(37, 64);
            this.lbl_Error_Code_Axis2.Name = "lbl_Error_Code_Axis2";
            this.lbl_Error_Code_Axis2.Size = new System.Drawing.Size(65, 22);
            this.lbl_Error_Code_Axis2.TabIndex = 21;
            this.lbl_Error_Code_Axis2.Text = "Axis 2";
            // 
            // lbl_Error_Code_Axis1
            // 
            this.lbl_Error_Code_Axis1.AutoSize = true;
            this.lbl_Error_Code_Axis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Code_Axis1.Location = new System.Drawing.Point(37, 27);
            this.lbl_Error_Code_Axis1.Name = "lbl_Error_Code_Axis1";
            this.lbl_Error_Code_Axis1.Size = new System.Drawing.Size(65, 22);
            this.lbl_Error_Code_Axis1.TabIndex = 18;
            this.lbl_Error_Code_Axis1.Text = "Axis 1";
            // 
            // txt_Error_Code_Axis3
            // 
            this.txt_Error_Code_Axis3.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Error_Code_Axis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Error_Code_Axis3.ForeColor = System.Drawing.Color.Red;
            this.txt_Error_Code_Axis3.Location = new System.Drawing.Point(132, 92);
            this.txt_Error_Code_Axis3.Name = "txt_Error_Code_Axis3";
            this.txt_Error_Code_Axis3.ReadOnly = true;
            this.txt_Error_Code_Axis3.Size = new System.Drawing.Size(99, 28);
            this.txt_Error_Code_Axis3.TabIndex = 20;
            this.txt_Error_Code_Axis3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Error_Code_Axis3.Click += new System.EventHandler(this.txt_Error_Code_Axis3_Click);
            // 
            // txt_Error_Code_Axis2
            // 
            this.txt_Error_Code_Axis2.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Error_Code_Axis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Error_Code_Axis2.ForeColor = System.Drawing.Color.Red;
            this.txt_Error_Code_Axis2.Location = new System.Drawing.Point(132, 58);
            this.txt_Error_Code_Axis2.Name = "txt_Error_Code_Axis2";
            this.txt_Error_Code_Axis2.ReadOnly = true;
            this.txt_Error_Code_Axis2.Size = new System.Drawing.Size(99, 28);
            this.txt_Error_Code_Axis2.TabIndex = 19;
            this.txt_Error_Code_Axis2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Error_Code_Axis2.Click += new System.EventHandler(this.txt_Error_Code_Axis2_Click);
            // 
            // txt_Error_Code_Axis1
            // 
            this.txt_Error_Code_Axis1.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Error_Code_Axis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Error_Code_Axis1.ForeColor = System.Drawing.Color.Red;
            this.txt_Error_Code_Axis1.Location = new System.Drawing.Point(132, 21);
            this.txt_Error_Code_Axis1.Name = "txt_Error_Code_Axis1";
            this.txt_Error_Code_Axis1.ReadOnly = true;
            this.txt_Error_Code_Axis1.Size = new System.Drawing.Size(99, 28);
            this.txt_Error_Code_Axis1.TabIndex = 18;
            this.txt_Error_Code_Axis1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Error_Code_Axis1.Click += new System.EventHandler(this.txt_Error_Code_Axis1_Click);
            // 
            // groupBox_Nội_Suy
            // 
            this.groupBox_Nội_Suy.Controls.Add(this.label17);
            this.groupBox_Nội_Suy.Controls.Add(this.label18);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_Z_up);
            this.groupBox_Nội_Suy.Controls.Add(this.btn_END_nội_suy);
            this.groupBox_Nội_Suy.Controls.Add(this.label16);
            this.groupBox_Nội_Suy.Controls.Add(this.label14);
            this.groupBox_Nội_Suy.Controls.Add(this.label15);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_SpeedZ_nội_suy);
            this.groupBox_Nội_Suy.Controls.Add(this.label13);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_Toa_độ_Z_nội_suy);
            this.groupBox_Nội_Suy.Controls.Add(this.label12);
            this.groupBox_Nội_Suy.Controls.Add(this.label11);
            this.groupBox_Nội_Suy.Controls.Add(this.label10);
            this.groupBox_Nội_Suy.Controls.Add(this.label6);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_Speed_point1_to_point2);
            this.groupBox_Nội_Suy.Controls.Add(this.btn_RUN);
            this.groupBox_Nội_Suy.Controls.Add(this.btn_Circle);
            this.groupBox_Nội_Suy.Controls.Add(this.btn_Line);
            this.groupBox_Nội_Suy.Controls.Add(this.lbl_Điểm_trung_gian_cung_tròn);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_Arc_Adress_Y);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_Arc_Adress_X);
            this.groupBox_Nội_Suy.Controls.Add(this.lbl_P2);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_P2_Y);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_P2_X);
            this.groupBox_Nội_Suy.Controls.Add(this.label1);
            this.groupBox_Nội_Suy.Controls.Add(this.lbl_P1);
            this.groupBox_Nội_Suy.Controls.Add(this.label2);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_P1_Y);
            this.groupBox_Nội_Suy.Controls.Add(this.txt_P1_X);
            this.groupBox_Nội_Suy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Nội_Suy.Location = new System.Drawing.Point(685, 290);
            this.groupBox_Nội_Suy.Name = "groupBox_Nội_Suy";
            this.groupBox_Nội_Suy.Size = new System.Drawing.Size(685, 389);
            this.groupBox_Nội_Suy.TabIndex = 18;
            this.groupBox_Nội_Suy.TabStop = false;
            this.groupBox_Nội_Suy.Text = "INTERPOLATION";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(534, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 25);
            this.label17.TabIndex = 47;
            this.label17.Text = "(mm)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(278, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 29);
            this.label18.TabIndex = 46;
            this.label18.Text = "Z UP";
            // 
            // txt_Z_up
            // 
            this.txt_Z_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Z_up.Location = new System.Drawing.Point(371, 170);
            this.txt_Z_up.Name = "txt_Z_up";
            this.txt_Z_up.Size = new System.Drawing.Size(148, 38);
            this.txt_Z_up.TabIndex = 45;
            this.txt_Z_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Z_up.TextChanged += new System.EventHandler(this.txt_Z_up_TextChanged);
            // 
            // btn_END_nội_suy
            // 
            this.btn_END_nội_suy.BackColor = System.Drawing.Color.Lime;
            this.btn_END_nội_suy.Location = new System.Drawing.Point(62, 318);
            this.btn_END_nội_suy.Name = "btn_END_nội_suy";
            this.btn_END_nội_suy.Size = new System.Drawing.Size(148, 46);
            this.btn_END_nội_suy.TabIndex = 44;
            this.btn_END_nội_suy.Text = "END";
            this.btn_END_nội_suy.UseVisualStyleBackColor = false;
            this.btn_END_nội_suy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_END_nội_suy_MouseDown);
            this.btn_END_nội_suy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_END_nội_suy_MouseUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(534, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "(mm)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(227, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 29);
            this.label14.TabIndex = 41;
            this.label14.Text = "SPEED Z";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(534, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 25);
            this.label15.TabIndex = 39;
            this.label15.Text = "(mm/phút)";
            // 
            // txt_SpeedZ_nội_suy
            // 
            this.txt_SpeedZ_nội_suy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SpeedZ_nội_suy.Location = new System.Drawing.Point(371, 320);
            this.txt_SpeedZ_nội_suy.Name = "txt_SpeedZ_nội_suy";
            this.txt_SpeedZ_nội_suy.Size = new System.Drawing.Size(148, 38);
            this.txt_SpeedZ_nội_suy.TabIndex = 40;
            this.txt_SpeedZ_nội_suy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SpeedZ_nội_suy.TextChanged += new System.EventHandler(this.txt_SpeedZ_nội_suy_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(233, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 29);
            this.label13.TabIndex = 38;
            this.label13.Text = "Z DOWN";
            // 
            // txt_Toa_độ_Z_nội_suy
            // 
            this.txt_Toa_độ_Z_nội_suy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Toa_độ_Z_nội_suy.Location = new System.Drawing.Point(371, 222);
            this.txt_Toa_độ_Z_nội_suy.Name = "txt_Toa_độ_Z_nội_suy";
            this.txt_Toa_độ_Z_nội_suy.Size = new System.Drawing.Size(148, 38);
            this.txt_Toa_độ_Z_nội_suy.TabIndex = 36;
            this.txt_Toa_độ_Z_nội_suy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Toa_độ_Z_nội_suy.TextChanged += new System.EventHandler(this.txt_Toa_độ_Z_nội_suy_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "SPEED X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(534, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "(mm)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(534, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "(mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(534, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "(mm/phút)";
            // 
            // txt_Speed_point1_to_point2
            // 
            this.txt_Speed_point1_to_point2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Speed_point1_to_point2.Location = new System.Drawing.Point(371, 274);
            this.txt_Speed_point1_to_point2.Name = "txt_Speed_point1_to_point2";
            this.txt_Speed_point1_to_point2.Size = new System.Drawing.Size(148, 38);
            this.txt_Speed_point1_to_point2.TabIndex = 32;
            this.txt_Speed_point1_to_point2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Speed_point1_to_point2.TextChanged += new System.EventHandler(this.txt_Speed_point1_to_point2_TextChanged);
            // 
            // btn_RUN
            // 
            this.btn_RUN.BackColor = System.Drawing.Color.Lime;
            this.btn_RUN.Location = new System.Drawing.Point(62, 266);
            this.btn_RUN.Name = "btn_RUN";
            this.btn_RUN.Size = new System.Drawing.Size(148, 46);
            this.btn_RUN.TabIndex = 28;
            this.btn_RUN.Text = "RUN";
            this.btn_RUN.UseVisualStyleBackColor = false;
            this.btn_RUN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_RUN_MouseDown);
            this.btn_RUN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_RUN_MouseUp);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.Color.Red;
            this.btn_Circle.Location = new System.Drawing.Point(62, 214);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(148, 46);
            this.btn_Circle.TabIndex = 27;
            this.btn_Circle.Text = "CIRCLE";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.BackColor = System.Drawing.Color.Red;
            this.btn_Line.Location = new System.Drawing.Point(62, 162);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(148, 46);
            this.btn_Line.TabIndex = 26;
            this.btn_Line.Text = "LINE";
            this.btn_Line.UseVisualStyleBackColor = false;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // lbl_Điểm_trung_gian_cung_tròn
            // 
            this.lbl_Điểm_trung_gian_cung_tròn.AutoSize = true;
            this.lbl_Điểm_trung_gian_cung_tròn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Điểm_trung_gian_cung_tròn.Location = new System.Drawing.Point(368, 23);
            this.lbl_Điểm_trung_gian_cung_tròn.Name = "lbl_Điểm_trung_gian_cung_tròn";
            this.lbl_Điểm_trung_gian_cung_tròn.Size = new System.Drawing.Size(154, 29);
            this.lbl_Điểm_trung_gian_cung_tròn.TabIndex = 25;
            this.lbl_Điểm_trung_gian_cung_tròn.Text = "Arc Address";
            // 
            // txt_Arc_Adress_Y
            // 
            this.txt_Arc_Adress_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Arc_Adress_Y.Location = new System.Drawing.Point(371, 105);
            this.txt_Arc_Adress_Y.Name = "txt_Arc_Adress_Y";
            this.txt_Arc_Adress_Y.Size = new System.Drawing.Size(148, 38);
            this.txt_Arc_Adress_Y.TabIndex = 24;
            this.txt_Arc_Adress_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Arc_Adress_Y.TextChanged += new System.EventHandler(this.txt_Arc_Adress_Y_TextChanged);
            // 
            // txt_Arc_Adress_X
            // 
            this.txt_Arc_Adress_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Arc_Adress_X.Location = new System.Drawing.Point(371, 57);
            this.txt_Arc_Adress_X.Name = "txt_Arc_Adress_X";
            this.txt_Arc_Adress_X.Size = new System.Drawing.Size(148, 38);
            this.txt_Arc_Adress_X.TabIndex = 23;
            this.txt_Arc_Adress_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Arc_Adress_X.TextChanged += new System.EventHandler(this.txt_Arc_Adress_X_TextChanged);
            // 
            // lbl_P2
            // 
            this.lbl_P2.AutoSize = true;
            this.lbl_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P2.Location = new System.Drawing.Point(269, 23);
            this.lbl_P2.Name = "lbl_P2";
            this.lbl_P2.Size = new System.Drawing.Size(44, 29);
            this.lbl_P2.TabIndex = 22;
            this.lbl_P2.Text = "P2";
            // 
            // txt_P2_Y
            // 
            this.txt_P2_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P2_Y.Location = new System.Drawing.Point(217, 105);
            this.txt_P2_Y.Name = "txt_P2_Y";
            this.txt_P2_Y.Size = new System.Drawing.Size(148, 38);
            this.txt_P2_Y.TabIndex = 21;
            this.txt_P2_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_P2_Y.TextChanged += new System.EventHandler(this.txt_P2_Y_TextChanged);
            // 
            // txt_P2_X
            // 
            this.txt_P2_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P2_X.Location = new System.Drawing.Point(217, 57);
            this.txt_P2_X.Name = "txt_P2_X";
            this.txt_P2_X.Size = new System.Drawing.Size(148, 38);
            this.txt_P2_X.TabIndex = 20;
            this.txt_P2_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_P2_X.TextChanged += new System.EventHandler(this.txt_P2_X_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Y";
            // 
            // lbl_P1
            // 
            this.lbl_P1.AutoSize = true;
            this.lbl_P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P1.Location = new System.Drawing.Point(114, 23);
            this.lbl_P1.Name = "lbl_P1";
            this.lbl_P1.Size = new System.Drawing.Size(44, 29);
            this.lbl_P1.TabIndex = 18;
            this.lbl_P1.Text = "P1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            // 
            // txt_P1_Y
            // 
            this.txt_P1_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P1_Y.Location = new System.Drawing.Point(62, 105);
            this.txt_P1_Y.Name = "txt_P1_Y";
            this.txt_P1_Y.Size = new System.Drawing.Size(148, 38);
            this.txt_P1_Y.TabIndex = 11;
            this.txt_P1_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_P1_Y.TextChanged += new System.EventHandler(this.txt_P1_Y_TextChanged);
            // 
            // txt_P1_X
            // 
            this.txt_P1_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P1_X.Location = new System.Drawing.Point(62, 57);
            this.txt_P1_X.Name = "txt_P1_X";
            this.txt_P1_X.Size = new System.Drawing.Size(148, 38);
            this.txt_P1_X.TabIndex = 10;
            this.txt_P1_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_P1_X.TextChanged += new System.EventHandler(this.txt_P1_X_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Đồng_hồ
            // 
            this.lbl_Đồng_hồ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Đồng_hồ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Đồng_hồ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Đồng_hồ.Location = new System.Drawing.Point(1111, 88);
            this.lbl_Đồng_hồ.Name = "lbl_Đồng_hồ";
            this.lbl_Đồng_hồ.Size = new System.Drawing.Size(259, 35);
            this.lbl_Đồng_hồ.TabIndex = 19;
            this.lbl_Đồng_hồ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Đồ_thị_tọa_độ_XY
            // 
            this.Đồ_thị_tọa_độ_XY.Location = new System.Drawing.Point(1395, 88);
            this.Đồ_thị_tọa_độ_XY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Đồ_thị_tọa_độ_XY.Name = "Đồ_thị_tọa_độ_XY";
            this.Đồ_thị_tọa_độ_XY.ScrollGrace = 0D;
            this.Đồ_thị_tọa_độ_XY.ScrollMaxX = 0D;
            this.Đồ_thị_tọa_độ_XY.ScrollMaxY = 0D;
            this.Đồ_thị_tọa_độ_XY.ScrollMaxY2 = 0D;
            this.Đồ_thị_tọa_độ_XY.ScrollMinX = 0D;
            this.Đồ_thị_tọa_độ_XY.ScrollMinY = 0D;
            this.Đồ_thị_tọa_độ_XY.ScrollMinY2 = 0D;
            this.Đồ_thị_tọa_độ_XY.Size = new System.Drawing.Size(592, 438);
            this.Đồ_thị_tọa_độ_XY.TabIndex = 20;
            this.Đồ_thị_tọa_độ_XY.UseExtendedPrintDialog = true;
            // 
            // rtbox_Nhập_code
            // 
            this.rtbox_Nhập_code.BackColor = System.Drawing.SystemColors.Window;
            this.rtbox_Nhập_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbox_Nhập_code.Location = new System.Drawing.Point(1392, 542);
            this.rtbox_Nhập_code.Name = "rtbox_Nhập_code";
            this.rtbox_Nhập_code.Size = new System.Drawing.Size(592, 308);
            this.rtbox_Nhập_code.TabIndex = 23;
            this.rtbox_Nhập_code.Text = "";
            // 
            // btn_Save_File
            // 
            this.btn_Save_File.BackColor = System.Drawing.Color.Lime;
            this.btn_Save_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_File.Location = new System.Drawing.Point(1238, 752);
            this.btn_Save_File.Name = "btn_Save_File";
            this.btn_Save_File.Size = new System.Drawing.Size(148, 46);
            this.btn_Save_File.TabIndex = 45;
            this.btn_Save_File.Text = "SAVE FILE";
            this.btn_Save_File.UseVisualStyleBackColor = false;
            this.btn_Save_File.Click += new System.EventHandler(this.btn_Save_File_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Open_File
            // 
            this.btn_Open_File.BackColor = System.Drawing.Color.Lime;
            this.btn_Open_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open_File.Location = new System.Drawing.Point(1238, 700);
            this.btn_Open_File.Name = "btn_Open_File";
            this.btn_Open_File.Size = new System.Drawing.Size(148, 46);
            this.btn_Open_File.TabIndex = 46;
            this.btn_Open_File.Text = "OPEN FILE";
            this.btn_Open_File.UseVisualStyleBackColor = false;
            this.btn_Open_File.Click += new System.EventHandler(this.btn_Open_File_Click);
            // 
            // btn_RUN_Auto
            // 
            this.btn_RUN_Auto.BackColor = System.Drawing.Color.Lime;
            this.btn_RUN_Auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RUN_Auto.Location = new System.Drawing.Point(1238, 804);
            this.btn_RUN_Auto.Name = "btn_RUN_Auto";
            this.btn_RUN_Auto.Size = new System.Drawing.Size(148, 46);
            this.btn_RUN_Auto.TabIndex = 47;
            this.btn_RUN_Auto.Text = "RUN AUTO";
            this.btn_RUN_Auto.UseVisualStyleBackColor = false;
            this.btn_RUN_Auto.Click += new System.EventHandler(this.btn_RUN_Auto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1013, 804);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 46);
            this.button1.TabIndex = 48;
            this.button1.Text = "DELETE GRAPH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1395, 856);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(592, 25);
            this.progressBar1.TabIndex = 49;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbl_Phần_trăm
            // 
            this.lbl_Phần_trăm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_Phần_trăm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phần_trăm.Location = new System.Drawing.Point(1395, 898);
            this.lbl_Phần_trăm.Name = "lbl_Phần_trăm";
            this.lbl_Phần_trăm.Size = new System.Drawing.Size(103, 32);
            this.lbl_Phần_trăm.TabIndex = 50;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Lime;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(1075, 752);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(148, 46);
            this.btn_Cancel.TabIndex = 51;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_Phần_trăm);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_RUN_Auto);
            this.Controls.Add(this.btn_Open_File);
            this.Controls.Add(this.btn_Save_File);
            this.Controls.Add(this.rtbox_Nhập_code);
            this.Controls.Add(this.Đồ_thị_tọa_độ_XY);
            this.Controls.Add(this.lbl_Đồng_hồ);
            this.Controls.Add(this.groupBox_Nội_Suy);
            this.Controls.Add(this.groupBox_Error_Code);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_On_Off);
            this.Controls.Add(this.btn_find_Home);
            this.Controls.Add(this.btn_Thoát);
            this.Controls.Add(this.btn_Reset_Error);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.groupBox_JOG);
            this.Controls.Add(this.lbl_Logo_trường);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_tick_Ok);
            this.Controls.Add(this.btn_Connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIAO DIỆN ĐIỀU KHIỂN - DESIGNED BY MBP TEAM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tick_Ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_JOG.ResumeLayout(false);
            this.groupBox_JOG.PerformLayout();
            this.groupBox_Error_Code.ResumeLayout(false);
            this.groupBox_Error_Code.PerformLayout();
            this.groupBox_Nội_Suy.ResumeLayout(false);
            this.groupBox_Nội_Suy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.PictureBox pictureBox_tick_Ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Logo_trường;
        private System.Windows.Forms.GroupBox groupBox_JOG;
        private System.Windows.Forms.Button btn_Jog_X_add;
        private System.Windows.Forms.Label lbl_Axis_Z;
        private System.Windows.Forms.Label lbl_Axis_Y;
        private System.Windows.Forms.Label lbl_Axis_X;
        private System.Windows.Forms.Button btn_JOG_Z_sub;
        private System.Windows.Forms.Button btn_JOG_Y_sub;
        private System.Windows.Forms.Button btn_JOG_X_sub;
        private System.Windows.Forms.Button btn_JOG_Z_add;
        private System.Windows.Forms.Button btn_JOG_Y_add;
        private System.Windows.Forms.TextBox txt_Z_Position;
        private System.Windows.Forms.TextBox txt_Y_Position;
        private System.Windows.Forms.TextBox txt_X_Position;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Reset_Error;
        private System.Windows.Forms.Button btn_Thoát;
        private System.Windows.Forms.Label lbl_Jog_SpeedX;
        private System.Windows.Forms.TextBox txt_Jog_SpeedZ;
        private System.Windows.Forms.TextBox txt_Jog_SpeedY;
        private System.Windows.Forms.TextBox txt_Jog_SpeedX;
        private System.Windows.Forms.Label lbl_Jog_SpeedZ;
        private System.Windows.Forms.Label lbl_Jog_SpeedY;
        private System.Windows.Forms.Button btn_find_Home;
        private System.Windows.Forms.Button btn_On_Off;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.GroupBox groupBox_Error_Code;
        private System.Windows.Forms.TextBox txt_Error_Code_Axis3;
        private System.Windows.Forms.TextBox txt_Error_Code_Axis2;
        private System.Windows.Forms.TextBox txt_Error_Code_Axis1;
        private System.Windows.Forms.Label lbl_Error_Code_Axis1;
        private System.Windows.Forms.Label lbl_Error_Code_Axis3;
        private System.Windows.Forms.Label lbl_Error_Code_Axis2;
        private System.Windows.Forms.GroupBox groupBox_Nội_Suy;
        private System.Windows.Forms.Label lbl_P1;
        private System.Windows.Forms.TextBox txt_P1_Y;
        private System.Windows.Forms.TextBox txt_P1_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_P2;
        private System.Windows.Forms.TextBox txt_P2_Y;
        private System.Windows.Forms.TextBox txt_P2_X;
        private System.Windows.Forms.Label lbl_Điểm_trung_gian_cung_tròn;
        private System.Windows.Forms.TextBox txt_Arc_Adress_Y;
        private System.Windows.Forms.TextBox txt_Arc_Adress_X;
        private System.Windows.Forms.Button btn_RUN;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.TextBox txt_Speed_point1_to_point2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Đồng_hồ;
        private System.Windows.Forms.Timer timer2;
        private ZedGraph.ZedGraphControl Đồ_thị_tọa_độ_XY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Toa_độ_Z_nội_suy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_SpeedZ_nội_suy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rtbox_Nhập_code;
        private System.Windows.Forms.Button btn_Save_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_Open_File;
        private System.Windows.Forms.Button btn_END_nội_suy;
        private System.Windows.Forms.Button btn_RUN_Auto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Z_up;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Phần_trăm;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

