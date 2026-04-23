using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class ProductEdit : Form
    {
        private readonly int? productId;
        private string pendingSource;

        public ProductEdit(int? id) { InitializeComponent(); productId = id; }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            try
            {
                categoriesTableAdapter.Fill(obuvDBDataSet.Categories);
                manufacturersTableAdapter.Fill(obuvDBDataSet.Manufacturers);
                suppliersTableAdapter.Fill(obuvDBDataSet.Suppliers);
                unitsTableAdapter.Fill(obuvDBDataSet.Units);
                productsTableAdapter.Fill(obuvDBDataSet.Products);

                if (productId.HasValue)
                {
                    productsBindingSource.Position = productsBindingSource.Find("ProductId", productId.Value);
                    tbId.Visible = true;
                }
                else
                {
                    productsBindingSource.AddNew();
                    var r = (DataRowView)productsBindingSource.Current;
                    r["CategoryName"] = cbCategory.Text;
                    r["ManufactureName"] = cbManufactures.Text;
                    r["SupplierName"] = cbSuppliers.Text;
                    r["UnitName"] = cbUnits.Text;
                    r["Price"] = 0m; r["StockQty"] = 0; r["Discount"] = 0;
                    r["PhotoPath"] = ""; r["Discription"] = "";
                    tbId.Visible = false;
                }
                ShowPhoto();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); Close(); }
        }

        private void ShowPhoto()
        {
            var rel = ((DataRowView)productsBindingSource.Current)["PhotoPath"].ToString();
            var full = pendingSource ?? (rel == "" ? "" : Path.Combine(Application.StartupPath, rel));
            pbPhoto.Image = File.Exists(full)
                ? Image.FromStream(new MemoryStream(File.ReadAllBytes(full)))
                : Properties.Resources.picture;
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog { Filter = "Изображения|*.png;*.jpg;*.jpeg;*.bmp" };
            if (d.ShowDialog() == DialogResult.OK) { pendingSource = d.FileName; ShowPhoto(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() == "") { MessageBox.Show("Укажите наименование"); return; }
            if (tbArticle.Text.Trim() == "") { MessageBox.Show("Укажите артикул"); return; }

            try
            {
                var row = (DataRowView)productsBindingSource.Current;
                if (pendingSource != null)
                {
                    var dir = Path.Combine(Application.StartupPath, "images");
                    Directory.CreateDirectory(dir);
                    var rel = "images\\" + Guid.NewGuid().ToString("N") + ".png";
                    using (var src = Image.FromFile(pendingSource))
                    using (var bmp = new Bitmap(src, 300, 200))
                        bmp.Save(Path.Combine(Application.StartupPath, rel), ImageFormat.Png);

                    var old = row["PhotoPath"].ToString();
                    if (old != "" && File.Exists(Path.Combine(Application.StartupPath, old)))
                        File.Delete(Path.Combine(Application.StartupPath, old));
                    row["PhotoPath"] = rel;
                }
                productsBindingSource.EndEdit();
                productsTableAdapter.Update(obuvDBDataSet.Products);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void btnCancel_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
