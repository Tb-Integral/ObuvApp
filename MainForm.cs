using System;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class MainForm : Form
    {
        private readonly string fullName;
        private readonly string roleName;
        private ProductList ucProducts;
        private OrderList ucOrders;

        public MainForm(string fullName, string roleName)
        {
            InitializeComponent();
            this.fullName = fullName;
            this.roleName = roleName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = fullName;

            bool isManager = roleName == "Менеджер" || roleName == "Администратор";
            btnOrders.Visible = isManager;

            ucProducts = new ProductList(roleName);
            ShowPage(ucProducts, false);
        }

        private void ShowPage(UserControl uc, bool canBack)
        {
            DownPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            DownPanel.Controls.Add(uc);
            btnBack.Visible = canBack;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (ucOrders == null) ucOrders = new OrderList(roleName);
            ShowPage(ucOrders, true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPage(ucProducts, false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
