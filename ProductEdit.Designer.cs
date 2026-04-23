namespace ObuvApp
{
    partial class ProductEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEdit));
            this.tbId = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obuvDBDataSet = new ObuvApp.ObuvDBDataSet();
            this.tbArticle = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.fKPriductsCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.fKPriductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbManufactures = new System.Windows.Forms.ComboBox();
            this.fKPriductsManufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbUnits = new System.Windows.Forms.ComboBox();
            this.fKPriductsUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.productsTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager();
            this.categoriesTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.CategoriesTableAdapter();
            this.manufacturersTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.ManufacturersTableAdapter();
            this.suppliersTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.SuppliersTableAdapter();
            this.unitsTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.UnitsTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsManufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductId", true));
            this.tbId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbId.Location = new System.Drawing.Point(40, 32);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(190, 29);
            this.tbId.TabIndex = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // obuvDBDataSet
            // 
            this.obuvDBDataSet.DataSetName = "ObuvDBDataSet";
            this.obuvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbArticle
            // 
            this.tbArticle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Article", true));
            this.tbArticle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArticle.Location = new System.Drawing.Point(247, 32);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(190, 29);
            this.tbArticle.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(40, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(190, 29);
            this.tbName.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CategoryName", true));
            this.cbCategory.DataSource = this.categoriesBindingSource;
            this.cbCategory.DisplayMember = "CategoryName";
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(40, 135);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(190, 29);
            this.cbCategory.TabIndex = 3;
            // 
            // fKPriductsCategoriesBindingSource
            // 
            this.fKPriductsCategoriesBindingSource.DataMember = "FK_Priducts_Categories";
            this.fKPriductsCategoriesBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // tbDesc
            // 
            this.tbDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Discription", true));
            this.tbDesc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDesc.Location = new System.Drawing.Point(40, 237);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(397, 154);
            this.tbDesc.TabIndex = 4;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "SupplierName", true));
            this.cbSuppliers.DataSource = this.suppliersBindingSource;
            this.cbSuppliers.DisplayMember = "SupplierName";
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(247, 135);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(190, 29);
            this.cbSuppliers.TabIndex = 5;
            // 
            // fKPriductsSuppliersBindingSource
            // 
            this.fKPriductsSuppliersBindingSource.DataMember = "FK_Priducts_Suppliers";
            this.fKPriductsSuppliersBindingSource.DataSource = this.suppliersBindingSource;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // cbManufactures
            // 
            this.cbManufactures.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ManufactureName", true));
            this.cbManufactures.DataSource = this.manufacturersBindingSource;
            this.cbManufactures.DisplayMember = "ManufacturerName";
            this.cbManufactures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufactures.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbManufactures.FormattingEnabled = true;
            this.cbManufactures.Location = new System.Drawing.Point(40, 183);
            this.cbManufactures.Name = "cbManufactures";
            this.cbManufactures.Size = new System.Drawing.Size(190, 29);
            this.cbManufactures.TabIndex = 6;
            // 
            // fKPriductsManufacturersBindingSource
            // 
            this.fKPriductsManufacturersBindingSource.DataMember = "FK_Priducts_Manufacturers";
            this.fKPriductsManufacturersBindingSource.DataSource = this.manufacturersBindingSource;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // cbUnits
            // 
            this.cbUnits.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitName", true));
            this.cbUnits.DataSource = this.unitsBindingSource;
            this.cbUnits.DisplayMember = "UnitName";
            this.cbUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnits.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Location = new System.Drawing.Point(247, 183);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(190, 29);
            this.cbUnits.TabIndex = 7;
            // 
            // fKPriductsUnitsBindingSource
            // 
            this.fKPriductsUnitsBindingSource.DataMember = "FK_Priducts_Units";
            this.fKPriductsUnitsBindingSource.DataSource = this.unitsBindingSource;
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // numPrice
            // 
            this.numPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "Price", true));
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPrice.Location = new System.Drawing.Point(40, 410);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(190, 29);
            this.numPrice.TabIndex = 8;
            // 
            // numStock
            // 
            this.numStock.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "StockQty", true));
            this.numStock.DecimalPlaces = 2;
            this.numStock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numStock.Location = new System.Drawing.Point(40, 461);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(190, 29);
            this.numStock.TabIndex = 9;
            // 
            // numDiscount
            // 
            this.numDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "Discount", true));
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDiscount.Location = new System.Drawing.Point(40, 511);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(190, 29);
            this.numDiscount.TabIndex = 10;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = global::ObuvApp.Properties.Resources.picture;
            this.pbPhoto.InitialImage = global::ObuvApp.Properties.Resources.picture;
            this.pbPhoto.Location = new System.Drawing.Point(490, 32);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(358, 359);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 11;
            this.pbPhoto.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.Location = new System.Drawing.Point(598, 402);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(158, 37);
            this.btnChoosePhoto.TabIndex = 12;
            this.btnChoosePhoto.Text = "Выбрать фото";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(690, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 37);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(506, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.ManufacturersTableAdapter = this.manufacturersTableAdapter;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.OrderStatusesTableAdapter = null;
            this.tableAdapterManager.PickupPointsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UnitsTableAdapter = this.unitsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Изображения|*.png;*.jpg;*.jpeg;*.bmp";
            this.openFileDialog.Title = "Выбор фото";
            // 
            // ProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 713);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoosePhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.cbUnits);
            this.Controls.Add(this.cbManufactures);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbArticle);
            this.Controls.Add(this.tbId);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductEdit";
            this.Text = "Редактирование/создание";
            this.Load += new System.EventHandler(this.ProductEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsManufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPriductsUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbArticle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.ComboBox cbManufactures;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private ObuvDBDataSet obuvDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ObuvDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ObuvDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ObuvDBDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ObuvDBDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private ObuvDBDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private ObuvDBDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private System.Windows.Forms.BindingSource fKPriductsCategoriesBindingSource;
        private System.Windows.Forms.BindingSource fKPriductsSuppliersBindingSource;
        private System.Windows.Forms.BindingSource fKPriductsManufacturersBindingSource;
        private System.Windows.Forms.BindingSource fKPriductsUnitsBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}