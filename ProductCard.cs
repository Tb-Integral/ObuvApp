using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class ProductCard : UserControl
    {
        public int ProductId { get; private set; }
        public event EventHandler CardClicked;

        public ProductCard()
        {
            InitializeComponent();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetData(DataRowView row)
        {
            ProductId = Convert.ToInt32(row["ProductId"]);

            string category = row["CategoryName"].ToString();
            string name = row["ProductName"].ToString();
            decimal price = Convert.ToDecimal(row["Price"]);
            int discount = Convert.ToInt32(row["Discount"]);
            int stock = Convert.ToInt32(row["StockQty"]);

            lblHeader.Text = category + " | " + name;
            lblDescription.Text = "Описание: " + row["Discription"];
            lblMan.Text = "Производитель: " + row["ManufactureName"];
            lblSup.Text = "Поставщик: " + row["SupplierName"];
            lblUnit.Text = "Единица измерения: " + row["UnitName"];
            lblStock.Text = "Количество на складе: " + stock;

            if (discount > 0)
            {
                decimal finalPrice = price * (100 - discount) / 100m;
                lblPriceOld.Visible = true;
                lblPriceOld.Text = price.ToString("0.00");
                lblPriceNew.Text = "Цена: " + finalPrice.ToString("0.00");
                lblDiscount.Text = "Скидка " + discount + "%";
            }
            else
            {
                lblPriceOld.Visible = false;
                lblPriceNew.Text = "Цена: " + price.ToString("0.00");
                lblDiscount.Text = "Действующая скидка";
            }

            Color bg = Color.White;
            if (stock == 0) bg = Color.LightSkyBlue;
            else if (discount > 15) bg = Color.MediumSpringGreen;
            panelRoot.BackColor = bg;
            panelInfo.BackColor = bg;
            panelPhoto.BackColor = bg;
            panelDiscount.BackColor = bg;

            string rel = row["PhotoPath"].ToString();
            string full = Path.Combine(Application.StartupPath, rel);

            if (!string.IsNullOrEmpty(rel) && File.Exists(full))
                productPic.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(full)));
            else
                productPic.Image = Properties.Resources.picture;
        }
    }
}
