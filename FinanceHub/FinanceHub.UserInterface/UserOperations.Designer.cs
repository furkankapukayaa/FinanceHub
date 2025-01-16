namespace FinanceHub.UserInterface
{
    partial class UserOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOperations));
            btnUpdate = new Button();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            txtLastName = new TextBox();
            txtName = new TextBox();
            lblLastName = new Label();
            lblName = new Label();
            pictureBoxLogo = new PictureBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Bahnschrift", 9.75F);
            btnUpdate.Location = new Point(98, 437);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 39);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift", 11.25F);
            txtPhone.Location = new Point(68, 395);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(177, 26);
            txtPhone.TabIndex = 19;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 11.25F);
            lblPhone.ForeColor = Color.DimGray;
            lblPhone.Location = new Point(68, 374);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(55, 18);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Telefon";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Bahnschrift", 11.25F);
            txtPassword.Location = new Point(68, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 26);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift", 11.25F);
            txtEmail.Location = new Point(68, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 26);
            txtEmail.TabIndex = 17;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift", 11.25F);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(68, 311);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(40, 18);
            lblPassword.TabIndex = 24;
            lblPassword.Text = "Şifre";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bahnschrift", 11.25F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(68, 249);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 18);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "E-posta";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Bahnschrift", 11.25F);
            txtLastName.Location = new Point(68, 210);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 26);
            txtLastName.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift", 11.25F);
            txtName.Location = new Point(68, 148);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 26);
            txtName.TabIndex = 14;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Bahnschrift", 11.25F);
            lblLastName.ForeColor = Color.DimGray;
            lblLastName.Location = new Point(68, 189);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(48, 18);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Soyad";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 11.25F);
            lblName.ForeColor = Color.DimGray;
            lblName.Location = new Point(68, 127);
            lblName.Name = "lblName";
            lblName.Size = new Size(26, 18);
            lblName.TabIndex = 21;
            lblName.Text = "Ad";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(305, 107);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 16;
            pictureBoxLogo.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(299, 453);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 46);
            btnBack.TabIndex = 26;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // UserOperations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 511);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
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
            Name = "UserOperations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Kullanıcı İşlemleri";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label lblLastName;
        private Label lblName;
        private PictureBox pictureBoxLogo;
        private Button btnBack;
    }
}