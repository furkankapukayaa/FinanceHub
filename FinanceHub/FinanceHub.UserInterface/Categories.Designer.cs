namespace FinanceHub.UserInterface
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            dataGridViewCategories = new DataGridView();
            btnBack = new Button();
            btnCategoryDelete = new Button();
            btnCategoryUpdate = new Button();
            btnCategoryAdd = new Button();
            groupBoxCategoryOperations = new GroupBox();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            groupBoxCategoryOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Bahnschrift", 11.25F);
            lblCategoryName.ForeColor = Color.DimGray;
            lblCategoryName.Location = new Point(7, 49);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(26, 18);
            lblCategoryName.TabIndex = 11;
            lblCategoryName.Text = "Ad";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Bahnschrift", 11.25F);
            txtCategoryName.Location = new Point(39, 46);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(177, 26);
            txtCategoryName.TabIndex = 9;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.AllowUserToDeleteRows = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(12, 207);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.Size = new Size(493, 231);
            dataGridViewCategories.TabIndex = 16;
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
            btnBack.Location = new Point(511, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 46);
            btnBack.TabIndex = 17;
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.Cursor = Cursors.Hand;
            btnCategoryDelete.Font = new Font("Bahnschrift", 9.75F);
            btnCategoryDelete.Location = new Point(401, 40);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(77, 39);
            btnCategoryDelete.TabIndex = 20;
            btnCategoryDelete.Text = "Sil";
            btnCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.Cursor = Cursors.Hand;
            btnCategoryUpdate.Font = new Font("Bahnschrift", 9.75F);
            btnCategoryUpdate.Location = new Point(318, 40);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(77, 39);
            btnCategoryUpdate.TabIndex = 19;
            btnCategoryUpdate.Text = "Güncelle";
            btnCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Cursor = Cursors.Hand;
            btnCategoryAdd.Font = new Font("Bahnschrift", 9.75F);
            btnCategoryAdd.Location = new Point(235, 40);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(77, 39);
            btnCategoryAdd.TabIndex = 18;
            btnCategoryAdd.Text = "Ekle";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategoryOperations
            // 
            groupBoxCategoryOperations.Controls.Add(btnCategoryDelete);
            groupBoxCategoryOperations.Controls.Add(txtCategoryName);
            groupBoxCategoryOperations.Controls.Add(btnCategoryUpdate);
            groupBoxCategoryOperations.Controls.Add(lblCategoryName);
            groupBoxCategoryOperations.Controls.Add(btnCategoryAdd);
            groupBoxCategoryOperations.Font = new Font("Bahnschrift", 11.25F);
            groupBoxCategoryOperations.Location = new Point(12, 101);
            groupBoxCategoryOperations.Name = "groupBoxCategoryOperations";
            groupBoxCategoryOperations.Size = new Size(493, 100);
            groupBoxCategoryOperations.TabIndex = 21;
            groupBoxCategoryOperations.TabStop = false;
            groupBoxCategoryOperations.Text = "Kategori İşlemleri";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(141, 15);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(256, 80);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 22;
            pictureBoxLogo.TabStop = false;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 450);
            Controls.Add(pictureBoxLogo);
            Controls.Add(groupBoxCategoryOperations);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewCategories);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinanceHub - Kategoriler";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            groupBoxCategoryOperations.ResumeLayout(false);
            groupBoxCategoryOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private DataGridView dataGridViewCategories;
        private Button btnBack;
        private Button btnCategoryDelete;
        private Button btnCategoryUpdate;
        private Button btnCategoryAdd;
        private GroupBox groupBoxCategoryOperations;
        private PictureBox pictureBoxLogo;
    }
}