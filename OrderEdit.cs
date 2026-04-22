using System;
using System.Data;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class OrderEdit : Form
    {
        private readonly int? orderId;

        public OrderEdit(int? orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            try
            {
                orderStatusesTableAdapter.Fill(obuvDBDataSet.OrderStatuses);
                pickupPointsTableAdapter.Fill(obuvDBDataSet.PickupPoints);
                ordersTableAdapter.Fill(obuvDBDataSet.Orders);

                if (orderId.HasValue)
                {
                    int pos = ordersBindingSource.Find("OrderId", orderId.Value);
                    if (pos >= 0) ordersBindingSource.Position = pos;
                    tbId.Visible = true;
                }
                else
                {
                    ordersBindingSource.AddNew();
                    DataRowView row = (DataRowView)ordersBindingSource.Current;
                    row["OrderActicle"] = "";
                    row["OrderDate"] = DateTime.Today;
                    row["DeliveryDate"] = DateTime.Today;
                    row["StatusName"] = cbStatus.Text;
                    row["PickupPointId"] = Convert.ToInt32(cbPickup.SelectedValue);
                    tbId.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                ordersBindingSource.EndEdit();
                ordersTableAdapter.Update(obuvDBDataSet.Orders);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
