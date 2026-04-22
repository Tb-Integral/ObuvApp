using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ObuvApp
{
    public partial class ProductEdit : Form
    {
        private readonly int? productId;
        private string pendingSource;

        public ProductEdit(int? productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

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
                    int pos = productsBindingSource.Find("ProductId", productId.Value);
                    if (pos >= 0) productsBindingSource.Position = pos;
                    tbId.Visible = true;
                }
                else
                {
                    productsBindingSource.AddNew();
                    DataRowView row = (DataRowView)productsBindingSource.Current;
                    row["CategoryName"] = cbCategory.Text;
                    row["ManufactureName"] = cbManufactures.Text;
                    row["SupplierName"] = cbSuppliers.Text;
                    row["UnitName"] = cbUnits.Text;
                    row["Price"] = 0m;
                    row["StockQty"] = 0;
                    row["Discount"] = 0;
                    row["PhotoPath"] = "";
                    row["Discription"] = "";
                    tbId.Visible = false;
                }

                string rel = ((DataRowView)productsBindingSource.Current)["PhotoPath"].ToString();
                ShowPhoto(Path.Combine(Application.StartupPath, rel));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Изображения|*.png;*.jpg;*.jpeg;*.bmp";
            if (d.ShowDialog() != DialogResult.OK) return;

            pendingSource = d.FileName;
            ShowPhoto(pendingSource);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)productsBindingSource.Current;

                if (pendingSource != null)
                {
                    string dir = Path.Combine(Application.StartupPath, "images");
                    Directory.CreateDirectory(dir);
                    string file = Guid.NewGuid().ToString("N") + Path.GetExtension(pendingSource);
                    File.Copy(pendingSource, Path.Combine(dir, file));

                    string oldRel = row["PhotoPath"].ToString();
                    row["PhotoPath"] = "images\\" + file;

                    if (!string.IsNullOrEmpty(oldRel))
                    {
                        string oldFull = Path.Combine(Application.StartupPath, oldRel);
                        if (File.Exists(oldFull)) File.Delete(oldFull);
                    }
                }

                productsBindingSource.EndEdit();
                productsTableAdapter.Update(obuvDBDataSet.Products);

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

        private void ShowPhoto(string fullPath)
        {
            if (!string.IsNullOrEmpty(fullPath) && File.Exists(fullPath))
                pbPhoto.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(fullPath)));
            else
                pbPhoto.Image = Properties.Resources.picture;
        }
    }
}
