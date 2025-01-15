namespace FinanceHub.UserInterface
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBoxLogo = new PictureBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            panelRegister = new Panel();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 57);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(305, 107);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift", 11.25F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(323, 57);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(128, 18);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-posta Adresiniz";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift", 11.25F);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(323, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(59, 18);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Şifreniz";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift", 11.25F);
            txtEmail.Location = new Point(323, 78);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 26);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "furkankapukayaa@gmail.com";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bahnschrift", 11.25F);
            txtPassword.Location = new Point(323, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(177, 26);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "furkan123";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Bahnschrift", 9.75F);
            btnLogin.Location = new Point(519, 127);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(77, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.Silver;
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Location = new Point(-1, 204);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(618, 44);
            panelRegister.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Bahnschrift", 11.25F);
            btnRegister.Location = new Point(7, 1);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(598, 35);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Hesabınız yok mu? Tıklayarak kaydolun, gelir ve giderlerinizi kolayca kontrol altına alın!";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 241);
            Controls.Add(panelRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelRegister.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel panelRegister;
        private Button btnRegister;
    }
}