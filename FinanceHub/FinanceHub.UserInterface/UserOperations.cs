using FinanceHub.DataAccess.Context;

namespace FinanceHub.UserInterface
{
    public partial class UserOperations : Form
    {
        public UserOperations(string loggedInUserId)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            GetUser();
        }

        public FinanceHubContext financeHubContext = new FinanceHubContext();
        public Thread? thread;
        private string _loggedInUserId;

        public void GetUser()
        {
            var user = financeHubContext.Users.FirstOrDefault(x => x.Id == _loggedInUserId);
            if (user != null)
            {
                txtName.Text = user.Name;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.Password;
                txtPhone.Text = user.Phone;
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtLastName.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
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
                                var user = financeHubContext.Users.FirstOrDefault(x => x.Id == _loggedInUserId);
                                if (user != null)
                                {
                                    user.Name = txtName.Text;
                                    user.LastName = txtLastName.Text;
                                    user.Email = txtEmail.Text;
                                    user.Password = txtPassword.Text;
                                    user.Phone = txtPhone.Text;
                                    user.UpdatedAtTime = DateTime.Now;

                                    financeHubContext.Users.Update(user);
                                    financeHubContext.SaveChanges();
                                    MessageBox.Show("Güncelleme işlemi başarılı.", "FinanceHub", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir e-posta adresi giriniz.", "FinanceHub - E-posta hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "FinanceHub - Boş alan hatası!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}