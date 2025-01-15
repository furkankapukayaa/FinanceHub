using FinanceHub.DataAccess.Context;

namespace FinanceHub.UserInterface
{
    public partial class MainMenu : Form
    {
        public MainMenu(string loggedInUserId)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            timerCalendar.Start();
            lblWelcomeUser.Text = "Hoş geldin, " + financeHubContext.Users.FirstOrDefault(u => u.Id == _loggedInUserId).Name + " " + financeHubContext.Users.FirstOrDefault(u => u.Id == _loggedInUserId).LastName;
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private string _loggedInUserId;

        private void OpenLoginPage()
        {
            Application.Run(new Login());
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenLoginPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void timerCalendar_Tick(object sender, EventArgs e)
        {
            lblCalendar.Text = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).ToString("D") + "\n" + TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).ToString("T");
        }
        private void OpenUserOperationsPage()
        {
            Application.Run(new UserOperations(_loggedInUserId));
        }
        private void btnUserOperations_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenUserOperationsPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenOverviewPage()
        {
            Application.Run(new Overview(_loggedInUserId));
        }
        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenOverviewPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenAccountOperationsPage()
        {
            Application.Run(new AccountOperations(_loggedInUserId));
        }
        private void btnAccountOperations_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAccountOperationsPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenCurrencyExchangePage()
        {
            Application.Run(new CurrencyExchange(_loggedInUserId));
        }
        private void btnExchange_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenCurrencyExchangePage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenTransactionsPage()
        {
            Application.Run(new Transactions(_loggedInUserId));
        }
        private void btnTransactions_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenTransactionsPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenCategoriesPage()
        {
            Application.Run(new Categories(_loggedInUserId));
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenCategoriesPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}