namespace FinanceHub
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccountOperations = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnUserOperations = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(210, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblDateTime.Location = new System.Drawing.Point(682, 34);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(74, 16);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = "TarihVeSaat";
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(740, 392);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAccountOperations
            // 
            this.btnAccountOperations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountOperations.FlatAppearance.BorderSize = 0;
            this.btnAccountOperations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccountOperations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccountOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountOperations.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccountOperations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccountOperations.ImageKey = "accountOperations.png";
            this.btnAccountOperations.ImageList = this.imageList;
            this.btnAccountOperations.Location = new System.Drawing.Point(146, 183);
            this.btnAccountOperations.Name = "btnAccountOperations";
            this.btnAccountOperations.Size = new System.Drawing.Size(117, 112);
            this.btnAccountOperations.TabIndex = 1;
            this.btnAccountOperations.Text = "Hesap İşlemleri";
            this.btnAccountOperations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccountOperations.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "accountOperations.png");
            this.imageList.Images.SetKeyName(1, "categories.png");
            this.imageList.Images.SetKeyName(2, "exchange.png");
            this.imageList.Images.SetKeyName(3, "overview.png");
            this.imageList.Images.SetKeyName(4, "transactions.png");
            this.imageList.Images.SetKeyName(5, "userOperations.png");
            // 
            // btnTransactions
            // 
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransactions.ImageKey = "transactions.png";
            this.btnTransactions.ImageList = this.imageList;
            this.btnTransactions.Location = new System.Drawing.Point(402, 184);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(117, 113);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Hareketler";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategories.ImageKey = "categories.png";
            this.btnCategories.ImageList = this.imageList;
            this.btnCategories.Location = new System.Drawing.Point(525, 183);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(117, 112);
            this.btnCategories.TabIndex = 4;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnOverview
            // 
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOverview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOverview.ImageKey = "overview.png";
            this.btnOverview.ImageList = this.imageList;
            this.btnOverview.Location = new System.Drawing.Point(12, 184);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(117, 112);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "Genel Bakış";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOverview.UseVisualStyleBackColor = true;
            // 
            // btnUserOperations
            // 
            this.btnUserOperations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserOperations.FlatAppearance.BorderSize = 0;
            this.btnUserOperations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserOperations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserOperations.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserOperations.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserOperations.ImageKey = "userOperations.png";
            this.btnUserOperations.ImageList = this.imageList;
            this.btnUserOperations.Location = new System.Drawing.Point(661, 184);
            this.btnUserOperations.Name = "btnUserOperations";
            this.btnUserOperations.Size = new System.Drawing.Size(127, 113);
            this.btnUserOperations.TabIndex = 5;
            this.btnUserOperations.Text = "Kullanıcı İşlemleri";
            this.btnUserOperations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserOperations.UseVisualStyleBackColor = true;
            // 
            // btnExchange
            // 
            this.btnExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExchange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExchange.ImageKey = "exchange.png";
            this.btnExchange.ImageList = this.imageList;
            this.btnExchange.Location = new System.Drawing.Point(279, 183);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(117, 112);
            this.btnExchange.TabIndex = 2;
            this.btnExchange.Text = "Döviz İşlemleri";
            this.btnExchange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExchange.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.lblWelcome.Location = new System.Drawing.Point(9, 422);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(105, 16);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Hoş Geldin User!";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.btnUserOperations);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnAccountOperations);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccountOperations;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnUserOperations;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Label lblWelcome;
    }
}