namespace ObuvApp
{
    partial class ProductList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.obuvDBDataSet = new ObuvApp.ObuvDBDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.SuppliersTableAdapter();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnDel);
            this.pnlTools.Controls.Add(this.btnAdd);
            this.pnlTools.Controls.Add(this.cbSort);
            this.pnlTools.Controls.Add(this.cbSupplier);
            this.pnlTools.Controls.Add(this.tbSearch);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(800, 54);
            this.pnlTools.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(687, 15);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 25);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(581, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.cbSort.Location = new System.Drawing.Point(329, 14);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(143, 27);
            this.cbSort.TabIndex = 2;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.ViewChanged);
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(180, 14);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(143, 27);
            this.cbSupplier.TabIndex = 1;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.ViewChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 15);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(161, 26);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.ViewChanged);
            // 
            // pnlCards
            // 
            this.pnlCards.AutoScroll = true;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCards.Location = new System.Drawing.Point(0, 54);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(6);
            this.pnlCards.Size = new System.Drawing.Size(800, 469);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.WrapContents = false;
            // 
            // obuvDBDataSet
            // 
            this.obuvDBDataSet.DataSetName = "ObuvDBDataSet";
            this.obuvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ManufacturersTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.OrderStatusesTableAdapter = null;
            this.tableAdapterManager.PickupPointsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UnitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlTools);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductList";
            this.Size = new System.Drawing.Size(800, 523);
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private ObuvDBDataSet obuvDBDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ObuvDBDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ObuvDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private ObuvDBDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
    }
}
