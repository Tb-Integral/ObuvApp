namespace ObuvApp
{
    partial class UcOrderCard
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
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.panelDeliv = new System.Windows.Forms.Panel();
            this.lblDelivDate = new System.Windows.Forms.Label();
            this.panelRoot.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelDeliv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoot
            // 
            this.panelRoot.BackColor = System.Drawing.Color.White;
            this.panelRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRoot.Controls.Add(this.panelInfo);
            this.panelRoot.Controls.Add(this.panelDeliv);
            this.panelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoot.Location = new System.Drawing.Point(0, 0);
            this.panelRoot.Name = "panelRoot";
            this.panelRoot.Size = new System.Drawing.Size(700, 120);
            this.panelRoot.TabIndex = 0;
            this.panelRoot.Click += new System.EventHandler(this.Card_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblOrderDate);
            this.panelInfo.Controls.Add(this.lblAddress);
            this.panelInfo.Controls.Add(this.lblStatus);
            this.panelInfo.Controls.Add(this.lblArticle);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(8);
            this.panelInfo.Size = new System.Drawing.Size(538, 118);
            this.panelInfo.TabIndex = 0;
            this.panelInfo.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblArticle.Location = new System.Drawing.Point(10, 10);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(130, 20);
            this.lblArticle.TabIndex = 0;
            this.lblArticle.Text = "Артикул заказа";
            this.lblArticle.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 19);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Статус заказа";
            this.lblStatus.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(180, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Адрес пункта выдачи";
            this.lblAddress.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(10, 84);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(110, 19);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Дата заказа";
            this.lblOrderDate.Click += new System.EventHandler(this.Card_Click);
            // 
            // panelDeliv
            // 
            this.panelDeliv.Controls.Add(this.lblDelivDate);
            this.panelDeliv.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDeliv.Location = new System.Drawing.Point(538, 0);
            this.panelDeliv.Name = "panelDeliv";
            this.panelDeliv.Size = new System.Drawing.Size(160, 118);
            this.panelDeliv.TabIndex = 1;
            this.panelDeliv.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblDelivDate
            // 
            this.lblDelivDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDelivDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular);
            this.lblDelivDate.Location = new System.Drawing.Point(0, 0);
            this.lblDelivDate.Name = "lblDelivDate";
            this.lblDelivDate.Size = new System.Drawing.Size(160, 118);
            this.lblDelivDate.TabIndex = 0;
            this.lblDelivDate.Text = "Дата доставки";
            this.lblDelivDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelivDate.Click += new System.EventHandler(this.Card_Click);
            // 
            // UcOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRoot);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UcOrderCard";
            this.Size = new System.Drawing.Size(700, 120);
            this.panelRoot.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelDeliv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoot;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Panel panelDeliv;
        private System.Windows.Forms.Label lblDelivDate;
    }
}
