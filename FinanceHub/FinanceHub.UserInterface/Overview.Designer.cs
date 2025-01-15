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
            lblMonthlyIncome = new Label();
            pictureBoxIncomes = new PictureBox();
            panelExpenses = new Panel();
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
            panelIncomes.Controls.Add(lblMonthlyIncome);
            panelIncomes.Controls.Add(pictureBoxIncomes);
            panelIncomes.Location = new Point(12, 12);
            panelIncomes.Name = "panelIncomes";
            panelIncomes.Size = new Size(384, 341);
            panelIncomes.TabIndex = 0;
            // 
            // lblMonthlyIncome
            // 
            lblMonthlyIncome.AutoSize = true;
            lblMonthlyIncome.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyIncome.Location = new Point(116, 132);
            lblMonthlyIncome.Name = "lblMonthlyIncome";
            lblMonthlyIncome.Size = new Size(122, 23);
            lblMonthlyIncome.TabIndex = 1;
            lblMonthlyIncome.Text = "Aylık Gelirler";
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
            panelExpenses.Controls.Add(lblMonthlyExpenses);
            panelExpenses.Controls.Add(pictureBoxExpenses);
            panelExpenses.Location = new Point(404, 12);
            panelExpenses.Name = "panelExpenses";
            panelExpenses.Size = new Size(384, 341);
            panelExpenses.TabIndex = 1;
            // 
            // lblMonthlyExpenses
            // 
            lblMonthlyExpenses.AutoSize = true;
            lblMonthlyExpenses.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyExpenses.Location = new Point(138, 132);
            lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            lblMonthlyExpenses.Size = new Size(126, 23);
            lblMonthlyExpenses.TabIndex = 2;
            lblMonthlyExpenses.Text = "Aylık Giderler";
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
    }
}