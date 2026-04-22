using System;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usersTableAdapter.Fill(obuvDBDataSet.Users);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = usersTableAdapter.GetDataByLogPass(tbLogin.Text, tbPass.Text);

                if (dt.Count == 0)
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                OpenMain(dt[0].FullName, dt[0].RoleName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            OpenMain("Гость", "Гость");
        }

        private void OpenMain(string fullName, string roleName)
        {
            MainForm mf = new MainForm(fullName, roleName);
            Hide();
            mf.FormClosed += (s, e) => { tbPass.Text = ""; Show(); };
            mf.Show();
        }
    }
}
