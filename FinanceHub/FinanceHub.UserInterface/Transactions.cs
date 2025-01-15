using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;
using Microsoft.EntityFrameworkCore;

namespace FinanceHub.UserInterface
{
    public partial class Transactions : Form
    {
        public Transactions(string loggedInUserId)
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
            comboBoxAccount.Items.Clear();
            comboBoxAccount.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false).Select(x => x.Name).ToArray());

            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(financeHubContext.Categories.Where(x => x.IsDeleted == false).Select(x => x.Name).ToArray());

            dataGridViewTransactions.DataSource = financeHubContext.Spendings.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).Include(x => x.Category).Include(x => x.Account).ToList();

            dataGridViewTransactions.Columns["Id"].Visible = false;
            dataGridViewTransactions.Columns["IsDeleted"].Visible = false;
            dataGridViewTransactions.Columns["CreatedAtTime"].Visible = false;
            dataGridViewTransactions.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewTransactions.Columns["DeletedAtTime"].Visible = false;
            dataGridViewTransactions.Columns["Status"].Visible = false;

            dataGridViewTransactions.Columns["Category"].HeaderText = "Kategori";
            dataGridViewTransactions.Columns["Amount"].HeaderText = "Tutar";
            dataGridViewTransactions.Columns["Account"].HeaderText = "Hesap";
            dataGridViewTransactions.Columns["OldBalance"].HeaderText = "Eski Bakiye";
            dataGridViewTransactions.Columns["AvaibleBalance"].HeaderText = "Yeni Bakiye";
            dataGridViewTransactions.Columns["SpendingDate"].HeaderText = "İşlem Tarihi";
            dataGridViewTransactions.Columns["Business"].HeaderText = "İşletme Adı";

            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTransactions.EnableHeadersVisualStyles = false;
            dataGridViewTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTransactions.AllowUserToResizeRows = false;
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

        private void dataGridViewTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewTransactions.Columns["Category"].Index)
                {
                    var category = e.Value as Category;
                    e.Value = category?.Name ?? "Category bilgisi alınamadı";
                }

                if (e.ColumnIndex == dataGridViewTransactions.Columns["Account"].Index)
                {
                    var account = e.Value as Account;
                    e.Value = account?.Name ?? "Account bilgisi alınamadı";
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value.Date > dateTimePickerEnd.Value.Date)
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden büyük olamaz.");
                return;
            }

            if (dateTimePickerEnd.Value.Date < dateTimePickerStart.Value.Date)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden küçük olamaz.");
                return;
            }

            var query = financeHubContext.Spendings
                .Where(x => x.IsDeleted == false)
                .AsQueryable();

            if (dateTimePickerStart.Value.Date == dateTimePickerEnd.Value.Date)
            {
                query = query.Where(x => x.CreatedAtTime.Date == dateTimePickerStart.Value.Date);
            }
            else
            {
                query = query.Where(x => x.CreatedAtTime >= dateTimePickerStart.Value && x.CreatedAtTime <= dateTimePickerEnd.Value);
            }

            if (comboBoxAccount.SelectedItem != null)
            {
                query = query.Where(x => x.Account.Name == comboBoxAccount.SelectedItem.ToString());
            }

            if (comboBoxCategory.SelectedItem != null)
            {
                query = query.Where(x => x.Category.Name == comboBoxCategory.SelectedItem.ToString());
            }

            query = query.Include(x => x.Category)
                         .Include(x => x.Account)
                         .OrderByDescending(x => x.CreatedAtTime);

            dataGridViewTransactions.DataSource = query.ToList();
            btnFilterReset.Visible = true;
        }

        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            dataGridViewTransactions.DataSource = financeHubContext.Spendings.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).Include(x => x.Category).Include(x => x.Account).ToList();
            comboBoxCategory.SelectedIndex = -1;
            comboBoxAccount.SelectedIndex = -1;
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
            btnFilterReset.Visible = false;
        }
    }
}