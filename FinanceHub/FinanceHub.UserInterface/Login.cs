using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;
using FinanceHub.UserInterface.Events;

namespace FinanceHub.UserInterface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AppSettings appSettings = new AppSettings();
            appSettings.CreateDemoUser();
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private User user { get; set; }

        private void OpenRegisterPage()
        {
            Application.Run(new Register());
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenRegisterPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenMainMenuPage()
        {
            Application.Run(new MainMenu(user.Id));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                user = financeHubContext.Users.FirstOrDefault(u => u.Email == txtEmail.Text && u.Password == txtPassword.Text);
                if (user != null)
                {
                    this.Close();
                    thread = new Thread(OpenMainMenuPage);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("E-posta adresiniz veya şifreniz hatalı.", "FinanceHub - Giriş hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}