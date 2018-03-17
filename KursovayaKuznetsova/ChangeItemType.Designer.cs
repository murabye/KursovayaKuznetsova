namespace kursovayaKuznetsova
{
    partial class ChangeItemType
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
            this.ProductType = new System.Windows.Forms.Button();
            this.realPrice = new System.Windows.Forms.NumericUpDown();
            this.sellPrice = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.realPriceLabel = new System.Windows.Forms.Label();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pickItem = new System.Windows.Forms.ComboBox();
            this.pickItemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.realPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductType
            // 
            this.ProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductType.Location = new System.Drawing.Point(12, 193);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(256, 31);
            this.ProductType.TabIndex = 15;
            this.ProductType.Text = "Создать";
            this.ProductType.UseVisualStyleBackColor = true;
            // 
            // realPrice
            // 
            this.realPrice.Location = new System.Drawing.Point(12, 167);
            this.realPrice.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.realPrice.Name = "realPrice";
            this.realPrice.Size = new System.Drawing.Size(120, 20);
            this.realPrice.TabIndex = 14;
            // 
            // sellPrice
            // 
            this.sellPrice.DecimalPlaces = 2;
            this.sellPrice.Location = new System.Drawing.Point(12, 122);
            this.sellPrice.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(120, 20);
            this.sellPrice.TabIndex = 13;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(12, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(256, 20);
            this.name.TabIndex = 12;
            // 
            // realPriceLabel
            // 
            this.realPriceLabel.AutoSize = true;
            this.realPriceLabel.Location = new System.Drawing.Point(12, 150);
            this.realPriceLabel.Name = "realPriceLabel";
            this.realPriceLabel.Size = new System.Drawing.Size(86, 13);
            this.realPriceLabel.TabIndex = 11;
            this.realPriceLabel.Text = "Себестоимость";
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Location = new System.Drawing.Point(12, 105);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(80, 13);
            this.sellPriceLabel.TabIndex = 10;
            this.sellPriceLabel.Text = "Цена продажи";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(158, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Полное название (уникально)";
            // 
            // pickItem
            // 
            this.pickItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickItem.FormattingEnabled = true;
            this.pickItem.Location = new System.Drawing.Point(12, 25);
            this.pickItem.Name = "pickItem";
            this.pickItem.Size = new System.Drawing.Size(256, 21);
            this.pickItem.TabIndex = 16;
            // 
            // pickItemLabel
            // 
            this.pickItemLabel.AutoSize = true;
            this.pickItemLabel.Location = new System.Drawing.Point(12, 9);
            this.pickItemLabel.Name = "pickItemLabel";
            this.pickItemLabel.Size = new System.Drawing.Size(89, 13);
            this.pickItemLabel.TabIndex = 17;
            this.pickItemLabel.Text = "Выберите товар";
            // 
            // ChangeItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.pickItemLabel);
            this.Controls.Add(this.pickItem);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.realPrice);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.realPriceLabel);
            this.Controls.Add(this.sellPriceLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ChangeItemType";
            this.ShowIcon = false;
            this.Text = "Изменить товар";
            ((System.ComponentModel.ISupportInitialize)(this.realPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProductType;
        private System.Windows.Forms.NumericUpDown realPrice;
        private System.Windows.Forms.NumericUpDown sellPrice;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label realPriceLabel;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox pickItem;
        private System.Windows.Forms.Label pickItemLabel;
    }
}