namespace kursovayaKuznetsova
{
    partial class DeleteItems
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
            this.pickStock = new System.Windows.Forms.ComboBox();
            this.pickStockLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pickStock
            // 
            this.pickStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickStock.FormattingEnabled = true;
            this.pickStock.Location = new System.Drawing.Point(16, 31);
            this.pickStock.Name = "pickStock";
            this.pickStock.Size = new System.Drawing.Size(256, 21);
            this.pickStock.TabIndex = 3;
            // 
            // pickStockLabel
            // 
            this.pickStockLabel.AutoSize = true;
            this.pickStockLabel.Location = new System.Drawing.Point(13, 14);
            this.pickStockLabel.Name = "pickStockLabel";
            this.pickStockLabel.Size = new System.Drawing.Size(90, 13);
            this.pickStockLabel.TabIndex = 2;
            this.pickStockLabel.Text = "Выберите склад";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(256, 121);
            this.dataGridView1.TabIndex = 4;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(16, 187);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 36);
            this.start.TabIndex = 5;
            this.start.Text = "Списать товар";
            this.start.UseVisualStyleBackColor = true;
            // 
            // DeleteItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pickStock);
            this.Controls.Add(this.pickStockLabel);
            this.Name = "DeleteItems";
            this.ShowIcon = false;
            this.Text = "Списать товар";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox pickStock;
        private System.Windows.Forms.Label pickStockLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button start;
    }
}