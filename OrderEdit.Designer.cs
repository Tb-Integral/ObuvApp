namespace ObuvApp
{
    partial class OrderEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEdit));
            this.obuvDBDataSet = new ObuvApp.ObuvDBDataSet();
            this.pickupPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickupPointsTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.PickupPointsTableAdapter();
            this.tableAdapterManager = new ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.OrdersTableAdapter();
            this.orderStatusesTableAdapter = new ObuvApp.ObuvDBDataSetTableAdapters.OrderStatusesTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.tbArticle = new System.Windows.Forms.TextBox();
            this.cbPickup = new System.Windows.Forms.ComboBox();
            this.dtpDeliv = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fKOrdersOrderStatusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersOrderStatusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // obuvDBDataSet
            // 
            this.obuvDBDataSet.DataSetName = "ObuvDBDataSet";
            this.obuvDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.OrderStatusesTableAdapter = this.orderStatusesTableAdapter;
            this.tableAdapterManager.PickupPointsTableAdapter = this.pickupPointsTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UnitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ObuvApp.ObuvDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderStatusesTableAdapter
            // 
            this.orderStatusesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // orderStatusesBindingSource
            // 
            this.orderStatusesBindingSource.DataMember = "OrderStatuses";
            this.orderStatusesBindingSource.DataSource = this.obuvDBDataSet;
            // 
            // cbStatus
            // 
            this.cbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "StatusName", true));
            this.cbStatus.DataSource = this.orderStatusesBindingSource;
            this.cbStatus.DisplayMember = "StatusName";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(46, 141);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 29);
            this.cbStatus.TabIndex = 5;
            // 
            // tbId
            // 
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderId", true));
            this.tbId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbId.Location = new System.Drawing.Point(46, 28);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(200, 29);
            this.tbId.TabIndex = 4;
            // 
            // dtpOrder
            // 
            this.dtpOrder.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "OrderDate", true));
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(46, 250);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(200, 29);
            this.dtpOrder.TabIndex = 6;
            // 
            // tbArticle
            // 
            this.tbArticle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderActicle", true));
            this.tbArticle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbArticle.Location = new System.Drawing.Point(46, 83);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(200, 29);
            this.tbArticle.TabIndex = 7;
            // 
            // cbPickup
            // 
            this.cbPickup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordersBindingSource, "PickupPointId", true));
            this.cbPickup.DataSource = this.pickupPointsBindingSource;
            this.cbPickup.DisplayMember = "Address";
            this.cbPickup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPickup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPickup.FormattingEnabled = true;
            this.cbPickup.Location = new System.Drawing.Point(46, 195);
            this.cbPickup.Name = "cbPickup";
            this.cbPickup.Size = new System.Drawing.Size(200, 29);
            this.cbPickup.TabIndex = 8;
            this.cbPickup.ValueMember = "PickupPointsId";
            // 
            // dtpDeliv
            // 
            this.dtpDeliv.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "DeliveryDate", true));
            this.dtpDeliv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliv.Location = new System.Drawing.Point(46, 297);
            this.dtpDeliv.Name = "dtpDeliv";
            this.dtpDeliv.Size = new System.Drawing.Size(200, 29);
            this.dtpDeliv.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(81, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(81, 419);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 43);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fKOrdersOrderStatusesBindingSource
            // 
            this.fKOrdersOrderStatusesBindingSource.DataMember = "FK_Orders_OrderStatuses";
            this.fKOrdersOrderStatusesBindingSource.DataSource = this.orderStatusesBindingSource;
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 508);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDeliv);
            this.Controls.Add(this.cbPickup);
            this.Controls.Add(this.tbArticle);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbId);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderEdit";
            this.Text = "OrderEdit";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obuvDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickupPointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderStatusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersOrderStatusesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ObuvDBDataSet obuvDBDataSet;
        private System.Windows.Forms.BindingSource pickupPointsBindingSource;
        private ObuvDBDataSetTableAdapters.PickupPointsTableAdapter pickupPointsTableAdapter;
        private ObuvDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ObuvDBDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ObuvDBDataSetTableAdapters.OrderStatusesTableAdapter orderStatusesTableAdapter;
        private System.Windows.Forms.BindingSource orderStatusesBindingSource;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.TextBox tbArticle;
        private System.Windows.Forms.ComboBox cbPickup;
        private System.Windows.Forms.DateTimePicker dtpDeliv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource fKOrdersOrderStatusesBindingSource;
    }
}