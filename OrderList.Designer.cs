namespace ObuvApp
{
    partial class OrderList
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
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.obuvDBDataSet = new ObuvApp.ObuvDBDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.OrdersTableAdapter();
            this.pickupPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickupPointsTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.PickupPointsTableAdapter();
            this.tableAdapterManager = new ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnDel);
            this.pnlTools.Controls.Add(this.btnAdd);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(804, 55);
            this.pnlTools.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdd.Location = new System.Drawing.Point(12, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить заказ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Chartreuse;
            this.btnDel.Location = new System.Drawing.Point(158, 8);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(140, 39);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Удалить заказ";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlCards
            // 
            this.pnlCards.AutoScroll = true;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCards.Location = new System.Drawing.Point(0, 55);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(6);
            this.pnlCards.Size = new System.Drawing.Size(804, 369);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.WrapContents = false;
            // 
            // obuvDBDataSet
            // 
            this.obuvDBDataSet.DataSetName = "ObuvDBDataSet";
            this.obuvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // pickupPointsBindingSource
            // 
            this.pickupPointsBindingSource.DataMember = "PickupPoints";
            this.pickupPointsBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // pickupPointsTableAdapter
            // 
            this.pickupPointsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ManufacturersTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.OrderStatusesTableAdapter = null;
            this.tableAdapterManager.PickupPointsTableAdapter = this.pickupPointsTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UnitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlTools);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderList";
            this.Size = new System.Drawing.Size(804, 424);
            this.Load += new System.EventHandler(this.OrderList_Load);
            this.pnlTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private ObuvDBDataSet obuvDBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ObuvDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource pickupPointsBindingSource;
        private ObuvDBDataSetTableAdapters.PickupPointsTableAdapter pickupPointsTableAdapter;
        private ObuvDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
