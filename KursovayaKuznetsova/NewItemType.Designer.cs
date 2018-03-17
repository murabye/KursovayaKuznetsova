namespace kursovayaKuznetsova
{
    partial class NewItemType
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.realPriceLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.sellPrice = new System.Windows.Forms.NumericUpDown();
            this.realPrice = new System.Windows.Forms.NumericUpDown();
            this.ProductType = new System.Windows.Forms.Button();
            this.manufactor = new System.Windows.Forms.ComboBox();
            this.manufactorLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(158, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Полное название (уникально)";
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.AutoSize = true;
            this.sellPriceLabel.Location = new System.Drawing.Point(16, 78);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(80, 13);
            this.sellPriceLabel.TabIndex = 2;
            this.sellPriceLabel.Text = "Цена продажи";
            // 
            // realPriceLabel
            // 
            this.realPriceLabel.AutoSize = true;
            this.realPriceLabel.Location = new System.Drawing.Point(16, 123);
            this.realPriceLabel.Name = "realPriceLabel";
            this.realPriceLabel.Size = new System.Drawing.Size(86, 13);
            this.realPriceLabel.TabIndex = 3;
            this.realPriceLabel.Text = "Себестоимость";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(16, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(256, 20);
            this.name.TabIndex = 4;
            // 
            // sellPrice
            // 
            this.sellPrice.DecimalPlaces = 2;
            this.sellPrice.Location = new System.Drawing.Point(16, 95);
            this.sellPrice.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(120, 20);
            this.sellPrice.TabIndex = 6;
            // 
            // realPrice
            // 
            this.realPrice.Location = new System.Drawing.Point(16, 140);
            this.realPrice.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.realPrice.Name = "realPrice";
            this.realPrice.Size = new System.Drawing.Size(120, 20);
            this.realPrice.TabIndex = 7;
            // 
            // ProductType
            // 
            this.ProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductType.Location = new System.Drawing.Point(16, 215);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(256, 33);
            this.ProductType.TabIndex = 8;
            this.ProductType.Text = "Создать";
            this.ProductType.UseVisualStyleBackColor = true;
            // 
            // manufactor
            // 
            this.manufactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manufactor.FormattingEnabled = true;
            this.manufactor.Location = new System.Drawing.Point(15, 188);
            this.manufactor.Name = "manufactor";
            this.manufactor.Size = new System.Drawing.Size(257, 21);
            this.manufactor.TabIndex = 9;
            // 
            // manufactorLabel
            // 
            this.manufactorLabel.AutoSize = true;
            this.manufactorLabel.Location = new System.Drawing.Point(16, 172);
            this.manufactorLabel.Name = "manufactorLabel";
            this.manufactorLabel.Size = new System.Drawing.Size(65, 13);
            this.manufactorLabel.TabIndex = 10;
            this.manufactorLabel.Text = "Поставщик";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Духи";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NewItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.manufactorLabel);
            this.Controls.Add(this.manufactor);
            this.Controls.Add(this.ProductType);
            this.Controls.Add(this.realPrice);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.realPriceLabel);
            this.Controls.Add(this.sellPriceLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "NewItemType";
            this.ShowIcon = false;
            this.Text = "Новый тип товара";
            ((System.ComponentModel.ISupportInitialize)(this.sellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label realPriceLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.NumericUpDown sellPrice;
        private System.Windows.Forms.NumericUpDown realPrice;
        private System.Windows.Forms.Button ProductType;
        private System.Windows.Forms.ComboBox manufactor;
        private System.Windows.Forms.Label manufactorLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}