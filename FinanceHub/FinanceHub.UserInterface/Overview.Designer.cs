namespace FinanceHub.UserInterface
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            imageList = new ImageList(components);
            panelIncomes = new Panel();
            lblDailyIncomeAmount = new Label();
            lblWeeklyIncomeAmount = new Label();
            lblDaily = new Label();
            lblWeekly = new Label();
            lblMontly = new Label();
            lblMonthlyIncomeAmount = new Label();
            lblMonthlyIncome = new Label();
            pictureBoxIncomes = new PictureBox();
            panelExpenses = new Panel();
            lblDailyExpensesAmount = new Label();
            lblWeeklyExpensesAmount = new Label();
            lblDaily1 = new Label();
            lblWeekly1 = new Label();
            lblMontly1 = new Label();
            lblMonthlyExpensesAmount = new Label();
            lblMonthlyExpenses = new Label();
            pictureBoxExpenses = new PictureBox();
            btnBack = new Button();
            pictureBoxLogo = new PictureBox();
            lblCurrencyDescription = new Label();
            btnTurkishLira = new Button();
            btnDollar = new Button();
            btnEuro = new Button();
            panelIncomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIncomes).BeginInit();
            panelExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "dollar.png");
            imageList.Images.SetKeyName(1, "euro.png");
            imageList.Images.SetKeyName(2, "turkishlira.png");
            // 
            // panelIncomes
            // 
            panelIncomes.Controls.Add(lblDailyIncomeAmount);
            panelIncomes.Controls.Add(lblWeeklyIncomeAmount);
            panelIncomes.Controls.Add(lblDaily);
            panelIncomes.Controls.Add(lblWeekly);
            panelIncomes.Controls.Add(lblMontly);
            panelIncomes.Controls.Add(lblMonthlyIncomeAmount);
            panelIncomes.Controls.Add(lblMonthlyIncome);
            panelIncomes.Controls.Add(pictureBoxIncomes);
            panelIncomes.Location = new Point(12, 12);
            panelIncomes.Name = "panelIncomes";
            panelIncomes.Size = new Size(384, 341);
            panelIncomes.TabIndex = 0;
            // 
            // lblDailyIncomeAmount
            // 
            lblDailyIncomeAmount.AutoSize = true;
            lblDailyIncomeAmount.Font = new Font("Bahnschrift", 14.25F);
            lblDailyIncomeAmount.Location = new Point(157, 239);
            lblDailyIncomeAmount.Name = "lblDailyIncomeAmount";
            lblDailyIncomeAmount.Size = new Size(70, 23);
            lblDailyIncomeAmount.TabIndex = 7;
            lblDailyIncomeAmount.Text = "000000";
            // 
            // lblWeeklyIncomeAmount
            // 
            lblWeeklyIncomeAmount.AutoSize = true;
            lblWeeklyIncomeAmount.Font = new Font("Bahnschrift", 14.25F);
            lblWeeklyIncomeAmount.Location = new Point(157, 206);
            lblWeeklyIncomeAmount.Name = "lblWeeklyIncomeAmount";
            lblWeeklyIncomeAmount.Size = new Size(70, 23);
            lblWeeklyIncomeAmount.TabIndex = 6;
            lblWeeklyIncomeAmount.Text = "000000";
            // 
            // lblDaily
            // 
            lblDaily.AutoSize = true;
            lblDaily.Font = new Font("Bahnschrift", 14.25F);
            lblDaily.Location = new Point(80, 239);
            lblDaily.Name = "lblDaily";
            lblDaily.Size = new Size(71, 23);
            lblDaily.TabIndex = 5;
            lblDaily.Text = "Günlük";
            // 
            // lblWeekly
            // 
            lblWeekly.AutoSize = true;
            lblWeekly.Font = new Font("Bahnschrift", 14.25F);
            lblWeekly.Location = new Point(80, 206);
            lblWeekly.Name = "lblWeekly";
            lblWeekly.Size = new Size(76, 23);
            lblWeekly.TabIndex = 4;
            lblWeekly.Text = "Haftalık";
            // 
            // lblMontly
            // 
            lblMontly.AutoSize = true;
            lblMontly.Font = new Font("Bahnschrift", 14.25F);
            lblMontly.Location = new Point(80, 171);
            lblMontly.Name = "lblMontly";
            lblMontly.Size = new Size(52, 23);
            lblMontly.TabIndex = 3;
            lblMontly.Text = "Aylık";
            // 
            // lblMonthlyIncomeAmount
            // 
            lblMonthlyIncomeAmount.AutoSize = true;
            lblMonthlyIncomeAmount.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyIncomeAmount.Location = new Point(138, 171);
            lblMonthlyIncomeAmount.Name = "lblMonthlyIncomeAmount";
            lblMonthlyIncomeAmount.Size = new Size(70, 23);
            lblMonthlyIncomeAmount.TabIndex = 2;
            lblMonthlyIncomeAmount.Text = "000000";
            // 
            // lblMonthlyIncome
            // 
            lblMonthlyIncome.AutoSize = true;
            lblMonthlyIncome.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyIncome.Location = new Point(139, 132);
            lblMonthlyIncome.Name = "lblMonthlyIncome";
            lblMonthlyIncome.Size = new Size(75, 23);
            lblMonthlyIncome.TabIndex = 1;
            lblMonthlyIncome.Text = "Gelirler";
            // 
            // pictureBoxIncomes
            // 
            pictureBoxIncomes.Image = (Image)resources.GetObject("pictureBoxIncomes.Image");
            pictureBoxIncomes.Location = new Point(114, 16);
            pictureBoxIncomes.Name = "pictureBoxIncomes";
            pictureBoxIncomes.Size = new Size(134, 113);
            pictureBoxIncomes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIncomes.TabIndex = 0;
            pictureBoxIncomes.TabStop = false;
            // 
            // panelExpenses
            // 
            panelExpenses.Controls.Add(lblDailyExpensesAmount);
            panelExpenses.Controls.Add(lblWeeklyExpensesAmount);
            panelExpenses.Controls.Add(lblDaily1);
            panelExpenses.Controls.Add(lblWeekly1);
            panelExpenses.Controls.Add(lblMontly1);
            panelExpenses.Controls.Add(lblMonthlyExpensesAmount);
            panelExpenses.Controls.Add(lblMonthlyExpenses);
            panelExpenses.Controls.Add(pictureBoxExpenses);
            panelExpenses.Location = new Point(404, 12);
            panelExpenses.Name = "panelExpenses";
            panelExpenses.Size = new Size(384, 341);
            panelExpenses.TabIndex = 1;
            // 
            // lblDailyExpensesAmount
            // 
            lblDailyExpensesAmount.AutoSize = true;
            lblDailyExpensesAmount.Font = new Font("Bahnschrift", 14.25F);
            lblDailyExpensesAmount.Location = new Point(182, 239);
            lblDailyExpensesAmount.Name = "lblDailyExpensesAmount";
            lblDailyExpensesAmount.Size = new Size(70, 23);
            lblDailyExpensesAmount.TabIndex = 13;
            lblDailyExpensesAmount.Text = "000000";
            // 
            // lblWeeklyExpensesAmount
            // 
            lblWeeklyExpensesAmount.AutoSize = true;
            lblWeeklyExpensesAmount.Font = new Font("Bahnschrift", 14.25F);
            lblWeeklyExpensesAmount.Location = new Point(182, 206);
            lblWeeklyExpensesAmount.Name = "lblWeeklyExpensesAmount";
            lblWeeklyExpensesAmount.Size = new Size(70, 23);
            lblWeeklyExpensesAmount.TabIndex = 12;
            lblWeeklyExpensesAmount.Text = "000000";
            // 
            // lblDaily1
            // 
            lblDaily1.AutoSize = true;
            lblDaily1.Font = new Font("Bahnschrift", 14.25F);
            lblDaily1.Location = new Point(105, 239);
            lblDaily1.Name = "lblDaily1";
            lblDaily1.Size = new Size(71, 23);
            lblDaily1.TabIndex = 11;
            lblDaily1.Text = "Günlük";
            // 
            // lblWeekly1
            // 
            lblWeekly1.AutoSize = true;
            lblWeekly1.Font = new Font("Bahnschrift", 14.25F);
            lblWeekly1.Location = new Point(105, 206);
            lblWeekly1.Name = "lblWeekly1";
            lblWeekly1.Size = new Size(76, 23);
            lblWeekly1.TabIndex = 10;
            lblWeekly1.Text = "Haftalık";
            // 
            // lblMontly1
            // 
            lblMontly1.AutoSize = true;
            lblMontly1.Font = new Font("Bahnschrift", 14.25F);
            lblMontly1.Location = new Point(105, 171);
            lblMontly1.Name = "lblMontly1";
            lblMontly1.Size = new Size(52, 23);
            lblMontly1.TabIndex = 9;
            lblMontly1.Text = "Aylık";
            // 
            // lblMonthlyExpensesAmount
            // 
            lblMonthlyExpensesAmount.AutoSize = true;
            lblMonthlyExpensesAmount.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyExpensesAmount.Location = new Point(163, 171);
            lblMonthlyExpensesAmount.Name = "lblMonthlyExpensesAmount";
            lblMonthlyExpensesAmount.Size = new Size(70, 23);
            lblMonthlyExpensesAmount.TabIndex = 3;
            lblMonthlyExpensesAmount.Text = "000000";
            // 
            // lblMonthlyExpenses
            // 
            lblMonthlyExpenses.AutoSize = true;
            lblMonthlyExpenses.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyExpenses.Location = new Point(162, 132);
            lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            lblMonthlyExpenses.Size = new Size(79, 23);
            lblMonthlyExpenses.TabIndex = 2;
            lblMonthlyExpenses.Text = "Giderler";
            // 
            // pictureBoxExpenses
            // 
            pictureBoxExpenses.Image = (Image)resources.GetObject("pictureBoxExpenses.Image");
            pictureBoxExpenses.Location = new Point(137, 16);
            pictureBoxExpenses.Name = "pictureBoxExpenses";
            pictureBoxExpenses.Size = new Size(134, 113);
            pictureBoxExpenses.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpenses.TabIndex = 1;
            pictureBoxExpenses.TabStop = false;
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
            btnBack.Location = new Point(742, 411);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 46);
            btnBack.TabIndex = 4;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(269, 359);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(261, 43);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // lblCurrencyDescription
            // 
            lblCurrencyDescription.AutoSize = true;
            lblCurrencyDescription.Font = new Font("Bahnschrift Light", 10.25F);
            lblCurrencyDescription.Location = new Point(266, 440);
            lblCurrencyDescription.Name = "lblCurrencyDescription";
            lblCurrencyDescription.Size = new Size(267, 17);
            lblCurrencyDescription.TabIndex = 2;
            lblCurrencyDescription.Text = "Görmek istediğiniz para birimini seçiniz.";
            // 
            // btnTurkishLira
            // 
            btnTurkishLira.Cursor = Cursors.Hand;
            btnTurkishLira.FlatAppearance.BorderSize = 0;
            btnTurkishLira.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTurkishLira.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTurkishLira.FlatStyle = FlatStyle.Flat;
            btnTurkishLira.Font = new Font("Bahnschrift", 9.75F);
            btnTurkishLira.ImageAlign = ContentAlignment.TopCenter;
            btnTurkishLira.ImageKey = "turkishlira.png";
            btnTurkishLira.ImageList = imageList;
            btnTurkishLira.Location = new Point(289, 407);
            btnTurkishLira.Name = "btnTurkishLira";
            btnTurkishLira.Size = new Size(29, 31);
            btnTurkishLira.TabIndex = 1;
            btnTurkishLira.UseVisualStyleBackColor = true;
            btnTurkishLira.Click += btnTurkishLira_Click;
            // 
            // btnDollar
            // 
            btnDollar.Cursor = Cursors.Hand;
            btnDollar.FlatAppearance.BorderSize = 0;
            btnDollar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDollar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDollar.FlatStyle = FlatStyle.Flat;
            btnDollar.Font = new Font("Bahnschrift", 9.75F);
            btnDollar.ImageAlign = ContentAlignment.TopCenter;
            btnDollar.ImageKey = "dollar.png";
            btnDollar.ImageList = imageList;
            btnDollar.Location = new Point(380, 409);
            btnDollar.Name = "btnDollar";
            btnDollar.Size = new Size(29, 31);
            btnDollar.TabIndex = 2;
            btnDollar.UseVisualStyleBackColor = true;
            btnDollar.Click += btnDollar_Click;
            // 
            // btnEuro
            // 
            btnEuro.Cursor = Cursors.Hand;
            btnEuro.FlatAppearance.BorderSize = 0;
            btnEuro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEuro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEuro.FlatStyle = FlatStyle.Flat;
            btnEuro.Font = new Font("Bahnschrift", 9.75F);
            btnEuro.ImageAlign = ContentAlignment.TopCenter;
            btnEuro.ImageKey = "euro.png";
            btnEuro.ImageList = imageList;
            btnEuro.Location = new Point(476, 408);
            btnEuro.Name = "btnEuro";
            btnEuro.Size = new Size(29, 31);
            btnEuro.TabIndex = 3;
            btnEuro.UseVisualStyleBackColor = true;
            btnEuro.Click += btnEuro_Click;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(btnEuro);
            Controls.Add(btnDollar);
            Controls.Add(btnTurkishLira);
            Controls.Add(lblCurrencyDescription);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnBack);
            Controls.Add(panelExpenses);
            Controls.Add(panelIncomes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Overview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Genel Bakış";
            panelIncomes.ResumeLayout(false);
            panelIncomes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIncomes).EndInit();
            panelExpenses.ResumeLayout(false);
            panelExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList;
        private Panel panelIncomes;
        private Panel panelExpenses;
        private PictureBox pictureBoxIncomes;
        private PictureBox pictureBoxExpenses;
        private Label lblMonthlyIncome;
        private Label lblMonthlyExpenses;
        private Button btnBack;
        private PictureBox pictureBoxLogo;
        private Label lblCurrencyDescription;
        private Button btnTurkishLira;
        private Button btnDollar;
        private Button btnEuro;
        private Label lblMonthlyIncomeAmount;
        private Label lblMonthlyExpensesAmount;
        private Label lblDailyIncomeAmount;
        private Label lblWeeklyIncomeAmount;
        private Label lblDaily;
        private Label lblWeekly;
        private Label lblMontly;
        private Label lblDailyExpensesAmount;
        private Label lblWeeklyExpensesAmount;
        private Label lblDaily1;
        private Label lblWeekly1;
        private Label lblMontly1;
    }
}