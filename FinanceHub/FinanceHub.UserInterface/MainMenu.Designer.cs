namespace FinanceHub.UserInterface
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            imageList = new ImageList(components);
            pictureBoxLogo = new PictureBox();
            lblCalendar = new Label();
            lblWelcomeUser = new Label();
            btnLogout = new Button();
            btnOverview = new Button();
            btnAccountOperations = new Button();
            btnExchange = new Button();
            btnTransactions = new Button();
            btnCategories = new Button();
            btnUserOperations = new Button();
            timerCalendar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "accountOperations.png");
            imageList.Images.SetKeyName(1, "categories.png");
            imageList.Images.SetKeyName(2, "exchange.png");
            imageList.Images.SetKeyName(3, "overview.png");
            imageList.Images.SetKeyName(4, "transactions.png");
            imageList.Images.SetKeyName(5, "userOperations.png");
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(578, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(210, 91);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCalendar.Location = new Point(12, 35);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(94, 19);
            lblCalendar.TabIndex = 3;
            lblCalendar.Text = "TarihVeSaat";
            lblCalendar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblWelcomeUser.Location = new Point(12, 423);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(120, 18);
            lblWelcomeUser.TabIndex = 4;
            lblWelcomeUser.Text = "Hoş Geldin User!";
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(742, 392);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(46, 46);
            btnLogout.TabIndex = 6;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOverview
            // 
            btnOverview.Cursor = Cursors.Hand;
            btnOverview.FlatAppearance.BorderSize = 0;
            btnOverview.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOverview.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOverview.FlatStyle = FlatStyle.Flat;
            btnOverview.Font = new Font("Bahnschrift", 9.75F);
            btnOverview.ImageAlign = ContentAlignment.TopCenter;
            btnOverview.ImageKey = "overview.png";
            btnOverview.ImageList = imageList;
            btnOverview.Location = new Point(12, 184);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(117, 112);
            btnOverview.TabIndex = 0;
            btnOverview.Text = "Genel Bakış";
            btnOverview.TextAlign = ContentAlignment.BottomCenter;
            btnOverview.UseVisualStyleBackColor = true;
            btnOverview.Click += btnOverview_Click;
            // 
            // btnAccountOperations
            // 
            btnAccountOperations.Cursor = Cursors.Hand;
            btnAccountOperations.FlatAppearance.BorderSize = 0;
            btnAccountOperations.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAccountOperations.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAccountOperations.FlatStyle = FlatStyle.Flat;
            btnAccountOperations.Font = new Font("Bahnschrift", 9.75F);
            btnAccountOperations.ImageAlign = ContentAlignment.TopCenter;
            btnAccountOperations.ImageKey = "accountOperations.png";
            btnAccountOperations.ImageList = imageList;
            btnAccountOperations.Location = new Point(139, 184);
            btnAccountOperations.Name = "btnAccountOperations";
            btnAccountOperations.Size = new Size(117, 112);
            btnAccountOperations.TabIndex = 1;
            btnAccountOperations.Text = "Hesap İşlemleri";
            btnAccountOperations.TextAlign = ContentAlignment.BottomCenter;
            btnAccountOperations.UseVisualStyleBackColor = true;
            btnAccountOperations.Click += btnAccountOperations_Click;
            // 
            // btnExchange
            // 
            btnExchange.Cursor = Cursors.Hand;
            btnExchange.FlatAppearance.BorderSize = 0;
            btnExchange.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExchange.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExchange.FlatStyle = FlatStyle.Flat;
            btnExchange.Font = new Font("Bahnschrift", 9.75F);
            btnExchange.ImageAlign = ContentAlignment.TopCenter;
            btnExchange.ImageKey = "exchange.png";
            btnExchange.ImageList = imageList;
            btnExchange.Location = new Point(264, 184);
            btnExchange.Name = "btnExchange";
            btnExchange.Size = new Size(117, 112);
            btnExchange.TabIndex = 2;
            btnExchange.Text = "Döviz İşlemleri";
            btnExchange.TextAlign = ContentAlignment.BottomCenter;
            btnExchange.UseVisualStyleBackColor = true;
            btnExchange.Click += btnExchange_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Cursor = Cursors.Hand;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTransactions.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Bahnschrift", 9.75F);
            btnTransactions.ImageAlign = ContentAlignment.TopCenter;
            btnTransactions.ImageKey = "transactions.png";
            btnTransactions.ImageList = imageList;
            btnTransactions.Location = new Point(397, 184);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(117, 112);
            btnTransactions.TabIndex = 3;
            btnTransactions.Text = "Hareketler";
            btnTransactions.TextAlign = ContentAlignment.BottomCenter;
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnCategories
            // 
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Bahnschrift", 9.75F);
            btnCategories.ImageAlign = ContentAlignment.TopCenter;
            btnCategories.ImageKey = "categories.png";
            btnCategories.ImageList = imageList;
            btnCategories.Location = new Point(533, 184);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(117, 112);
            btnCategories.TabIndex = 4;
            btnCategories.Text = "Kategoriler";
            btnCategories.TextAlign = ContentAlignment.BottomCenter;
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnUserOperations
            // 
            btnUserOperations.Cursor = Cursors.Hand;
            btnUserOperations.FlatAppearance.BorderSize = 0;
            btnUserOperations.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUserOperations.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUserOperations.FlatStyle = FlatStyle.Flat;
            btnUserOperations.Font = new Font("Bahnschrift", 9.75F);
            btnUserOperations.ImageAlign = ContentAlignment.TopCenter;
            btnUserOperations.ImageKey = "userOperations.png";
            btnUserOperations.ImageList = imageList;
            btnUserOperations.Location = new Point(666, 184);
            btnUserOperations.Name = "btnUserOperations";
            btnUserOperations.Size = new Size(122, 112);
            btnUserOperations.TabIndex = 5;
            btnUserOperations.Text = "Kullanıcı İşlemleri";
            btnUserOperations.TextAlign = ContentAlignment.BottomCenter;
            btnUserOperations.UseVisualStyleBackColor = true;
            btnUserOperations.Click += btnUserOperations_Click;
            // 
            // timerCalendar
            // 
            timerCalendar.Tick += timerCalendar_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUserOperations);
            Controls.Add(btnCategories);
            Controls.Add(btnTransactions);
            Controls.Add(btnExchange);
            Controls.Add(btnAccountOperations);
            Controls.Add(btnOverview);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcomeUser);
            Controls.Add(lblCalendar);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList;
        private PictureBox pictureBoxLogo;
        private Label lblCalendar;
        private Label lblWelcomeUser;
        private Button btnLogout;
        private Button btnOverview;
        private Button btnAccountOperations;
        private Button btnExchange;
        private Button btnTransactions;
        private Button btnCategories;
        private Button btnUserOperations;
        private System.Windows.Forms.Timer timerCalendar;
    }
}