using System;
using System.Data;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class UcOrderCard : UserControl
    {
        public int OrderId { get; private set; }
        public event EventHandler CardClicked;

        public UcOrderCard()
        {
            InitializeComponent();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetData(DataRowView row, string address)
        {
            OrderId = Convert.ToInt32(row["OrderId"]);

            lblArticle.Text = row["OrderActicle"].ToString();
            lblStatus.Text = "Статус: " + row["StatusName"];
            lblAddress.Text = "Адрес: " + address;
            lblOrderDate.Text = "Дата заказа: " +
                Convert.ToDateTime(row["OrderDate"]).ToString("dd.MM.yyyy");
            lblDelivDate.Text = "Доставка\n" +
                Convert.ToDateTime(row["DeliveryDate"]).ToString("dd.MM.yyyy");
        }
    }
}
