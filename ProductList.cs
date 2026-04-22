using System;
using System.Data;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class ProductList : UserControl
    {
        private readonly string roleName;
        private bool IsAdmin;
        private bool IsManager;
        private int selectedProductId;

        public ProductList(string roleName)
        {
            InitializeComponent();
            this.roleName = roleName;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            IsAdmin = roleName == "Администратор";
            IsManager = roleName == "Менеджер" || IsAdmin;

            pnlTools.Visible = IsManager;
            btnAdd.Visible = IsAdmin;
             btnDel.Visible = IsAdmin;

            try
            {
                productsTableAdapter.Fill(obuvDBDataSet.Products);
                suppliersTableAdapter.Fill(obuvDBDataSet.Suppliers);

                productsBindingSource.DataSource = obuvDBDataSet.Products;

                FillSuppliersCombo();
                cbSort.SelectedIndex = 0;
                RenderCards();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSuppliersCombo()
        {
            cbSupplier.Items.Clear();
            cbSupplier.Items.Add("Все поставщики");
            for (int i = 0; i < obuvDBDataSet.Suppliers.Count; i++)
                cbSupplier.Items.Add(obuvDBDataSet.Suppliers[i].SupplierName);
            cbSupplier.SelectedIndex = 0;
        }

        private void RenderCards()
        {
            pnlCards.Controls.Clear();
            int width = pnlCards.ClientSize.Width - pnlCards.Padding.Horizontal - 20;

            for (int i = 0; i < productsBindingSource.Count; i++)
            {
                DataRowView row = (DataRowView)productsBindingSource[i];
                ProductCard card = new ProductCard();
                card.SetData(row);
                card.Width = width;
                card.Margin = new Padding(0, 0, 0, 8);
                card.CardClicked += Card_CardClicked;
                pnlCards.Controls.Add(card);
            }
        }

        private void Card_CardClicked(object sender, EventArgs e)
        {
            ProductCard card = (ProductCard)sender;
            selectedProductId = card.ProductId;

            if (!IsAdmin)
            {
                MessageBox.Show("Редактирование доступно только администратору",
                    "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OpenEdit(selectedProductId);
        }

        private void ViewChanged(object sender, EventArgs e)
        {
            string filter = "";
            string q = tbSearch.Text.Trim().Replace("'", "''");

            if (q.Length > 0)
                filter = "ProductName LIKE '%" + q + "%'";

            if (cbSupplier.SelectedIndex > 0)
            {
                if (filter.Length > 0) filter += " AND ";
                filter += "SupplierName = '" + cbSupplier.Text.Replace("'", "''") + "'";
            }

            productsBindingSource.Filter = filter;

            if (cbSort.SelectedIndex == 1) productsBindingSource.Sort = "StockQty ASC";
            else if (cbSort.SelectedIndex == 2) productsBindingSource.Sort = "StockQty DESC";
            else productsBindingSource.Sort = "";

            RenderCards();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenEdit(null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Выберите товар");
                return;
            }

            int used = productsTableAdapter.CountProductInOrders(selectedProductId) ?? 0;
            if (used > 0)
            {
                MessageBox.Show("Нельзя удалить товар, он используется в заказе");
                return;
            }

            try
            {
                productsTableAdapter.DeleteById(selectedProductId);
                selectedProductId = 0;
                productsTableAdapter.Fill(obuvDBDataSet.Products);
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
            ProductEdit f = new ProductEdit(id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                productsTableAdapter.Fill(obuvDBDataSet.Products);
                RenderCards();
            }
        }
    }
}
