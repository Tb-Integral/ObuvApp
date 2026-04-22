using System;
using System.Data;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class OrderList : UserControl
    {
        private readonly string roleName;
        private bool IsAdmin;
        private int selectedOrderId;

        public OrderList(string roleName)
        {
            InitializeComponent();
            this.roleName = roleName;
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            IsAdmin = roleName == "Администратор";
            pnlTools.Visible = IsAdmin;

            try
            {
                ordersTableAdapter.Fill(obuvDBDataSet.Orders);
                pickupPointsTableAdapter.Fill(obuvDBDataSet.PickupPoints);
                ordersBindingSource.DataSource = obuvDBDataSet.Orders;
                RenderCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAddress(int pickupPointId)
        {
            for (int i = 0; i < obuvDBDataSet.PickupPoints.Count; i++)
                if (obuvDBDataSet.PickupPoints[i].PickupPointsId == pickupPointId)
                    return obuvDBDataSet.PickupPoints[i].Address;
            return "";
        }

        private void RenderCards()
        {
            pnlCards.Controls.Clear();
            int width = pnlCards.ClientSize.Width - pnlCards.Padding.Horizontal - 20;

            for (int i = 0; i < ordersBindingSource.Count; i++)
            {
                DataRowView row = (DataRowView)ordersBindingSource[i];
                string address = GetAddress(Convert.ToInt32(row["PickupPointId"]));

                UcOrderCard card = new UcOrderCard();
                card.SetData(row, address);
                card.Width = width;
                card.Margin = new Padding(0, 0, 0, 8);
                card.CardClicked += Card_CardClicked;
                pnlCards.Controls.Add(card);
            }
        }

        private void Card_CardClicked(object sender, EventArgs e)
        {
            UcOrderCard c = (UcOrderCard)sender;
            selectedOrderId = c.OrderId;

            if (!IsAdmin)
            {
                MessageBox.Show("Редактирование доступно только администратору",
                    "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenEdit(selectedOrderId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenEdit(null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == 0)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            try
            {
                ordersTableAdapter.DeteteItemsByOrderId(selectedOrderId);
                selectedOrderId = 0;
                ordersTableAdapter.Fill(obuvDBDataSet.Orders);
                RenderCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenEdit(int? id)
        {
            OrderEdit f = new OrderEdit(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                ordersTableAdapter.Fill(obuvDBDataSet.Orders);
                RenderCards();
            }
        }
    }
}
