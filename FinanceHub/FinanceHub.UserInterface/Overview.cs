using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.Enums;

namespace FinanceHub.UserInterface
{
    public partial class Overview : Form
    {
        public Overview(string loggedInUserId)
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
            lblMonthlyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Month == DateTime.Now.Month && x.Account.Currency == CurrencyType.TL).Sum(x => x.Amount).ToString() + "₺";
            lblWeeklyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Day >= DateTime.Now.Day - 7 && x.Account.Currency == CurrencyType.TL).Sum(x => x.Amount).ToString() + "₺";
            lblDailyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Day == DateTime.Now.Day && x.Account.Currency == CurrencyType.TL).Sum(x => x.Amount).ToString() + "₺";
            lblMonthlyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Month == DateTime.Now.Month && x.Account.Currency == CurrencyType.TL).Sum(x => x.Amount).ToString() + "₺";
            lblWeeklyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Day >= DateTime.Now.Day - 7 && x.Account.Currency == CurrencyType.TL).Sum(x => x.Amount).ToString() + "₺";
            lblDailyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Day == DateTime.Now.Day && x.Account.Currency == CurrencyType.TL).Sum(x => x.Amount).ToString() + "₺";
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

        private void btnTurkishLira_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnDollar_Click(object sender, EventArgs e)
        {
            lblMonthlyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Month == DateTime.Now.Month && x.Account.Currency == CurrencyType.Dolar).Sum(x => x.Amount).ToString() + "$";
            lblWeeklyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Day >= DateTime.Now.Day - 7 && x.Account.Currency == CurrencyType.Dolar).Sum(x => x.Amount).ToString() + "$";
            lblDailyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Day == DateTime.Now.Day && x.Account.Currency == CurrencyType.Dolar).Sum(x => x.Amount).ToString() + "$";
            lblMonthlyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Month == DateTime.Now.Month && x.Account.Currency == CurrencyType.Dolar).Sum(x => x.Amount).ToString() + "$";
            lblWeeklyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Day >= DateTime.Now.Day - 7 && x.Account.Currency == CurrencyType.Dolar).Sum(x => x.Amount).ToString() + "$";
            lblDailyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Day == DateTime.Now.Day && x.Account.Currency == CurrencyType.Dolar).Sum(x => x.Amount).ToString() + "$";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            lblMonthlyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Month == DateTime.Now.Month && x.Account.Currency == CurrencyType.Euro).Sum(x => x.Amount).ToString() + "€";
            lblWeeklyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Day >= DateTime.Now.Day - 7 && x.Account.Currency == CurrencyType.Euro).Sum(x => x.Amount).ToString() + "€";
            lblDailyExpensesAmount.Text = financeHubContext.Spendings.Where(x => x.Account.Owner.Id == _loggedInUserId && x.SpendingDate.Day == DateTime.Now.Day && x.Account.Currency == CurrencyType.Euro).Sum(x => x.Amount).ToString() + "€";
            lblMonthlyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Month == DateTime.Now.Month && x.Account.Currency == CurrencyType.Euro).Sum(x => x.Amount).ToString() + "€";
            lblWeeklyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Day >= DateTime.Now.Day - 7 && x.Account.Currency == CurrencyType.Euro).Sum(x => x.Amount).ToString() + "€";
            lblDailyIncomeAmount.Text = financeHubContext.Incomes.Where(x => x.Account.Owner.Id == _loggedInUserId && x.IncomeDate.Day == DateTime.Now.Day && x.Account.Currency == CurrencyType.Euro).Sum(x => x.Amount).ToString() + "€";
        }
    }
}