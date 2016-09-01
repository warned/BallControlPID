namespace CircleGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPY = new System.Windows.Forms.Label();
            this.lblPX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVY = new System.Windows.Forms.Label();
            this.lblVX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAY = new System.Windows.Forms.Label();
            this.lblAX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFY = new System.Windows.Forms.TextBox();
            this.tbFX = new System.Windows.Forms.TextBox();
            this.cbProp = new System.Windows.Forms.CheckBox();
            this.cbInt = new System.Windows.Forms.CheckBox();
            this.cbDeriv = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpX = new System.Windows.Forms.Button();
            this.btnDnX = new System.Windows.Forms.Button();
            this.btnUpY = new System.Windows.Forms.Button();
            this.btnDnY = new System.Windows.Forms.Button();
            this.tbKp = new System.Windows.Forms.TextBox();
            this.tbKd = new System.Windows.Forms.TextBox();
            this.tbKi = new System.Windows.Forms.TextBox();
            this.tbSPx = new System.Windows.Forms.TextBox();
            this.tbSPy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFrict = new System.Windows.Forms.TextBox();
            this.lblFY = new System.Windows.Forms.Label();
            this.lblFX = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.gbBall = new System.Windows.Forms.GroupBox();
            this.cbColorFill = new System.Windows.Forms.ComboBox();
            this.tbMass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNoise = new System.Windows.Forms.Button();
            this.lblNoiseX = new System.Windows.Forms.Label();
            this.lblNoiseY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbBall.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 636);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrDraw
            // 
            this.tmrDraw.Interval = 10;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(14, 738);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(88, 712);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "P";
            // 
            // lblPY
            // 
            this.lblPY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPY.BackColor = System.Drawing.Color.Silver;
            this.lblPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPY.Location = new System.Drawing.Point(56, 769);
            this.lblPY.Name = "lblPY";
            this.lblPY.Size = new System.Drawing.Size(100, 26);
            this.lblPY.TabIndex = 1;
            this.lblPY.Text = "0";
            // 
            // lblPX
            // 
            this.lblPX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPX.BackColor = System.Drawing.Color.Silver;
            this.lblPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPX.Location = new System.Drawing.Point(56, 737);
            this.lblPX.Name = "lblPX";
            this.lblPX.Size = new System.Drawing.Size(100, 26);
            this.lblPX.TabIndex = 1;
            this.lblPX.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(14, 762);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(203, 712);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "V";
            // 
            // lblVY
            // 
            this.lblVY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVY.BackColor = System.Drawing.Color.Silver;
            this.lblVY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVY.Location = new System.Drawing.Point(162, 769);
            this.lblVY.Name = "lblVY";
            this.lblVY.Size = new System.Drawing.Size(100, 26);
            this.lblVY.TabIndex = 1;
            this.lblVY.Text = "0";
            // 
            // lblVX
            // 
            this.lblVX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVX.BackColor = System.Drawing.Color.Silver;
            this.lblVX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVX.Location = new System.Drawing.Point(162, 737);
            this.lblVX.Name = "lblVX";
            this.lblVX.Size = new System.Drawing.Size(100, 26);
            this.lblVX.TabIndex = 1;
            this.lblVX.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(305, 712);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "A";
            // 
            // lblAY
            // 
            this.lblAY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAY.BackColor = System.Drawing.Color.Silver;
            this.lblAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAY.Location = new System.Drawing.Point(268, 769);
            this.lblAY.Name = "lblAY";
            this.lblAY.Size = new System.Drawing.Size(100, 26);
            this.lblAY.TabIndex = 1;
            this.lblAY.Text = "0";
            // 
            // lblAX
            // 
            this.lblAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAX.BackColor = System.Drawing.Color.Silver;
            this.lblAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAX.Location = new System.Drawing.Point(268, 737);
            this.lblAX.Name = "lblAX";
            this.lblAX.Size = new System.Drawing.Size(100, 26);
            this.lblAX.TabIndex = 1;
            this.lblAX.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(411, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "F";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1484, 674);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbFY
            // 
            this.tbFY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFY.Location = new System.Drawing.Point(597, 769);
            this.tbFY.Name = "tbFY";
            this.tbFY.Size = new System.Drawing.Size(91, 26);
            this.tbFY.TabIndex = 1;
            this.tbFY.Text = "0";
            // 
            // tbFX
            // 
            this.tbFX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbFX.Location = new System.Drawing.Point(597, 737);
            this.tbFX.Name = "tbFX";
            this.tbFX.Size = new System.Drawing.Size(91, 26);
            this.tbFX.TabIndex = 1;
            this.tbFX.Text = "0";
            // 
            // cbProp
            // 
            this.cbProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbProp.AutoSize = true;
            this.cbProp.Location = new System.Drawing.Point(763, 731);
            this.cbProp.Name = "cbProp";
            this.cbProp.Size = new System.Drawing.Size(82, 17);
            this.cbProp.TabIndex = 4;
            this.cbProp.Text = "Proportional";
            this.cbProp.UseVisualStyleBackColor = true;
            this.cbProp.CheckedChanged += new System.EventHandler(this.cbProp_CheckedChanged);
            // 
            // cbInt
            // 
            this.cbInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbInt.AutoSize = true;
            this.cbInt.Location = new System.Drawing.Point(763, 759);
            this.cbInt.Name = "cbInt";
            this.cbInt.Size = new System.Drawing.Size(61, 17);
            this.cbInt.TabIndex = 4;
            this.cbInt.Text = "Integral";
            this.cbInt.UseVisualStyleBackColor = true;
            this.cbInt.CheckedChanged += new System.EventHandler(this.cbInt_CheckedChanged);
            // 
            // cbDeriv
            // 
            this.cbDeriv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDeriv.AutoSize = true;
            this.cbDeriv.Location = new System.Drawing.Point(763, 782);
            this.cbDeriv.Name = "cbDeriv";
            this.cbDeriv.Size = new System.Drawing.Size(74, 17);
            this.cbDeriv.TabIndex = 4;
            this.cbDeriv.Text = "Derivative";
            this.cbDeriv.UseVisualStyleBackColor = true;
            this.cbDeriv.CheckedChanged += new System.EventHandler(this.cbDeriv_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1430, 797);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(1349, 798);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpX
            // 
            this.btnUpX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpX.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.btnUpX.Location = new System.Drawing.Point(694, 737);
            this.btnUpX.Name = "btnUpX";
            this.btnUpX.Size = new System.Drawing.Size(34, 13);
            this.btnUpX.TabIndex = 6;
            this.btnUpX.Text = "▲";
            this.btnUpX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpX.UseVisualStyleBackColor = true;
            this.btnUpX.Click += new System.EventHandler(this.btnUpDn_Click);
            // 
            // btnDnX
            // 
            this.btnDnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.btnDnX.Location = new System.Drawing.Point(694, 750);
            this.btnDnX.Name = "btnDnX";
            this.btnDnX.Size = new System.Drawing.Size(34, 13);
            this.btnDnX.TabIndex = 6;
            this.btnDnX.Text = "▼";
            this.btnDnX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDnX.UseVisualStyleBackColor = true;
            this.btnDnX.Click += new System.EventHandler(this.btnUpDn_Click);
            // 
            // btnUpY
            // 
            this.btnUpY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpY.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.btnUpY.Location = new System.Drawing.Point(694, 769);
            this.btnUpY.Name = "btnUpY";
            this.btnUpY.Size = new System.Drawing.Size(34, 13);
            this.btnUpY.TabIndex = 6;
            this.btnUpY.Text = "▲";
            this.btnUpY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpY.UseVisualStyleBackColor = true;
            this.btnUpY.Click += new System.EventHandler(this.btnUpDn_Click);
            // 
            // btnDnY
            // 
            this.btnDnY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.btnDnY.Location = new System.Drawing.Point(694, 782);
            this.btnDnY.Name = "btnDnY";
            this.btnDnY.Size = new System.Drawing.Size(34, 13);
            this.btnDnY.TabIndex = 6;
            this.btnDnY.Text = "▼";
            this.btnDnY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDnY.UseVisualStyleBackColor = true;
            this.btnDnY.Click += new System.EventHandler(this.btnUpDn_Click);
            // 
            // tbKp
            // 
            this.tbKp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbKp.Location = new System.Drawing.Point(851, 733);
            this.tbKp.Name = "tbKp";
            this.tbKp.Size = new System.Drawing.Size(59, 20);
            this.tbKp.TabIndex = 7;
            this.tbKp.Text = "4";
            this.tbKp.Leave += new System.EventHandler(this.tbKp_Leave);
            // 
            // tbKd
            // 
            this.tbKd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbKd.Location = new System.Drawing.Point(851, 782);
            this.tbKd.Name = "tbKd";
            this.tbKd.Size = new System.Drawing.Size(59, 20);
            this.tbKd.TabIndex = 7;
            this.tbKd.Tag = "";
            this.tbKd.Text = "15";
            this.tbKd.TextChanged += new System.EventHandler(this.tbKd_TextChanged);
            // 
            // tbKi
            // 
            this.tbKi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbKi.Location = new System.Drawing.Point(851, 759);
            this.tbKi.Name = "tbKi";
            this.tbKi.Size = new System.Drawing.Size(59, 20);
            this.tbKi.TabIndex = 7;
            this.tbKi.Text = "0.5";
            this.tbKi.Leave += new System.EventHandler(this.tbKi_Leave);
            // 
            // tbSPx
            // 
            this.tbSPx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSPx.Location = new System.Drawing.Point(916, 733);
            this.tbSPx.Name = "tbSPx";
            this.tbSPx.Size = new System.Drawing.Size(59, 20);
            this.tbSPx.TabIndex = 7;
            this.tbSPx.Text = "0";
            this.tbSPx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSP_KeyPress);
            this.tbSPx.Leave += new System.EventHandler(this.tbSP_Leave);
            // 
            // tbSPy
            // 
            this.tbSPy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSPy.Location = new System.Drawing.Point(916, 759);
            this.tbSPy.Name = "tbSPy";
            this.tbSPy.Size = new System.Drawing.Size(59, 20);
            this.tbSPy.TabIndex = 7;
            this.tbSPy.Text = "0";
            this.tbSPy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSP_KeyPress);
            this.tbSPy.Leave += new System.EventHandler(this.tbSP_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(930, 707);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "SP";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(864, 706);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "K";
            // 
            // tbFrict
            // 
            this.tbFrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrict.Location = new System.Drawing.Point(981, 733);
            this.tbFrict.Name = "tbFrict";
            this.tbFrict.Size = new System.Drawing.Size(37, 20);
            this.tbFrict.TabIndex = 7;
            this.tbFrict.Text = "0";
            this.tbFrict.Leave += new System.EventHandler(this.tbFrict_Leave);
            // 
            // lblFY
            // 
            this.lblFY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFY.BackColor = System.Drawing.Color.Silver;
            this.lblFY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFY.Location = new System.Drawing.Point(374, 770);
            this.lblFY.Name = "lblFY";
            this.lblFY.Size = new System.Drawing.Size(100, 26);
            this.lblFY.TabIndex = 1;
            this.lblFY.Text = "0";
            // 
            // lblFX
            // 
            this.lblFX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFX.BackColor = System.Drawing.Color.Silver;
            this.lblFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFX.Location = new System.Drawing.Point(374, 738);
            this.lblFX.Name = "lblFX";
            this.lblFX.Size = new System.Drawing.Size(100, 26);
            this.lblFX.TabIndex = 1;
            this.lblFX.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(631, 707);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "OP";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(977, 707);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Frict";
            // 
            // tbSize
            // 
            this.tbSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSize.Location = new System.Drawing.Point(10, 54);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(37, 20);
            this.tbSize.TabIndex = 7;
            this.tbSize.Text = "10";
            this.tbSize.Leave += new System.EventHandler(this.tbSize_Leave);
            // 
            // gbBall
            // 
            this.gbBall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBall.Controls.Add(this.cbColorFill);
            this.gbBall.Controls.Add(this.tbMass);
            this.gbBall.Controls.Add(this.tbSize);
            this.gbBall.Controls.Add(this.label12);
            this.gbBall.Controls.Add(this.label10);
            this.gbBall.Location = new System.Drawing.Point(1351, 692);
            this.gbBall.Name = "gbBall";
            this.gbBall.Size = new System.Drawing.Size(145, 100);
            this.gbBall.TabIndex = 8;
            this.gbBall.TabStop = false;
            this.gbBall.Text = "Ball";
            // 
            // cbColorFill
            // 
            this.cbColorFill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbColorFill.FormattingEnabled = true;
            this.cbColorFill.Location = new System.Drawing.Point(92, 54);
            this.cbColorFill.Name = "cbColorFill";
            this.cbColorFill.Size = new System.Drawing.Size(47, 21);
            this.cbColorFill.TabIndex = 9;
            this.cbColorFill.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColorFill_DrawItem);
            this.cbColorFill.SelectedValueChanged += new System.EventHandler(this.cbColorFill_SelectedValueChanged);
            // 
            // tbMass
            // 
            this.tbMass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMass.Location = new System.Drawing.Point(49, 54);
            this.tbMass.Name = "tbMass";
            this.tbMass.Size = new System.Drawing.Size(37, 20);
            this.tbMass.TabIndex = 7;
            this.tbMass.Text = "1";
            this.tbMass.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.Location = new System.Drawing.Point(46, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mass";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(13, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Size";
            // 
            // btnNoise
            // 
            this.btnNoise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoise.Location = new System.Drawing.Point(1144, 725);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(75, 43);
            this.btnNoise.TabIndex = 9;
            this.btnNoise.Text = "Noise";
            this.btnNoise.UseVisualStyleBackColor = true;
            this.btnNoise.Click += new System.EventHandler(this.btnNoise_Click);
            // 
            // lblNoiseX
            // 
            this.lblNoiseX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoiseX.AutoSize = true;
            this.lblNoiseX.Location = new System.Drawing.Point(1225, 730);
            this.lblNoiseX.Name = "lblNoiseX";
            this.lblNoiseX.Size = new System.Drawing.Size(13, 13);
            this.lblNoiseX.TabIndex = 10;
            this.lblNoiseX.Text = "0";
            // 
            // lblNoiseY
            // 
            this.lblNoiseY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoiseY.AutoSize = true;
            this.lblNoiseY.Location = new System.Drawing.Point(1225, 753);
            this.lblNoiseY.Name = "lblNoiseY";
            this.lblNoiseY.Size = new System.Drawing.Size(13, 13);
            this.lblNoiseY.TabIndex = 10;
            this.lblNoiseY.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1508, 823);
            this.Controls.Add(this.lblNoiseY);
            this.Controls.Add(this.lblNoiseX);
            this.Controls.Add(this.btnNoise);
            this.Controls.Add(this.gbBall);
            this.Controls.Add(this.tbSPy);
            this.Controls.Add(this.tbKi);
            this.Controls.Add(this.tbKd);
            this.Controls.Add(this.tbFrict);
            this.Controls.Add(this.tbSPx);
            this.Controls.Add(this.tbKp);
            this.Controls.Add(this.btnDnY);
            this.Controls.Add(this.btnUpY);
            this.Controls.Add(this.btnDnX);
            this.Controls.Add(this.btnUpX);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDeriv);
            this.Controls.Add(this.cbInt);
            this.Controls.Add(this.cbProp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbFX);
            this.Controls.Add(this.lblFX);
            this.Controls.Add(this.lblAX);
            this.Controls.Add(this.lblVX);
            this.Controls.Add(this.lblFY);
            this.Controls.Add(this.tbFY);
            this.Controls.Add(this.lblAY);
            this.Controls.Add(this.lblPX);
            this.Controls.Add(this.lblVY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gbBall.ResumeLayout(false);
            this.gbBall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPY;
        private System.Windows.Forms.Label lblPX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVY;
        private System.Windows.Forms.Label lblVX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAY;
        private System.Windows.Forms.Label lblAX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbProp;
        private System.Windows.Forms.CheckBox cbInt;
        private System.Windows.Forms.CheckBox cbDeriv;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFY;
        private System.Windows.Forms.TextBox tbFX;
        private System.Windows.Forms.Button btnUpX;
        private System.Windows.Forms.Button btnDnX;
        private System.Windows.Forms.Button btnUpY;
        private System.Windows.Forms.Button btnDnY;
        private System.Windows.Forms.TextBox tbKp;
        private System.Windows.Forms.TextBox tbKd;
        private System.Windows.Forms.TextBox tbKi;
        private System.Windows.Forms.TextBox tbSPx;
        private System.Windows.Forms.TextBox tbSPy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFrict;
        private System.Windows.Forms.Label lblFY;
        private System.Windows.Forms.Label lblFX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.GroupBox gbBall;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbColorFill;
        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Label lblNoiseX;
        private System.Windows.Forms.Label lblNoiseY;
    }
}

