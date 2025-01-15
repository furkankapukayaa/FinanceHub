namespace FinanceHub.UserInterface
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            dataGridViewTransactions = new DataGridView();
            btnFilter = new Button();
            lblCategory = new Label();
            comboBoxCategory = new ComboBox();
            lblAccount = new Label();
            comboBoxAccount = new ComboBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            lblStartDateTime = new Label();
            lblEndDateTime = new Label();
            pictureBoxLogo = new PictureBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(12, 87);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.Size = new Size(776, 312);
            dataGridViewTransactions.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Font = new Font("Bahnschrift", 9.75F);
            btnFilter.Location = new Point(647, 21);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(77, 39);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Bahnschrift", 11.25F);
            lblCategory.ForeColor = Color.DimGray;
            lblCategory.Location = new Point(12, 18);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 18);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Kategori";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Bahnschrift", 11.25F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.ItemHeight = 18;
            comboBoxCategory.Location = new Point(83, 15);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(177, 26);
            comboBoxCategory.TabIndex = 15;
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.Font = new Font("Bahnschrift", 11.25F);
            lblAccount.ForeColor = Color.DimGray;
            lblAccount.Location = new Point(27, 50);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(50, 18);
            lblAccount.TabIndex = 16;
            lblAccount.Text = "Hesap";
            // 
            // comboBoxAccount
            // 
            comboBoxAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccount.Font = new Font("Bahnschrift", 11.25F);
            comboBoxAccount.FormattingEnabled = true;
            comboBoxAccount.ItemHeight = 18;
            comboBoxAccount.Location = new Point(83, 47);
            comboBoxAccount.Name = "comboBoxAccount";
            comboBoxAccount.Size = new Size(177, 26);
            comboBoxAccount.TabIndex = 17;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarFont = new Font("Bahnschrift", 11.25F);
            dateTimePickerStart.Location = new Point(408, 15);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 23);
            dateTimePickerStart.TabIndex = 18;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarFont = new Font("Bahnschrift", 11.25F);
            dateTimePickerEnd.Location = new Point(408, 47);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 23);
            dateTimePickerEnd.TabIndex = 19;
            // 
            // lblStartDateTime
            // 
            lblStartDateTime.AutoSize = true;
            lblStartDateTime.Font = new Font("Bahnschrift", 11.25F);
            lblStartDateTime.ForeColor = Color.DimGray;
            lblStartDateTime.Location = new Point(289, 18);
            lblStartDateTime.Name = "lblStartDateTime";
            lblStartDateTime.Size = new Size(113, 18);
            lblStartDateTime.TabIndex = 20;
            lblStartDateTime.Text = "Başlangıç Tarihi";
            // 
            // lblEndDateTime
            // 
            lblEndDateTime.AutoSize = true;
            lblEndDateTime.Font = new Font("Bahnschrift", 11.25F);
            lblEndDateTime.ForeColor = Color.DimGray;
            lblEndDateTime.Location = new Point(323, 50);
            lblEndDateTime.Name = "lblEndDateTime";
            lblEndDateTime.Size = new Size(79, 18);
            lblEndDateTime.TabIndex = 21;
            lblEndDateTime.Text = "Bitiş Tarihi";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(250, 401);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(261, 43);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 22;
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
            btnBack.Location = new Point(742, 403);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 46);
            btnBack.TabIndex = 23;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblEndDateTime);
            Controls.Add(lblStartDateTime);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(lblAccount);
            Controls.Add(comboBoxAccount);
            Controls.Add(lblCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(btnFilter);
            Controls.Add(dataGridViewTransactions);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Transactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Hareketler";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTransactions;
        private Button btnFilter;
        private Label lblCategory;
        private ComboBox comboBoxCategory;
        private Label lblAccount;
        private ComboBox comboBoxAccount;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label lblStartDateTime;
        private Label lblEndDateTime;
        private PictureBox pictureBoxLogo;
        private Button btnBack;
    }
}