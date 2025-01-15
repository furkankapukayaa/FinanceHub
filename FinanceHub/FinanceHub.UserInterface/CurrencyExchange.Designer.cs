namespace FinanceHub.UserInterface
{
    partial class CurrencyExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyExchange));
            btnBack = new Button();
            lblMonthlyIncome = new Label();
            groupBoxExchange = new GroupBox();
            lblExchangeAmount = new Label();
            txtExchangeAmount = new TextBox();
            btnExchangeConfirm = new Button();
            lblCurrencyAccount = new Label();
            comboBoxCurrencyAccount = new ComboBox();
            lblTurkishLiraAccount = new Label();
            comboBoxTurkishLiraAccount = new ComboBox();
            pictureBoxLogo = new PictureBox();
            groupBoxExchange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
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
            btnBack.Location = new Point(245, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 46);
            btnBack.TabIndex = 5;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblMonthlyIncome
            // 
            lblMonthlyIncome.AutoSize = true;
            lblMonthlyIncome.Font = new Font("Bahnschrift", 14.25F);
            lblMonthlyIncome.Location = new Point(36, 101);
            lblMonthlyIncome.Name = "lblMonthlyIncome";
            lblMonthlyIncome.Size = new Size(202, 23);
            lblMonthlyIncome.TabIndex = 6;
            lblMonthlyIncome.Text = "1$ = 35₺           1€ = 36₺";
            // 
            // groupBoxExchange
            // 
            groupBoxExchange.Controls.Add(lblExchangeAmount);
            groupBoxExchange.Controls.Add(txtExchangeAmount);
            groupBoxExchange.Controls.Add(btnExchangeConfirm);
            groupBoxExchange.Controls.Add(lblCurrencyAccount);
            groupBoxExchange.Controls.Add(comboBoxCurrencyAccount);
            groupBoxExchange.Controls.Add(lblTurkishLiraAccount);
            groupBoxExchange.Controls.Add(comboBoxTurkishLiraAccount);
            groupBoxExchange.Font = new Font("Bahnschrift", 11.25F);
            groupBoxExchange.Location = new Point(36, 141);
            groupBoxExchange.Name = "groupBoxExchange";
            groupBoxExchange.Size = new Size(210, 255);
            groupBoxExchange.TabIndex = 11;
            groupBoxExchange.TabStop = false;
            groupBoxExchange.Text = "Döviz Bozdur";
            // 
            // lblExchangeAmount
            // 
            lblExchangeAmount.AutoSize = true;
            lblExchangeAmount.Font = new Font("Bahnschrift", 11.25F);
            lblExchangeAmount.ForeColor = Color.DimGray;
            lblExchangeAmount.Location = new Point(15, 144);
            lblExchangeAmount.Name = "lblExchangeAmount";
            lblExchangeAmount.Size = new Size(41, 18);
            lblExchangeAmount.TabIndex = 11;
            lblExchangeAmount.Text = "Tutar";
            // 
            // txtExchangeAmount
            // 
            txtExchangeAmount.Font = new Font("Bahnschrift", 11.25F);
            txtExchangeAmount.Location = new Point(15, 165);
            txtExchangeAmount.Name = "txtExchangeAmount";
            txtExchangeAmount.Size = new Size(177, 26);
            txtExchangeAmount.TabIndex = 3;
            // 
            // btnExchangeConfirm
            // 
            btnExchangeConfirm.Cursor = Cursors.Hand;
            btnExchangeConfirm.Font = new Font("Bahnschrift", 9.75F);
            btnExchangeConfirm.Location = new Point(115, 197);
            btnExchangeConfirm.Name = "btnExchangeConfirm";
            btnExchangeConfirm.Size = new Size(77, 39);
            btnExchangeConfirm.TabIndex = 4;
            btnExchangeConfirm.Text = "Onayla";
            btnExchangeConfirm.UseVisualStyleBackColor = true;
            btnExchangeConfirm.Click += btnExchangeConfirm_Click;
            // 
            // lblCurrencyAccount
            // 
            lblCurrencyAccount.AutoSize = true;
            lblCurrencyAccount.Font = new Font("Bahnschrift", 11.25F);
            lblCurrencyAccount.ForeColor = Color.DimGray;
            lblCurrencyAccount.Location = new Point(15, 28);
            lblCurrencyAccount.Name = "lblCurrencyAccount";
            lblCurrencyAccount.Size = new Size(95, 18);
            lblCurrencyAccount.TabIndex = 9;
            lblCurrencyAccount.Text = "Doviz Hesabı";
            // 
            // comboBoxCurrencyAccount
            // 
            comboBoxCurrencyAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCurrencyAccount.Font = new Font("Bahnschrift", 11.25F);
            comboBoxCurrencyAccount.FormattingEnabled = true;
            comboBoxCurrencyAccount.ItemHeight = 18;
            comboBoxCurrencyAccount.Location = new Point(15, 49);
            comboBoxCurrencyAccount.Name = "comboBoxCurrencyAccount";
            comboBoxCurrencyAccount.Size = new Size(177, 26);
            comboBoxCurrencyAccount.TabIndex = 1;
            // 
            // lblTurkishLiraAccount
            // 
            lblTurkishLiraAccount.AutoSize = true;
            lblTurkishLiraAccount.Font = new Font("Bahnschrift", 11.25F);
            lblTurkishLiraAccount.ForeColor = Color.DimGray;
            lblTurkishLiraAccount.Location = new Point(15, 85);
            lblTurkishLiraAccount.Name = "lblTurkishLiraAccount";
            lblTurkishLiraAccount.Size = new Size(74, 18);
            lblTurkishLiraAccount.TabIndex = 7;
            lblTurkishLiraAccount.Text = "TL Hesabı";
            // 
            // comboBoxTurkishLiraAccount
            // 
            comboBoxTurkishLiraAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTurkishLiraAccount.Font = new Font("Bahnschrift", 11.25F);
            comboBoxTurkishLiraAccount.FormattingEnabled = true;
            comboBoxTurkishLiraAccount.ItemHeight = 18;
            comboBoxTurkishLiraAccount.Location = new Point(15, 106);
            comboBoxTurkishLiraAccount.Name = "comboBoxTurkishLiraAccount";
            comboBoxTurkishLiraAccount.Size = new Size(177, 26);
            comboBoxTurkishLiraAccount.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(256, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 23;
            pictureBoxLogo.TabStop = false;
            // 
            // CurrencyExchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 450);
            Controls.Add(pictureBoxLogo);
            Controls.Add(groupBoxExchange);
            Controls.Add(lblMonthlyIncome);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CurrencyExchange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Döviz İşlemleri";
            groupBoxExchange.ResumeLayout(false);
            groupBoxExchange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblMonthlyIncome;
        private GroupBox groupBoxExchange;
        private Label lblExchangeAmount;
        private TextBox txtExchangeAmount;
        private Button btnExchangeConfirm;
        private Label lblCurrencyAccount;
        private ComboBox comboBoxCurrencyAccount;
        private Label lblTurkishLiraAccount;
        private ComboBox comboBoxTurkishLiraAccount;
        private PictureBox pictureBoxLogo;
    }
}