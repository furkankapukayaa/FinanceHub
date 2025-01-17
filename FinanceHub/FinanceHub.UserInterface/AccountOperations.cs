using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;
using FinanceHub.Entity.Enums;
using Microsoft.EntityFrameworkCore;

namespace FinanceHub.UserInterface
{
    public partial class AccountOperations : Form
    {
        public AccountOperations(string loggedInUserId)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            DataList();
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private string _loggedInUserId;

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

        public void DataList()
        {
            comboBoxAccountType.Items.Clear();
            comboBoxAccountType.Items.AddRange(Enum.GetValues(typeof(AccountType))
                .Cast<AccountType>()
                .Select(x => x.ToString())
                .ToArray());

            comboBoxAccountCurrency.Items.Clear();
            comboBoxAccountCurrency.Items.AddRange(Enum.GetValues(typeof(CurrencyType))
                .Cast<CurrencyType>()
                .Select(x => x.ToString())
                .ToArray());

            comboBoxBalanceAccountUsed.Items.Clear();
            comboBoxBalanceAccountUsed.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false).Select(x => x.Name).ToArray());

            comboBoxSpendingAccountUsed.Items.Clear();
            comboBoxSpendingAccountUsed.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false).Select(x => x.Name).ToArray());

            comboBoxSpendingCategory.Items.Clear();
            comboBoxSpendingCategory.Items.AddRange(financeHubContext.Categories.Where(x => x.IsDeleted == false && x.UserId == _loggedInUserId).Select(x => x.Name).ToArray());

            comboBoxMoneyTransferSendingAccount.Items.Clear();
            comboBoxMoneyTransferSendingAccount.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false).Select(x => x.Name).ToArray());

            comboBoxMoneyTransferReceivingAccount.Items.Clear();
            comboBoxMoneyTransferReceivingAccount.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false).Select(x => x.Name).ToArray());

            dataGridViewAccounts.DataSource = financeHubContext.Accounts.Where(x => x.IsDeleted == false).Include(x => x.Owner).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewAccounts.Columns["Id"].Visible = false;
            dataGridViewAccounts.Columns["IsDeleted"].Visible = false;
            dataGridViewAccounts.Columns["CreatedAtTime"].Visible = false;
            dataGridViewAccounts.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewAccounts.Columns["DeletedAtTime"].Visible = false;
            dataGridViewAccounts.Columns["Status"].Visible = false;

            dataGridViewAccounts.Columns["No"].DisplayIndex = 0;
            dataGridViewAccounts.Columns["No"].HeaderText = "Hesap Numarası";
            dataGridViewAccounts.Columns["Owner"].HeaderText = "Hesap Sahibi";
            dataGridViewAccounts.Columns["Name"].HeaderText = "Hesap Adı";
            dataGridViewAccounts.Columns["Balance"].HeaderText = "Bakiye";
            dataGridViewAccounts.Columns["Currency"].HeaderText = "Para Birimi";
            dataGridViewAccounts.Columns["Type"].HeaderText = "Hesap Türü";

            dataGridViewAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAccounts.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewAccounts.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewAccounts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAccounts.EnableHeadersVisualStyles = false;
            dataGridViewAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAccounts.AllowUserToResizeRows = false;

            ClearInput();
        }

        public void ClearInput()
        {
            txtAccountNo.Clear();
            txtAccountOwner.Clear();
            txtAccountName.Clear();
            txtAccountBalance.Clear();
            comboBoxAccountCurrency.SelectedIndex = -1;
            comboBoxAccountType.SelectedIndex = -1;
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountName.Text) || string.IsNullOrWhiteSpace(txtAccountBalance.Text) || comboBoxAccountCurrency.SelectedIndex == -1 || comboBoxAccountType.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Random random = new Random();
                int accountNo = random.Next(1000000000, 2147483647);
                while (financeHubContext.Accounts.Any(x => x.No == accountNo))
                {
                    accountNo = random.Next(1000000000, 2147483647);
                }

                Account account = new Account
                {
                    No = accountNo,
                    Owner = financeHubContext.Users.FirstOrDefault(u => u.Id == _loggedInUserId),
                    Name = txtAccountName.Text,
                    Balance = Convert.ToInt32(txtAccountBalance.Text),
                    Currency = (CurrencyType)Enum.Parse(typeof(CurrencyType), comboBoxAccountCurrency.SelectedItem.ToString()),
                    Type = (AccountType)Enum.Parse(typeof(AccountType), comboBoxAccountType.SelectedItem.ToString())
                };

                financeHubContext.Accounts.Add(account);
                financeHubContext.SaveChanges();
                selectedAccountId = null;
                DataList();
            }
        }

        private void dataGridViewAccounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewAccounts.Columns["Owner"].Index)
                {
                    var owner = e.Value as User;

                    if (owner != null)
                    {
                        e.Value = owner.Name + " " + owner.LastName;
                    }
                    else
                    {
                        e.Value = "Owner bilgisi alınamadı";
                    }
                }
            }
        }

        private string selectedAccountId;

        private void dataGridViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var accountId = dataGridViewAccounts.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedAccountId = accountId;
                var account = financeHubContext.Accounts.FirstOrDefault(x => x.Id == accountId);

                if (account != null)
                {
                    txtAccountNo.Text = account.No.ToString();
                    txtAccountOwner.Text = account.Owner.Name + " " + account.Owner.LastName;
                    txtAccountName.Text = account.Name;
                    txtAccountBalance.Text = account.Balance.ToString();
                    comboBoxAccountCurrency.SelectedItem = account.Currency.ToString();
                    comboBoxAccountType.SelectedItem = account.Type.ToString();
                }
            }

            txtAccountBalance.Enabled = false;
            comboBoxAccountCurrency.Enabled = false;
            comboBoxAccountType.Enabled = false;
            btnClearSelected.Visible = true;
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountName.Text) || selectedAccountId == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var account = financeHubContext.Accounts.FirstOrDefault(x => x.Id == selectedAccountId);
                if (account != null)
                {
                    account.Name = txtAccountName.Text;
                    account.UpdatedAtTime = DateTime.UtcNow;

                    financeHubContext.Accounts.Update(account);
                    financeHubContext.SaveChanges();

                    txtAccountBalance.Enabled = true;
                    comboBoxAccountCurrency.Enabled = true;
                    comboBoxAccountType.Enabled = true;
                    selectedAccountId = null;
                    DataList();
                }
            }
        }

        private void btnAccountDelete_Click(object sender, EventArgs e)
        {
            if (selectedAccountId == null)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.", "FinanceHub - Hesap Seçme Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Hesap silme işlemi yapmak istediğinize emin misiniz?", "FinanceHub - Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var account = financeHubContext.Accounts.FirstOrDefault(x => x.Id == selectedAccountId);
                    if (account != null)
                    {
                        account.IsDeleted = true;
                        account.DeletedAtTime = DateTime.UtcNow;

                        financeHubContext.Accounts.Update(account);
                        financeHubContext.SaveChanges();

                        txtAccountBalance.Enabled = true;
                        comboBoxAccountCurrency.Enabled = true;
                        comboBoxAccountType.Enabled = true;
                        DataList();
                    }
                }
            }
        }

        private void btnBalanceConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalanceAmount.Text) || comboBoxBalanceAccountUsed.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var account = financeHubContext.Accounts.FirstOrDefault(x => x.Name == comboBoxBalanceAccountUsed.SelectedItem.ToString() && x.IsDeleted == false);
                if (account != null)
                {
                    account.Balance += Convert.ToInt32(txtBalanceAmount.Text);
                    account.UpdatedAtTime = DateTime.UtcNow;

                    financeHubContext.Accounts.Update(account);

                    Income income = new Income
                    {
                        Account = account,
                        Amount = Convert.ToInt32(txtBalanceAmount.Text),
                        OldBalance = account.Balance - Convert.ToInt32(txtBalanceAmount.Text),
                        AvaibleBalance = account.Balance,
                        IncomeDate = DateTime.UtcNow
                    };

                    financeHubContext.Incomes.Add(income);
                    financeHubContext.SaveChanges();

                    txtBalanceAmount.Clear();
                    DataList();
                }
            }
        }

        private void btnMoneyTransferConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMoneyTransferAmount.Text) || comboBoxMoneyTransferSendingAccount.SelectedIndex == -1 || comboBoxMoneyTransferReceivingAccount.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var sendingAccount = financeHubContext.Accounts.FirstOrDefault(x => x.Name == comboBoxMoneyTransferSendingAccount.SelectedItem.ToString() && x.IsDeleted == false);
                var receivingAccount = financeHubContext.Accounts.FirstOrDefault(x => x.Name == comboBoxMoneyTransferReceivingAccount.SelectedItem.ToString() && x.IsDeleted == false);
                if (sendingAccount != null && receivingAccount != null)
                {
                    if (sendingAccount.Balance >= Convert.ToInt32(txtMoneyTransferAmount.Text))
                    {
                        if (sendingAccount.Id == receivingAccount.Id)
                        {
                            MessageBox.Show("Gönderen hesap ile alıcı hesap aynı olamaz.", "FinanceHub - Hesap Uyuşmazlık Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (sendingAccount.Currency != receivingAccount.Currency)
                        {
                            MessageBox.Show("Gönderen hesap ile alıcı hesabın para birimleri aynı olmalıdır.", "FinanceHub - Para Birimi Uyuşmazlık Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        sendingAccount.Balance -= Convert.ToInt32(txtMoneyTransferAmount.Text);
                        receivingAccount.Balance += Convert.ToInt32(txtMoneyTransferAmount.Text);
                        sendingAccount.UpdatedAtTime = DateTime.UtcNow;
                        receivingAccount.UpdatedAtTime = DateTime.UtcNow;
                        financeHubContext.Accounts.Update(sendingAccount);
                        financeHubContext.Accounts.Update(receivingAccount);
                        financeHubContext.SaveChanges();
                        txtMoneyTransferAmount.Clear();
                        DataList();
                    }
                    else
                    {
                        MessageBox.Show("Gönderen hesabın bakiyesi yetersizdir.", "FinanceHub - Bakiye Yetersizlik Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSpendingConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpendingAmount.Text) || string.IsNullOrWhiteSpace(txtSpendingBusiness.Text) || comboBoxSpendingAccountUsed.SelectedIndex == -1 || comboBoxSpendingCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var account = financeHubContext.Accounts.FirstOrDefault(x => x.Name == comboBoxSpendingAccountUsed.SelectedItem.ToString() && x.IsDeleted == false);
                var category = financeHubContext.Categories.FirstOrDefault(x => x.Name == comboBoxSpendingCategory.SelectedItem.ToString() && x.IsDeleted == false);

                if (account != null && category != null)
                {
                    if (account.Balance >= Convert.ToInt32(txtSpendingAmount.Text))
                    {
                        account.Balance -= Convert.ToInt32(txtSpendingAmount.Text);
                        account.UpdatedAtTime = DateTime.UtcNow;
                        financeHubContext.Accounts.Update(account);

                        Spending spending = new Spending
                        {
                            Category = category,
                            Amount = Convert.ToInt32(txtSpendingAmount.Text),
                            Account = account,
                            OldBalance = account.Balance + Convert.ToInt32(txtSpendingAmount.Text),
                            AvaibleBalance = account.Balance,
                            SpendingDate = DateTime.UtcNow,
                            Business = txtSpendingBusiness.Text
                        };

                        financeHubContext.Spendings.Add(spending);
                        financeHubContext.SaveChanges();
                        txtSpendingAmount.Clear();
                        txtSpendingBusiness.Clear();
                        DataList();
                    }
                    else
                    {
                        MessageBox.Show("Hesabın bakiyesi yetersizdir.", "FinanceHub - Bakiye Yetersizlik Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtAccountBalance.Enabled = true;
            comboBoxAccountCurrency.Enabled = true;
            comboBoxAccountType.Enabled = true;
            btnClearSelected.Visible = false;
        }
    }
}