namespace kursovayaKuznetsova
{
    partial class Revision
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
            this.choiseStockLabel = new System.Windows.Forms.Label();
            this.choiseStock = new System.Windows.Forms.ComboBox();
            this.lastRevisionLabel = new System.Windows.Forms.Label();
            this.lastRevisionDate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datas = new System.Windows.Forms.Label();
            this.lossOfPrositLabel = new System.Windows.Forms.Label();
            this.loseOfProfit = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.todayDateLabel = new System.Windows.Forms.Label();
            this.todayDate = new System.Windows.Forms.TextBox();
            this.inCassLabel = new System.Windows.Forms.Label();
            this.inCass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // choiseStockLabel
            // 
            this.choiseStockLabel.AutoSize = true;
            this.choiseStockLabel.Location = new System.Drawing.Point(14, 16);
            this.choiseStockLabel.Name = "choiseStockLabel";
            this.choiseStockLabel.Size = new System.Drawing.Size(84, 13);
            this.choiseStockLabel.TabIndex = 0;
            this.choiseStockLabel.Text = "Выбрать склад";
            // 
            // choiseStock
            // 
            this.choiseStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choiseStock.FormattingEnabled = true;
            this.choiseStock.Location = new System.Drawing.Point(135, 16);
            this.choiseStock.Name = "choiseStock";
            this.choiseStock.Size = new System.Drawing.Size(395, 21);
            this.choiseStock.TabIndex = 1;
            this.choiseStock.Text = "выберите склад...";
            // 
            // lastRevisionLabel
            // 
            this.lastRevisionLabel.AutoSize = true;
            this.lastRevisionLabel.Location = new System.Drawing.Point(14, 48);
            this.lastRevisionLabel.Name = "lastRevisionLabel";
            this.lastRevisionLabel.Size = new System.Drawing.Size(111, 13);
            this.lastRevisionLabel.TabIndex = 2;
            this.lastRevisionLabel.Text = "Последняя ревизия:";
            // 
            // lastRevisionDate
            // 
            this.lastRevisionDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastRevisionDate.Enabled = false;
            this.lastRevisionDate.Location = new System.Drawing.Point(135, 45);
            this.lastRevisionDate.Name = "lastRevisionDate";
            this.lastRevisionDate.Size = new System.Drawing.Size(395, 20);
            this.lastRevisionDate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 107);
            this.dataGridView1.TabIndex = 4;
            // 
            // Datas
            // 
            this.Datas.AutoSize = true;
            this.Datas.Location = new System.Drawing.Point(14, 107);
            this.Datas.Name = "Datas";
            this.Datas.Size = new System.Drawing.Size(139, 13);
            this.Datas.TabIndex = 5;
            this.Datas.Text = "Данные (изменять здесь)";
            // 
            // lossOfPrositLabel
            // 
            this.lossOfPrositLabel.AutoSize = true;
            this.lossOfPrositLabel.Location = new System.Drawing.Point(14, 246);
            this.lossOfPrositLabel.Name = "lossOfPrositLabel";
            this.lossOfPrositLabel.Size = new System.Drawing.Size(186, 13);
            this.lossOfPrositLabel.TabIndex = 6;
            this.lossOfPrositLabel.Text = "Утеряно (расчет в себестоимости):";
            // 
            // loseOfProfit
            // 
            this.loseOfProfit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loseOfProfit.Location = new System.Drawing.Point(206, 243);
            this.loseOfProfit.Name = "loseOfProfit";
            this.loseOfProfit.Size = new System.Drawing.Size(147, 20);
            this.loseOfProfit.TabIndex = 7;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(15, 328);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(515, 39);
            this.start.TabIndex = 8;
            this.start.Text = "Принять";
            this.start.UseVisualStyleBackColor = true;
            // 
            // todayDateLabel
            // 
            this.todayDateLabel.AutoSize = true;
            this.todayDateLabel.Location = new System.Drawing.Point(14, 74);
            this.todayDateLabel.Name = "todayDateLabel";
            this.todayDateLabel.Size = new System.Drawing.Size(52, 13);
            this.todayDateLabel.TabIndex = 9;
            this.todayDateLabel.Text = "Сегодня:";
            // 
            // todayDate
            // 
            this.todayDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todayDate.Enabled = false;
            this.todayDate.Location = new System.Drawing.Point(135, 71);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(395, 20);
            this.todayDate.TabIndex = 10;
            // 
            // inCassLabel
            // 
            this.inCassLabel.AutoSize = true;
            this.inCassLabel.Location = new System.Drawing.Point(14, 270);
            this.inCassLabel.Name = "inCassLabel";
            this.inCassLabel.Size = new System.Drawing.Size(165, 13);
            this.inCassLabel.TabIndex = 11;
            this.inCassLabel.Text = "На кассе (для торговых точек):";
            // 
            // inCass
            // 
            this.inCass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inCass.Location = new System.Drawing.Point(206, 270);
            this.inCass.Name = "inCass";
            this.inCass.Size = new System.Drawing.Size(147, 20);
            this.inCass.TabIndex = 12;
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.inCass);
            this.Controls.Add(this.inCassLabel);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.todayDateLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.loseOfProfit);
            this.Controls.Add(this.lossOfPrositLabel);
            this.Controls.Add(this.Datas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lastRevisionDate);
            this.Controls.Add(this.lastRevisionLabel);
            this.Controls.Add(this.choiseStock);
            this.Controls.Add(this.choiseStockLabel);
            this.Name = "Revision";
            this.ShowIcon = false;
            this.Text = "Ревизия";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choiseStockLabel;
        private System.Windows.Forms.ComboBox choiseStock;
        private System.Windows.Forms.Label lastRevisionLabel;
        private System.Windows.Forms.TextBox lastRevisionDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Datas;
        private System.Windows.Forms.Label lossOfPrositLabel;
        private System.Windows.Forms.TextBox loseOfProfit;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label todayDateLabel;
        private System.Windows.Forms.TextBox todayDate;
        private System.Windows.Forms.Label inCassLabel;
        private System.Windows.Forms.TextBox inCass;
    }
}