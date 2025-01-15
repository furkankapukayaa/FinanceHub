using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.Enums;
using System.Data;

namespace FinanceHub.UserInterface
{
    public partial class CurrencyExchange : Form
    {
        public CurrencyExchange(string loggedInUserId)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            DataLoad();
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private string _loggedInUserId;

        public void DataLoad()
        {
            comboBoxCurrencyAccount.Items.Clear();
            comboBoxCurrencyAccount.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false || x.Currency == CurrencyType.Dolar || x.Currency == CurrencyType.Euro).Select(x => x.Name + " (" + x.Balance + " " + x.Currency.ToString() + ")").ToArray());

            comboBoxTurkishLiraAccount.Items.Clear();
            comboBoxTurkishLiraAccount.Items.AddRange(financeHubContext.Accounts.Where(x => x.IsDeleted == false && x.Currency == CurrencyType.TL).Select(x => x.Name + " (" + x.Balance + " " + x.Currency.ToString() + ")").ToArray());
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

        private void btnExchangeConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxCurrencyAccount.SelectedItem == null || comboBoxTurkishLiraAccount.SelectedItem == null || string.IsNullOrEmpty(txtExchangeAmount.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string currencyAccountName = comboBoxCurrencyAccount.SelectedItem.ToString().Split('(')[0].Trim();
                string turkishLiraAccountName = comboBoxTurkishLiraAccount.SelectedItem.ToString().Split('(')[0].Trim();
                int amount = Convert.ToInt32(txtExchangeAmount.Text);

                var currencyAccount = financeHubContext.Accounts.FirstOrDefault(x => x.Name == currencyAccountName);
                var turkishLiraAccount = financeHubContext.Accounts.FirstOrDefault(x => x.Name == turkishLiraAccountName);

                if (currencyAccount.Balance < amount)
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    currencyAccount.Balance -= amount;

                    if (currencyAccount.Currency == CurrencyType.Dolar)
                    {
                        turkishLiraAccount.Balance += amount * 35;
                        turkishLiraAccount.UpdatedAtTime = DateTime.Now;
                        currencyAccount.UpdatedAtTime = DateTime.Now;
                    }
                    else if (currencyAccount.Currency == CurrencyType.Euro)
                    {
                        turkishLiraAccount.Balance += amount * 36;
                        turkishLiraAccount.UpdatedAtTime = DateTime.Now;
                        currencyAccount.UpdatedAtTime = DateTime.Now;
                    }

                    financeHubContext.Update(currencyAccount);
                    financeHubContext.Update(turkishLiraAccount);
                    financeHubContext.SaveChanges();

                    MessageBox.Show("İşlem başarılı bir şekilde gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExchangeAmount.Clear();
                    DataLoad();
                }
            }
        }
    }
}