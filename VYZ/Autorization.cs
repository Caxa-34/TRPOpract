using VYZ.Windows;

namespace VYZ
{
    public partial class Autorization : Form
    {
        List<string> logins = new List<string>(), passwords = new List<string>();
        int lvlAccess = 0;
        public Autorization()
        {
            InitializeComponent();
            logins.Add("admin");
            passwords.Add("admin");
        }

        bool logIn(string login, string password)
        {

            for (int i = 0; i < logins.Count; i++)
            {
                if (login == logins[i] & password == passwords[i])
                {
                    switch (i)
                    {
                        case 0:
                            lvlAccess = 1;
                            break;
                        case 1:
                            lvlAccess = 2;
                            break;
                        case 2:
                            lvlAccess = 2;
                            break;
                    }
                    return true;
                }
            }
            return false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text, password = txtPassword.Text;
            if (!logIn(login,  password))
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }
            MainMenu mainMenu = new MainMenu();
            mainMenu.Owner = this;
            mainMenu.Show();
            Hide();
        }
    }
}