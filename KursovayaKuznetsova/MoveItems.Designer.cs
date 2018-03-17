namespace kursovayaKuznetsova
{
    partial class MoveItems
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
            this.start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pickStartStock = new System.Windows.Forms.ComboBox();
            this.pickStartStockLabel = new System.Windows.Forms.Label();
            this.pickEndStock = new System.Windows.Forms.ComboBox();
            this.pickEndStockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 247);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 37);
            this.start.TabIndex = 9;
            this.start.Text = "Списать товар";
            this.start.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(256, 121);
            this.dataGridView1.TabIndex = 8;
            // 
            // pickStartStock
            // 
            this.pickStartStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickStartStock.FormattingEnabled = true;
            this.pickStartStock.Location = new System.Drawing.Point(12, 29);
            this.pickStartStock.Name = "pickStartStock";
            this.pickStartStock.Size = new System.Drawing.Size(256, 21);
            this.pickStartStock.TabIndex = 7;
            // 
            // pickStartStockLabel
            // 
            this.pickStartStockLabel.AutoSize = true;
            this.pickStartStockLabel.Location = new System.Drawing.Point(9, 12);
            this.pickStartStockLabel.Name = "pickStartStockLabel";
            this.pickStartStockLabel.Size = new System.Drawing.Size(140, 13);
            this.pickStartStockLabel.TabIndex = 6;
            this.pickStartStockLabel.Text = "Выберите склад отправки";
            // 
            // pickEndStock
            // 
            this.pickEndStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickEndStock.FormattingEnabled = true;
            this.pickEndStock.Location = new System.Drawing.Point(16, 80);
            this.pickEndStock.Name = "pickEndStock";
            this.pickEndStock.Size = new System.Drawing.Size(256, 21);
            this.pickEndStock.TabIndex = 11;
            // 
            // pickEndStockLabel
            // 
            this.pickEndStockLabel.AutoSize = true;
            this.pickEndStockLabel.Location = new System.Drawing.Point(13, 63);
            this.pickEndStockLabel.Name = "pickEndStockLabel";
            this.pickEndStockLabel.Size = new System.Drawing.Size(152, 13);
            this.pickEndStockLabel.TabIndex = 10;
            this.pickEndStockLabel.Text = "Выберите склад назначения";
            // 
            // MoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.pickEndStock);
            this.Controls.Add(this.pickEndStockLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pickStartStock);
            this.Controls.Add(this.pickStartStockLabel);
            this.Name = "MoveItems";
            this.ShowIcon = false;
            this.Text = "Перенести товар";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox pickStartStock;
        private System.Windows.Forms.Label pickStartStockLabel;
        private System.Windows.Forms.ComboBox pickEndStock;
        private System.Windows.Forms.Label pickEndStockLabel;
    }
}