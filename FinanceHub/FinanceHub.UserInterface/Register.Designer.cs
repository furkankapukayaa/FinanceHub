namespace FinanceHub.UserInterface
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBoxLogo = new PictureBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            lblLastName = new Label();
            lblName = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            panelLogin = new Panel();
            btnLogin = new Button();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(73, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(305, 107);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Bahnschrift", 11.25F);
            txtLastName.Location = new Point(143, 206);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 26);
            txtLastName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 11.25F);
            txtName.Location = new Point(143, 144);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 26);
            txtName.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Bahnschrift", 11.25F);
            lblLastName.ForeColor = Color.DimGray;
            lblLastName.Location = new Point(143, 185);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(48, 18);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Soyad";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 11.25F);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(143, 123);
            lblName.Name = "lblName";
            lblName.Size = new Size(26, 18);
            lblName.TabIndex = 5;
            lblName.Text = "Ad";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bahnschrift", 11.25F);
            txtPassword.Location = new Point(143, 328);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(177, 26);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift", 11.25F);
            txtEmail.Location = new Point(143, 266);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 26);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift", 11.25F);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(143, 307);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(40, 18);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Şifre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift", 11.25F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(143, 245);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 18);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-posta";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift", 11.25F);
            txtPhone.Location = new Point(143, 391);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(177, 26);
            txtPhone.TabIndex = 4;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 11.25F);
            lblPhone.ForeColor = Color.DimGray;
            lblPhone.Location = new Point(143, 370);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(55, 18);
            lblPhone.TabIndex = 13;
            lblPhone.Text = "Telefon";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Silver;
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Location = new Point(-1, 484);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(481, 44);
            panelLogin.TabIndex = 14;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bahnschrift", 11.25F);
            btnLogin.Location = new Point(3, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(466, 35);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Hesabınız var mı? Tıklayarak giriş yapın ve harcamalarınızı yönetin!";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Bahnschrift", 9.75F);
            btnRegister.Location = new Point(170, 428);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 39);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 525);
            Controls.Add(btnRegister);
            Controls.Add(panelLogin);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Kayıt";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelLogin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label lblLastName;
        private Label lblName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private Panel panelLogin;
        private Button btnLogin;
        private Button btnRegister;
    }
}