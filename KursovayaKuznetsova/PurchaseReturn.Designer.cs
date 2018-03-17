namespace kursovayaKuznetsova
{
    partial class PurchaseReturn
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
            this.choiseItem = new System.Windows.Forms.ComboBox();
            this.choiseItemLabel = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchedDatesLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.findedDates = new System.Windows.Forms.ComboBox();
            this.checksOrderLabel = new System.Windows.Forms.Label();
            this.countReturnLabel = new System.Windows.Forms.Label();
            this.countReturn = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // choiseItem
            // 
            this.choiseItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choiseItem.FormattingEnabled = true;
            this.choiseItem.Location = new System.Drawing.Point(12, 29);
            this.choiseItem.Name = "choiseItem";
            this.choiseItem.Size = new System.Drawing.Size(280, 21);
            this.choiseItem.TabIndex = 0;
            // 
            // choiseItemLabel
            // 
            this.choiseItemLabel.AutoSize = true;
            this.choiseItemLabel.Location = new System.Drawing.Point(13, 13);
            this.choiseItemLabel.Name = "choiseItemLabel";
            this.choiseItemLabel.Size = new System.Drawing.Size(78, 13);
            this.choiseItemLabel.TabIndex = 1;
            this.choiseItemLabel.Text = "Выбор товара";
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Location = new System.Drawing.Point(298, 29);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Искать";
            this.search.UseVisualStyleBackColor = true;
            // 
            // searchedDatesLabel
            // 
            this.searchedDatesLabel.AutoSize = true;
            this.searchedDatesLabel.Location = new System.Drawing.Point(13, 58);
            this.searchedDatesLabel.Name = "searchedDatesLabel";
            this.searchedDatesLabel.Size = new System.Drawing.Size(93, 13);
            this.searchedDatesLabel.TabIndex = 3;
            this.searchedDatesLabel.Text = "Найденные даты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 90);
            this.dataGridView1.TabIndex = 4;
            // 
            // findedDates
            // 
            this.findedDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findedDates.FormattingEnabled = true;
            this.findedDates.Location = new System.Drawing.Point(12, 75);
            this.findedDates.Name = "findedDates";
            this.findedDates.Size = new System.Drawing.Size(361, 21);
            this.findedDates.TabIndex = 5;
            // 
            // checksOrderLabel
            // 
            this.checksOrderLabel.AutoSize = true;
            this.checksOrderLabel.Location = new System.Drawing.Point(13, 108);
            this.checksOrderLabel.Name = "checksOrderLabel";
            this.checksOrderLabel.Size = new System.Drawing.Size(69, 13);
            this.checksOrderLabel.TabIndex = 6;
            this.checksOrderLabel.Text = "Чек за день";
            // 
            // countReturnLabel
            // 
            this.countReturnLabel.AutoSize = true;
            this.countReturnLabel.Location = new System.Drawing.Point(13, 227);
            this.countReturnLabel.Name = "countReturnLabel";
            this.countReturnLabel.Size = new System.Drawing.Size(191, 13);
            this.countReturnLabel.TabIndex = 7;
            this.countReturnLabel.Text = "Количество возвращаемых товаров";
            // 
            // countReturn
            // 
            this.countReturn.Location = new System.Drawing.Point(13, 244);
            this.countReturn.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.countReturn.Name = "countReturn";
            this.countReturn.Size = new System.Drawing.Size(120, 20);
            this.countReturn.TabIndex = 8;
            this.countReturn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(16, 271);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(357, 37);
            this.start.TabIndex = 9;
            this.start.Text = "Вернуть товар";
            this.start.UseVisualStyleBackColor = true;
            // 
            // PurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.start);
            this.Controls.Add(this.countReturn);
            this.Controls.Add(this.countReturnLabel);
            this.Controls.Add(this.checksOrderLabel);
            this.Controls.Add(this.findedDates);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchedDatesLabel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.choiseItemLabel);
            this.Controls.Add(this.choiseItem);
            this.MinimumSize = new System.Drawing.Size(401, 359);
            this.Name = "PurchaseReturn";
            this.ShowIcon = false;
            this.Text = "Возврат товара";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choiseItem;
        private System.Windows.Forms.Label choiseItemLabel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label searchedDatesLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox findedDates;
        private System.Windows.Forms.Label checksOrderLabel;
        private System.Windows.Forms.Label countReturnLabel;
        private System.Windows.Forms.NumericUpDown countReturn;
        private System.Windows.Forms.Button start;
    }
}