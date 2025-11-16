namespace ticTacToe
{
    partial class landingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pnLanding = new System.Windows.Forms.Panel();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.cbShowPW = new System.Windows.Forms.CheckBox();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lklbNewPW = new System.Windows.Forms.LinkLabel();
            this.lklbSignUpLoginPnl = new System.Windows.Forms.LinkLabel();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbUsernameOrE = new System.Windows.Forms.TextBox();
            this.btnLoginPnl = new System.Windows.Forms.Button();
            this.pnSignUp = new System.Windows.Forms.Panel();
            this.cbShowPW_SignUp = new System.Windows.Forms.CheckBox();
            this.btnSignUp_SignUpPn = new System.Windows.Forms.Button();
            this.lklbLogin_SignUpPn = new System.Windows.Forms.LinkLabel();
            this.tbConfirmPW = new System.Windows.Forms.TextBox();
            this.tbPW_SignUpPN = new System.Windows.Forms.TextBox();
            this.tbEmailSignUpPn = new System.Windows.Forms.TextBox();
            this.tbUsernameSignUpPn = new System.Windows.Forms.TextBox();
            this.lblConfirmPW = new System.Windows.Forms.Label();
            this.lblPWSignUpPn = new System.Windows.Forms.Label();
            this.lblEmailSignUpPn = new System.Windows.Forms.Label();
            this.lblUsernameSignUpPn = new System.Windows.Forms.Label();
            this.pnForgotPW = new System.Windows.Forms.Panel();
            this.lklbBackToLogin = new System.Windows.Forms.LinkLabel();
            this.btnSendCode_ForgotPn = new System.Windows.Forms.Button();
            this.tbEmailForgot = new System.Windows.Forms.TextBox();
            this.pnVerifyCode = new System.Windows.Forms.Panel();
            this.lklbResendCode = new System.Windows.Forms.LinkLabel();
            this.btnConfirmVC = new System.Windows.Forms.Button();
            this.tbVerificationCode = new System.Windows.Forms.TextBox();
            this.pnResetPW = new System.Windows.Forms.Panel();
            this.cbShowPW_ResetPW = new System.Windows.Forms.CheckBox();
            this.btnReset_ResetPWPn = new System.Windows.Forms.Button();
            this.tbConfirmNewPW = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPW = new System.Windows.Forms.Label();
            this.tbNewPW = new System.Windows.Forms.TextBox();
            this.lblNewPW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLanding.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.pnSignUp.SuspendLayout();
            this.pnForgotPW.SuspendLayout();
            this.pnVerifyCode.SuspendLayout();
            this.pnResetPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Move += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Red;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(200, 390);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(593, 390);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(127, 37);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.Move += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pnLanding
            // 
            this.pnLanding.Controls.Add(this.btnSignUp);
            this.pnLanding.Controls.Add(this.btnLogin);
            this.pnLanding.Controls.Add(this.pictureBox1);
            this.pnLanding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLanding.Location = new System.Drawing.Point(0, 0);
            this.pnLanding.Name = "pnLanding";
            this.pnLanding.Size = new System.Drawing.Size(918, 481);
            this.pnLanding.TabIndex = 3;
            // 
            // pnLogin
            // 
            this.pnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLogin.BackgroundImage")));
            this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogin.Controls.Add(this.cbShowPW);
            this.pnLogin.Controls.Add(this.lblPW);
            this.pnLogin.Controls.Add(this.lblUsername);
            this.pnLogin.Controls.Add(this.lklbNewPW);
            this.pnLogin.Controls.Add(this.lklbSignUpLoginPnl);
            this.pnLogin.Controls.Add(this.tbPW);
            this.pnLogin.Controls.Add(this.tbUsernameOrE);
            this.pnLogin.Controls.Add(this.btnLoginPnl);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(918, 481);
            this.pnLogin.TabIndex = 4;
            this.pnLogin.Visible = false;
            this.pnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.pnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogin_Paint);
            // 
            // cbShowPW
            // 
            this.cbShowPW.AutoSize = true;
            this.cbShowPW.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowPW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbShowPW.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbShowPW.Location = new System.Drawing.Point(692, 251);
            this.cbShowPW.Name = "cbShowPW";
            this.cbShowPW.Size = new System.Drawing.Size(73, 27);
            this.cbShowPW.TabIndex = 11;
            this.cbShowPW.Text = "show";
            this.cbShowPW.UseVisualStyleBackColor = false;
            this.cbShowPW.CheckedChanged += new System.EventHandler(this.cbShowPassWord_CheckedChanged);
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.Transparent;
            this.lblPW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPW.ForeColor = System.Drawing.Color.Tomato;
            this.lblPW.Location = new System.Drawing.Point(283, 219);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(91, 23);
            this.lblPW.TabIndex = 8;
            this.lblPW.Text = "password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUsername.Location = new System.Drawing.Point(283, 109);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(144, 23);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "username/email:";
            // 
            // lklbNewPW
            // 
            this.lklbNewPW.AutoSize = true;
            this.lklbNewPW.BackColor = System.Drawing.Color.Transparent;
            this.lklbNewPW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lklbNewPW.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lklbNewPW.Location = new System.Drawing.Point(507, 362);
            this.lklbNewPW.Name = "lklbNewPW";
            this.lklbNewPW.Size = new System.Drawing.Size(150, 23);
            this.lklbNewPW.TabIndex = 5;
            this.lklbNewPW.TabStop = true;
            this.lklbNewPW.Text = "forgot password?";
            this.lklbNewPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbNewPW_linkClicked);
            // 
            // lklbSignUpLoginPnl
            // 
            this.lklbSignUpLoginPnl.AutoSize = true;
            this.lklbSignUpLoginPnl.BackColor = System.Drawing.Color.Transparent;
            this.lklbSignUpLoginPnl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lklbSignUpLoginPnl.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lklbSignUpLoginPnl.Location = new System.Drawing.Point(271, 362);
            this.lklbSignUpLoginPnl.Name = "lklbSignUpLoginPnl";
            this.lklbSignUpLoginPnl.Size = new System.Drawing.Size(196, 23);
            this.lklbSignUpLoginPnl.TabIndex = 4;
            this.lklbSignUpLoginPnl.TabStop = true;
            this.lklbSignUpLoginPnl.Text = "create account? sign up";
            this.lklbSignUpLoginPnl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbSignUpLoginPnl_LinkClicked);
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(286, 253);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(371, 25);
            this.tbPW.TabIndex = 3;
            // 
            // tbUsernameOrE
            // 
            this.tbUsernameOrE.Location = new System.Drawing.Point(287, 146);
            this.tbUsernameOrE.Name = "tbUsernameOrE";
            this.tbUsernameOrE.Size = new System.Drawing.Size(370, 25);
            this.tbUsernameOrE.TabIndex = 2;
            // 
            // btnLoginPnl
            // 
            this.btnLoginPnl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoginPnl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginPnl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoginPnl.ForeColor = System.Drawing.Color.Snow;
            this.btnLoginPnl.Location = new System.Drawing.Point(375, 311);
            this.btnLoginPnl.Name = "btnLoginPnl";
            this.btnLoginPnl.Size = new System.Drawing.Size(166, 39);
            this.btnLoginPnl.TabIndex = 1;
            this.btnLoginPnl.Text = "login";
            this.btnLoginPnl.UseVisualStyleBackColor = false;
            this.btnLoginPnl.Click += new System.EventHandler(this.btnLoginPnl_Click);
            // 
            // pnSignUp
            // 
            this.pnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSignUp.BackgroundImage")));
            this.pnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnSignUp.Controls.Add(this.cbShowPW_SignUp);
            this.pnSignUp.Controls.Add(this.btnSignUp_SignUpPn);
            this.pnSignUp.Controls.Add(this.lklbLogin_SignUpPn);
            this.pnSignUp.Controls.Add(this.tbConfirmPW);
            this.pnSignUp.Controls.Add(this.tbPW_SignUpPN);
            this.pnSignUp.Controls.Add(this.tbEmailSignUpPn);
            this.pnSignUp.Controls.Add(this.tbUsernameSignUpPn);
            this.pnSignUp.Controls.Add(this.lblConfirmPW);
            this.pnSignUp.Controls.Add(this.lblPWSignUpPn);
            this.pnSignUp.Controls.Add(this.lblEmailSignUpPn);
            this.pnSignUp.Controls.Add(this.lblUsernameSignUpPn);
            this.pnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSignUp.Location = new System.Drawing.Point(0, 0);
            this.pnSignUp.Name = "pnSignUp";
            this.pnSignUp.Size = new System.Drawing.Size(918, 481);
            this.pnSignUp.TabIndex = 9;
            this.pnSignUp.Visible = false;
            this.pnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // cbShowPW_SignUp
            // 
            this.cbShowPW_SignUp.AutoSize = true;
            this.cbShowPW_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPW_SignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cbShowPW_SignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbShowPW_SignUp.Location = new System.Drawing.Point(737, 289);
            this.cbShowPW_SignUp.Name = "cbShowPW_SignUp";
            this.cbShowPW_SignUp.Size = new System.Drawing.Size(68, 24);
            this.cbShowPW_SignUp.TabIndex = 13;
            this.cbShowPW_SignUp.Text = "show";
            this.cbShowPW_SignUp.UseVisualStyleBackColor = false;
            this.cbShowPW_SignUp.CheckedChanged += new System.EventHandler(this.cbShowPW_SignUp_CheckedChanged);
            // 
            // btnSignUp_SignUpPn
            // 
            this.btnSignUp_SignUpPn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSignUp_SignUpPn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp_SignUpPn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignUp_SignUpPn.ForeColor = System.Drawing.Color.White;
            this.btnSignUp_SignUpPn.Location = new System.Drawing.Point(392, 362);
            this.btnSignUp_SignUpPn.Name = "btnSignUp_SignUpPn";
            this.btnSignUp_SignUpPn.Size = new System.Drawing.Size(124, 32);
            this.btnSignUp_SignUpPn.TabIndex = 12;
            this.btnSignUp_SignUpPn.Text = "sign up";
            this.btnSignUp_SignUpPn.UseVisualStyleBackColor = false;
            this.btnSignUp_SignUpPn.Click += new System.EventHandler(this.btnSignUp_SignUpPn_Click);
            // 
            // lklbLogin_SignUpPn
            // 
            this.lklbLogin_SignUpPn.AutoSize = true;
            this.lklbLogin_SignUpPn.BackColor = System.Drawing.Color.Transparent;
            this.lklbLogin_SignUpPn.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lklbLogin_SignUpPn.Location = new System.Drawing.Point(356, 407);
            this.lklbLogin_SignUpPn.Name = "lklbLogin_SignUpPn";
            this.lklbLogin_SignUpPn.Size = new System.Drawing.Size(200, 17);
            this.lklbLogin_SignUpPn.TabIndex = 10;
            this.lklbLogin_SignUpPn.TabStop = true;
            this.lklbLogin_SignUpPn.Text = "already have an account? log in";
            this.lklbLogin_SignUpPn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbLogin_SignUpPn_LinkClicked);
            // 
            // tbConfirmPW
            // 
            this.tbConfirmPW.Location = new System.Drawing.Point(227, 325);
            this.tbConfirmPW.Name = "tbConfirmPW";
            this.tbConfirmPW.PasswordChar = '*';
            this.tbConfirmPW.Size = new System.Drawing.Size(494, 25);
            this.tbConfirmPW.TabIndex = 8;
            // 
            // tbPW_SignUpPN
            // 
            this.tbPW_SignUpPN.Location = new System.Drawing.Point(226, 263);
            this.tbPW_SignUpPN.Name = "tbPW_SignUpPN";
            this.tbPW_SignUpPN.PasswordChar = '*';
            this.tbPW_SignUpPN.Size = new System.Drawing.Size(494, 25);
            this.tbPW_SignUpPN.TabIndex = 7;
            // 
            // tbEmailSignUpPn
            // 
            this.tbEmailSignUpPn.Location = new System.Drawing.Point(226, 197);
            this.tbEmailSignUpPn.Name = "tbEmailSignUpPn";
            this.tbEmailSignUpPn.Size = new System.Drawing.Size(494, 25);
            this.tbEmailSignUpPn.TabIndex = 6;
            // 
            // tbUsernameSignUpPn
            // 
            this.tbUsernameSignUpPn.Location = new System.Drawing.Point(226, 133);
            this.tbUsernameSignUpPn.Name = "tbUsernameSignUpPn";
            this.tbUsernameSignUpPn.Size = new System.Drawing.Size(494, 25);
            this.tbUsernameSignUpPn.TabIndex = 5;
            // 
            // lblConfirmPW
            // 
            this.lblConfirmPW.AutoSize = true;
            this.lblConfirmPW.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPW.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPW.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblConfirmPW.Location = new System.Drawing.Point(222, 300);
            this.lblConfirmPW.Name = "lblConfirmPW";
            this.lblConfirmPW.Size = new System.Drawing.Size(139, 20);
            this.lblConfirmPW.TabIndex = 4;
            this.lblConfirmPW.Text = "confirm password:";
            // 
            // lblPWSignUpPn
            // 
            this.lblPWSignUpPn.AutoSize = true;
            this.lblPWSignUpPn.BackColor = System.Drawing.Color.Transparent;
            this.lblPWSignUpPn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWSignUpPn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPWSignUpPn.Location = new System.Drawing.Point(222, 240);
            this.lblPWSignUpPn.Name = "lblPWSignUpPn";
            this.lblPWSignUpPn.Size = new System.Drawing.Size(80, 20);
            this.lblPWSignUpPn.TabIndex = 3;
            this.lblPWSignUpPn.Text = "password:";
            // 
            // lblEmailSignUpPn
            // 
            this.lblEmailSignUpPn.AutoSize = true;
            this.lblEmailSignUpPn.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailSignUpPn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSignUpPn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEmailSignUpPn.Location = new System.Drawing.Point(222, 175);
            this.lblEmailSignUpPn.Name = "lblEmailSignUpPn";
            this.lblEmailSignUpPn.Size = new System.Drawing.Size(51, 20);
            this.lblEmailSignUpPn.TabIndex = 2;
            this.lblEmailSignUpPn.Text = "email:";
            // 
            // lblUsernameSignUpPn
            // 
            this.lblUsernameSignUpPn.AutoSize = true;
            this.lblUsernameSignUpPn.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameSignUpPn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblUsernameSignUpPn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameSignUpPn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUsernameSignUpPn.Location = new System.Drawing.Point(223, 113);
            this.lblUsernameSignUpPn.Name = "lblUsernameSignUpPn";
            this.lblUsernameSignUpPn.Size = new System.Drawing.Size(82, 20);
            this.lblUsernameSignUpPn.TabIndex = 1;
            this.lblUsernameSignUpPn.Text = "username:";
            // 
            // pnForgotPW
            // 
            this.pnForgotPW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnForgotPW.BackgroundImage")));
            this.pnForgotPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnForgotPW.Controls.Add(this.lklbBackToLogin);
            this.pnForgotPW.Controls.Add(this.btnSendCode_ForgotPn);
            this.pnForgotPW.Controls.Add(this.tbEmailForgot);
            this.pnForgotPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForgotPW.Location = new System.Drawing.Point(0, 0);
            this.pnForgotPW.Name = "pnForgotPW";
            this.pnForgotPW.Size = new System.Drawing.Size(918, 481);
            this.pnForgotPW.TabIndex = 10;
            this.pnForgotPW.Visible = false;
            this.pnForgotPW.Paint += new System.Windows.Forms.PaintEventHandler(this.pnForgotPW_Paint);
            // 
            // lklbBackToLogin
            // 
            this.lklbBackToLogin.AutoSize = true;
            this.lklbBackToLogin.BackColor = System.Drawing.Color.Transparent;
            this.lklbBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lklbBackToLogin.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lklbBackToLogin.Location = new System.Drawing.Point(564, 281);
            this.lklbBackToLogin.Name = "lklbBackToLogin";
            this.lklbBackToLogin.Size = new System.Drawing.Size(116, 23);
            this.lklbBackToLogin.TabIndex = 4;
            this.lklbBackToLogin.TabStop = true;
            this.lklbBackToLogin.Text = "back to login";
            this.lklbBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbBackToLogin_linkClicked);
            // 
            // btnSendCode_ForgotPn
            // 
            this.btnSendCode_ForgotPn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSendCode_ForgotPn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendCode_ForgotPn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSendCode_ForgotPn.ForeColor = System.Drawing.Color.White;
            this.btnSendCode_ForgotPn.Location = new System.Drawing.Point(551, 235);
            this.btnSendCode_ForgotPn.Name = "btnSendCode_ForgotPn";
            this.btnSendCode_ForgotPn.Size = new System.Drawing.Size(135, 30);
            this.btnSendCode_ForgotPn.TabIndex = 3;
            this.btnSendCode_ForgotPn.Text = "send code";
            this.btnSendCode_ForgotPn.UseVisualStyleBackColor = false;
            this.btnSendCode_ForgotPn.Click += new System.EventHandler(this.btnSendCode_ForgotPn_Click);
            // 
            // tbEmailForgot
            // 
            this.tbEmailForgot.Location = new System.Drawing.Point(404, 186);
            this.tbEmailForgot.Name = "tbEmailForgot";
            this.tbEmailForgot.Size = new System.Drawing.Size(381, 25);
            this.tbEmailForgot.TabIndex = 2;
            // 
            // pnVerifyCode
            // 
            this.pnVerifyCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnVerifyCode.BackgroundImage")));
            this.pnVerifyCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnVerifyCode.Controls.Add(this.lklbResendCode);
            this.pnVerifyCode.Controls.Add(this.btnConfirmVC);
            this.pnVerifyCode.Controls.Add(this.tbVerificationCode);
            this.pnVerifyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnVerifyCode.Location = new System.Drawing.Point(0, 0);
            this.pnVerifyCode.Name = "pnVerifyCode";
            this.pnVerifyCode.Size = new System.Drawing.Size(918, 481);
            this.pnVerifyCode.TabIndex = 5;
            this.pnVerifyCode.Visible = false;
            // 
            // lklbResendCode
            // 
            this.lklbResendCode.AutoSize = true;
            this.lklbResendCode.BackColor = System.Drawing.Color.Transparent;
            this.lklbResendCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lklbResendCode.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lklbResendCode.Location = new System.Drawing.Point(424, 370);
            this.lklbResendCode.Name = "lklbResendCode";
            this.lklbResendCode.Size = new System.Drawing.Size(106, 23);
            this.lklbResendCode.TabIndex = 5;
            this.lklbResendCode.TabStop = true;
            this.lklbResendCode.Text = "resend code";
            this.lklbResendCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbResendCode_LinkClicked);
            // 
            // btnConfirmVC
            // 
            this.btnConfirmVC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmVC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmVC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmVC.ForeColor = System.Drawing.Color.White;
            this.btnConfirmVC.Location = new System.Drawing.Point(427, 320);
            this.btnConfirmVC.Name = "btnConfirmVC";
            this.btnConfirmVC.Size = new System.Drawing.Size(89, 39);
            this.btnConfirmVC.TabIndex = 3;
            this.btnConfirmVC.Text = "confirm";
            this.btnConfirmVC.UseVisualStyleBackColor = false;
            this.btnConfirmVC.Click += new System.EventHandler(this.btnConfirmVC_Click);
            // 
            // tbVerificationCode
            // 
            this.tbVerificationCode.Location = new System.Drawing.Point(299, 264);
            this.tbVerificationCode.Name = "tbVerificationCode";
            this.tbVerificationCode.Size = new System.Drawing.Size(358, 25);
            this.tbVerificationCode.TabIndex = 2;
            // 
            // pnResetPW
            // 
            this.pnResetPW.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnResetPW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnResetPW.BackgroundImage")));
            this.pnResetPW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnResetPW.Controls.Add(this.cbShowPW_ResetPW);
            this.pnResetPW.Controls.Add(this.btnReset_ResetPWPn);
            this.pnResetPW.Controls.Add(this.tbConfirmNewPW);
            this.pnResetPW.Controls.Add(this.lblConfirmNewPW);
            this.pnResetPW.Controls.Add(this.tbNewPW);
            this.pnResetPW.Controls.Add(this.lblNewPW);
            this.pnResetPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnResetPW.Location = new System.Drawing.Point(0, 0);
            this.pnResetPW.Name = "pnResetPW";
            this.pnResetPW.Size = new System.Drawing.Size(918, 481);
            this.pnResetPW.TabIndex = 5;
            this.pnResetPW.Visible = false;
            // 
            // cbShowPW_ResetPW
            // 
            this.cbShowPW_ResetPW.AutoSize = true;
            this.cbShowPW_ResetPW.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPW_ResetPW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbShowPW_ResetPW.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbShowPW_ResetPW.Location = new System.Drawing.Point(657, 220);
            this.cbShowPW_ResetPW.Name = "cbShowPW_ResetPW";
            this.cbShowPW_ResetPW.Size = new System.Drawing.Size(73, 27);
            this.cbShowPW_ResetPW.TabIndex = 6;
            this.cbShowPW_ResetPW.Text = "show";
            this.cbShowPW_ResetPW.UseVisualStyleBackColor = false;
            this.cbShowPW_ResetPW.CheckedChanged += new System.EventHandler(this.cbShowPW_ResetPW_CheckedChanged);
            // 
            // btnReset_ResetPWPn
            // 
            this.btnReset_ResetPWPn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReset_ResetPWPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset_ResetPWPn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset_ResetPWPn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset_ResetPWPn.ForeColor = System.Drawing.Color.Snow;
            this.btnReset_ResetPWPn.Location = new System.Drawing.Point(404, 320);
            this.btnReset_ResetPWPn.Name = "btnReset_ResetPWPn";
            this.btnReset_ResetPWPn.Size = new System.Drawing.Size(85, 29);
            this.btnReset_ResetPWPn.TabIndex = 5;
            this.btnReset_ResetPWPn.Text = "reset ";
            this.btnReset_ResetPWPn.UseVisualStyleBackColor = false;
            this.btnReset_ResetPWPn.Click += new System.EventHandler(this.btnReset_ResetPWPn_Click);
            // 
            // tbConfirmNewPW
            // 
            this.tbConfirmNewPW.Location = new System.Drawing.Point(299, 264);
            this.tbConfirmNewPW.Name = "tbConfirmNewPW";
            this.tbConfirmNewPW.PasswordChar = '*';
            this.tbConfirmNewPW.Size = new System.Drawing.Size(322, 25);
            this.tbConfirmNewPW.TabIndex = 4;
            // 
            // lblConfirmNewPW
            // 
            this.lblConfirmNewPW.AutoSize = true;
            this.lblConfirmNewPW.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfirmNewPW.ForeColor = System.Drawing.Color.Firebrick;
            this.lblConfirmNewPW.Location = new System.Drawing.Point(292, 219);
            this.lblConfirmNewPW.Name = "lblConfirmNewPW";
            this.lblConfirmNewPW.Size = new System.Drawing.Size(197, 23);
            this.lblConfirmNewPW.TabIndex = 3;
            this.lblConfirmNewPW.Text = "confirm new password:";
            // 
            // tbNewPW
            // 
            this.tbNewPW.Location = new System.Drawing.Point(299, 164);
            this.tbNewPW.Name = "tbNewPW";
            this.tbNewPW.PasswordChar = '*';
            this.tbNewPW.Size = new System.Drawing.Size(313, 25);
            this.tbNewPW.TabIndex = 2;
            this.tbNewPW.TextChanged += new System.EventHandler(this.tbNewPW_TextChanged);
            // 
            // lblNewPW
            // 
            this.lblNewPW.AutoSize = true;
            this.lblNewPW.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPW.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPW.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNewPW.Location = new System.Drawing.Point(295, 113);
            this.lblNewPW.Name = "lblNewPW";
            this.lblNewPW.Size = new System.Drawing.Size(129, 23);
            this.lblNewPW.TabIndex = 1;
            this.lblNewPW.Text = "new password:";
            // 
            // landingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 481);
            this.Controls.Add(this.pnResetPW);
            this.Controls.Add(this.pnForgotPW);
            this.Controls.Add(this.pnVerifyCode);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnSignUp);
            this.Controls.Add(this.pnLanding);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "landingPage";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLanding.ResumeLayout(false);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnSignUp.ResumeLayout(false);
            this.pnSignUp.PerformLayout();
            this.pnForgotPW.ResumeLayout(false);
            this.pnForgotPW.PerformLayout();
            this.pnVerifyCode.ResumeLayout(false);
            this.pnVerifyCode.PerformLayout();
            this.pnResetPW.ResumeLayout(false);
            this.pnResetPW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel pnLanding;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.LinkLabel lklbNewPW;
        private System.Windows.Forms.LinkLabel lklbSignUpLoginPnl;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbUsernameOrE;
        private System.Windows.Forms.Button btnLoginPnl;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnSignUp;
        private System.Windows.Forms.LinkLabel lklbLogin_SignUpPn;
        private System.Windows.Forms.TextBox tbConfirmPW;
        private System.Windows.Forms.TextBox tbPW_SignUpPN;
        private System.Windows.Forms.TextBox tbEmailSignUpPn;
        private System.Windows.Forms.TextBox tbUsernameSignUpPn;
        private System.Windows.Forms.Label lblConfirmPW;
        private System.Windows.Forms.Label lblPWSignUpPn;
        private System.Windows.Forms.Label lblEmailSignUpPn;
        private System.Windows.Forms.Label lblUsernameSignUpPn;
        private System.Windows.Forms.Button btnSignUp_SignUpPn;
        private System.Windows.Forms.Panel pnForgotPW;
        private System.Windows.Forms.LinkLabel lklbBackToLogin;
        private System.Windows.Forms.Button btnSendCode_ForgotPn;
        private System.Windows.Forms.TextBox tbEmailForgot;
        private System.Windows.Forms.Panel pnVerifyCode;
        private System.Windows.Forms.Button btnConfirmVC;
        private System.Windows.Forms.TextBox tbVerificationCode;
        private System.Windows.Forms.LinkLabel lklbResendCode;
        private System.Windows.Forms.Panel pnResetPW;
        private System.Windows.Forms.Button btnReset_ResetPWPn;
        private System.Windows.Forms.TextBox tbConfirmNewPW;
        private System.Windows.Forms.Label lblConfirmNewPW;
        private System.Windows.Forms.TextBox tbNewPW;
        private System.Windows.Forms.Label lblNewPW;
        private System.Windows.Forms.CheckBox cbShowPW;
        private System.Windows.Forms.CheckBox cbShowPW_ResetPW;
        private System.Windows.Forms.CheckBox cbShowPW_SignUp;
    }
}

