using System;
using System.Data;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class OrderEdit : Form
    {
        private readonly int? orderId;

        public OrderEdit(int? id) { InitializeComponent(); orderId = id; }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            try
            {
                orderStatusesTableAdapter.Fill(obuvDBDataSet.OrderStatuses);
                pickupPointsTableAdapter.Fill(obuvDBDataSet.PickupPoints);
                ordersTableAdapter.Fill(obuvDBDataSet.Orders);

                if (orderId.HasValue)
                {
                    ordersBindingSource.Position = ordersBindingSource.Find("OrderId", orderId.Value);
                    tbId.Visible = true;
                }
                else
                {
                    ordersBindingSource.AddNew();
                    tbId.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); Close(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbArticle.Text.Trim() == "") { MessageBox.Show("Укажите артикул"); return; }
            if (dtpDeliv.Value < dtpOrder.Value) { MessageBox.Show("Дата выдачи раньше даты заказа"); return; }

            try
            {
                ordersBindingSource.EndEdit();
                ordersTableAdapter.Update(obuvDBDataSet.Orders);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void btnCancel_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
