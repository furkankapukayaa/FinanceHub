using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;

namespace FinanceHub.UserInterface
{
    public partial class Categories : Form
    {
        public Categories(string loggedInUserId)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            DataList();
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private string _loggedInUserId;

        public void DataList()
        {
            dataGridViewCategories.DataSource = financeHubContext.Categories.Where(x => x.IsDeleted == false && x.UserId == _loggedInUserId).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewCategories.Columns["Id"].Visible = false;
            dataGridViewCategories.Columns["UserId"].Visible = false;
            dataGridViewCategories.Columns["IsDeleted"].Visible = false;
            dataGridViewCategories.Columns["CreatedAtTime"].Visible = false;
            dataGridViewCategories.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewCategories.Columns["DeletedAtTime"].Visible = false;
            dataGridViewCategories.Columns["Status"].Visible = false;

            dataGridViewCategories.Columns["Name"].HeaderText = "Kategori Adı";

            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCategories.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewCategories.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewCategories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCategories.EnableHeadersVisualStyles = false;
            dataGridViewCategories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCategories.AllowUserToResizeRows = false;

            txtCategoryName.Clear();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                Category category = new Category
                {
                    UserId = _loggedInUserId,
                    Name = txtCategoryName.Text,
                };

                financeHubContext.Categories.Add(category);
                financeHubContext.SaveChanges();

                MessageBox.Show("Kategori ekleme işlemi başarılı.", "FinanceHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string selectedCategoryId;
        private void dataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var categoryId = dataGridViewCategories.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedCategoryId = categoryId;
                var category = financeHubContext.Categories.FirstOrDefault(x => x.Id == categoryId);

                if (category != null)
                {
                    txtCategoryName.Text = category.Name;
                }
            }
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategoryName.Text) && selectedCategoryId != null)
            {
                var category = financeHubContext.Categories.FirstOrDefault(x => x.Id == selectedCategoryId);
                if (category != null)
                {
                    category.Name = txtCategoryName.Text;

                    financeHubContext.Categories.Update(category);
                    financeHubContext.SaveChanges();
                    MessageBox.Show("Kategori güncelleme işlemi başarılı.", "FinanceHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kategori silme işlemi yapmak istediğinize emin misiniz?", "FinanceHub - Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedCategoryId != null && dialogResult == DialogResult.Yes)
            {
                var category = financeHubContext.Categories.FirstOrDefault(x => x.Id == selectedCategoryId);
                if (category != null)
                {
                    category.IsDeleted = true;
                    category.DeletedAtTime = DateTime.Now;
                    financeHubContext.Categories.Update(category);
                    financeHubContext.SaveChanges();

                    MessageBox.Show("Kategori silme işlemi başarılı.", "FinanceHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataList();
                }
            }
        }

        private void OpenMainMenuPage()
        {
            Application.Run(new MainMenu(_loggedInUserId));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenMainMenuPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}