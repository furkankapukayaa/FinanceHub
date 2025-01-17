using FinanceHub.DataAccess.Context;
using FinanceHub.Entity.DomainObjects;
using FinanceHub.UserInterface.Events;

namespace FinanceHub.UserInterface
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private void OpenLoginPage()
        {
            Application.Run(new Login());
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenLoginPage);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtLastName.Text == string.Empty || txtEmail.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Şifreniz en az 8 karakterden oluşmalıdır.", "FinanceHub - Şifre hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
                    {
                        if (txtEmail.Text.Contains(" "))
                        {
                            MessageBox.Show("E-posta adresinizde boşluk olmamalıdır.", "FinanceHub - E-posta hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (txtEmail.Text.Contains("gmail.com") || txtEmail.Text.Contains("hotmail.com") || txtEmail.Text.Contains("outlook.com"))
                            {
                                MessageBox.Show("Kayıt işlemi başarılı.", "FinanceHub - Kayıt başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                User user = new User();
                                user.Name = txtName.Text;
                                user.LastName = txtLastName.Text;
                                user.Email = txtEmail.Text;
                                user.Password = txtPassword.Text;
                                user.Phone = txtPhone.Text;

                                financeHubContext.Users.Add(user);
                                financeHubContext.SaveChanges();

                                AppSettings appSettings = new AppSettings();
                                appSettings.CreateCategories(user.Id);

                                this.Close();
                                thread = new Thread(OpenLoginPage);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                            }
                            else
                            {
                                MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "FinanceHub - E-posta hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "FinanceHub - E-posta hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}