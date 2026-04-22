namespace ObuvApp
{
    partial class ProductCard
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
            this.panelRoot = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPriceNew = new System.Windows.Forms.Label();
            this.lblPriceOld = new System.Windows.Forms.Label();
            this.lblSup = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelDiscount = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.productPic = new System.Windows.Forms.PictureBox();
            this.panelRoot.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelDiscount.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoot
            // 
            this.panelRoot.BackColor = System.Drawing.Color.White;
            this.panelRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoot.Controls.Add(this.panelInfo);
            this.panelRoot.Controls.Add(this.panelDiscount);
            this.panelRoot.Controls.Add(this.panelPhoto);
            this.panelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoot.Location = new System.Drawing.Point(0, 0);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Size = new System.Drawing.Size(700, 160);
            this.panelRoot.TabIndex = 0;
            this.panelRoot.Click += new System.EventHandler(this.Card_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.lblStock);
            this.panelInfo.Controls.Add(this.lblUnit);
            this.panelInfo.Controls.Add(this.lblPriceNew);
            this.panelInfo.Controls.Add(this.lblPriceOld);
            this.panelInfo.Controls.Add(this.lblSup);
            this.panelInfo.Controls.Add(this.lblMan);
            this.panelInfo.Controls.Add(this.lblDescription);
            this.panelInfo.Controls.Add(this.lblHeader);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(160, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(8);
            this.panelInfo.Size = new System.Drawing.Size(398, 158);
            this.panelInfo.TabIndex = 1;
            this.panelInfo.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(10, 138);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(149, 17);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Количество на складе:";
            this.lblStock.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(10, 118);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(132, 17);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "Единица измерения:";
            this.lblUnit.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblPriceNew
            // 
            this.lblPriceNew.AutoSize = true;
            this.lblPriceNew.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblPriceNew.Location = new System.Drawing.Point(80, 98);
            this.lblPriceNew.Name = "lblPriceNew";
            this.lblPriceNew.Size = new System.Drawing.Size(49, 17);
            this.lblPriceNew.TabIndex = 5;
            this.lblPriceNew.Text = "Цена:";
            this.lblPriceNew.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblPriceOld
            // 
            this.lblPriceOld.AutoSize = true;
            this.lblPriceOld.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Strikeout);
            this.lblPriceOld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPriceOld.Location = new System.Drawing.Point(10, 98);
            this.lblPriceOld.Name = "lblPriceOld";
            this.lblPriceOld.Size = new System.Drawing.Size(32, 16);
            this.lblPriceOld.TabIndex = 4;
            this.lblPriceOld.Text = "0.00";
            this.lblPriceOld.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Location = new System.Drawing.Point(10, 76);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(82, 17);
            this.lblSup.TabIndex = 3;
            this.lblSup.Text = "Поставщик:";
            this.lblSup.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblMan
            // 
            this.lblMan.AutoSize = true;
            this.lblMan.Location = new System.Drawing.Point(10, 54);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(106, 17);
            this.lblMan.TabIndex = 2;
            this.lblMan.Text = "Производитель:";
            this.lblMan.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(10, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Описание:";
            this.lblDescription.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(8, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(382, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Категория | Наименование";
            this.lblHeader.Click += new System.EventHandler(this.Card_Click);
            // 
            // panelDiscount
            // 
            this.panelDiscount.BackColor = System.Drawing.Color.White;
            this.panelDiscount.Controls.Add(this.lblDiscount);
            this.panelDiscount.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDiscount.Location = new System.Drawing.Point(558, 0);
            this.panelDiscount.Name = "panelDiscount";
            this.panelDiscount.Size = new System.Drawing.Size(140, 158);
            this.panelDiscount.TabIndex = 2;
            this.panelDiscount.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(0, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(140, 158);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Действующая скидка";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiscount.Click += new System.EventHandler(this.Card_Click);
            // 
            // panelPhoto
            // 
            this.panelPhoto.BackColor = System.Drawing.Color.White;
            this.panelPhoto.Controls.Add(this.productPic);
            this.panelPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPhoto.Location = new System.Drawing.Point(0, 0);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Padding = new System.Windows.Forms.Padding(6);
            this.panelPhoto.Size = new System.Drawing.Size(160, 158);
            this.panelPhoto.TabIndex = 0;
            this.panelPhoto.Click += new System.EventHandler(this.Card_Click);
            // 
            // productPic
            // 
            this.productPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPic.Image = global::ObuvApp.Properties.Resources.picture;
            this.productPic.Location = new System.Drawing.Point(6, 6);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(148, 146);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 0;
            this.productPic.TabStop = false;
            this.productPic.Click += new System.EventHandler(this.Card_Click);
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRoot);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(700, 160);
            this.panelRoot.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelDiscount.ResumeLayout(false);
            this.panelPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.PictureBox productPic;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMan;
        private System.Windows.Forms.Label lblSup;
        private System.Windows.Forms.Label lblPriceOld;
        private System.Windows.Forms.Label lblPriceNew;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panelDiscount;
        private System.Windows.Forms.Label lblDiscount;
    }
}
