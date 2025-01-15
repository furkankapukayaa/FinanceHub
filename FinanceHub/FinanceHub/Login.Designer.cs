namespace FinanceHub
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(315, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(315, 131);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(315, 47);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 18);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail Adresiniz";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(315, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Şifreniz";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(513, 83);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 55);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 50);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(305, 107);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.Silver;
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Location = new System.Drawing.Point(-1, 204);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(618, 44);
            this.panelRegister.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Location = new System.Drawing.Point(8, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(598, 35);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Hesabınız yok mu? Tıklayarak kaydolun, gelir ve giderlerinizi kolayca kontrol alt" +
    "ına alın!";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 241);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinanceHub - Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button btnRegister;
    }
}