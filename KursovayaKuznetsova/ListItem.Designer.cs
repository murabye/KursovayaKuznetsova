namespace kursovayaKuznetsova
{
    partial class ListItem
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
            this.choiseNumPrice = new System.Windows.Forms.NumericUpDown();
            this.moneyOnCassLabel = new System.Windows.Forms.Label();
            this.moreOrLessPrice = new System.Windows.Forms.ComboBox();
            this.inCass = new System.Windows.Forms.CheckBox();
            this.choiseNumSelf = new System.Windows.Forms.NumericUpDown();
            this.selfPriceLabel = new System.Windows.Forms.Label();
            this.moreOrLessSelfPrice = new System.Windows.Forms.ComboBox();
            this.selfPrice = new System.Windows.Forms.CheckBox();
            this.choiseNumLabel = new System.Windows.Forms.NumericUpDown();
            this.minLabel = new System.Windows.Forms.Label();
            this.moreOrLessMin = new System.Windows.Forms.ComboBox();
            this.minimum = new System.Windows.Forms.CheckBox();
            this.manufactor = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.withDiscount = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNumPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNumSelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNumLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 289);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(466, 38);
            this.start.TabIndex = 17;
            this.start.Text = "Принять";
            this.start.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // choiseNumPrice
            // 
            this.choiseNumPrice.Location = new System.Drawing.Point(235, 59);
            this.choiseNumPrice.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.choiseNumPrice.Name = "choiseNumPrice";
            this.choiseNumPrice.Size = new System.Drawing.Size(68, 20);
            this.choiseNumPrice.TabIndex = 15;
            // 
            // moneyOnCassLabel
            // 
            this.moneyOnCassLabel.AutoSize = true;
            this.moneyOnCassLabel.Location = new System.Drawing.Point(203, 62);
            this.moneyOnCassLabel.Name = "moneyOnCassLabel";
            this.moneyOnCassLabel.Size = new System.Drawing.Size(26, 13);
            this.moneyOnCassLabel.TabIndex = 14;
            this.moneyOnCassLabel.Text = "чем";
            // 
            // moreOrLessPrice
            // 
            this.moreOrLessPrice.FormattingEnabled = true;
            this.moreOrLessPrice.Location = new System.Drawing.Point(151, 58);
            this.moreOrLessPrice.Name = "moreOrLessPrice";
            this.moreOrLessPrice.Size = new System.Drawing.Size(46, 21);
            this.moreOrLessPrice.TabIndex = 13;
            // 
            // inCass
            // 
            this.inCass.AutoSize = true;
            this.inCass.Location = new System.Drawing.Point(13, 62);
            this.inCass.Name = "inCass";
            this.inCass.Size = new System.Drawing.Size(90, 17);
            this.inCass.TabIndex = 12;
            this.inCass.Text = "Цена товара";
            this.inCass.UseVisualStyleBackColor = true;
            // 
            // choiseNumSelf
            // 
            this.choiseNumSelf.Location = new System.Drawing.Point(235, 36);
            this.choiseNumSelf.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.choiseNumSelf.Name = "choiseNumSelf";
            this.choiseNumSelf.Size = new System.Drawing.Size(68, 20);
            this.choiseNumSelf.TabIndex = 21;
            // 
            // selfPriceLabel
            // 
            this.selfPriceLabel.AutoSize = true;
            this.selfPriceLabel.Location = new System.Drawing.Point(202, 39);
            this.selfPriceLabel.Name = "selfPriceLabel";
            this.selfPriceLabel.Size = new System.Drawing.Size(26, 13);
            this.selfPriceLabel.TabIndex = 20;
            this.selfPriceLabel.Text = "чем";
            // 
            // moreOrLessSelfPrice
            // 
            this.moreOrLessSelfPrice.FormattingEnabled = true;
            this.moreOrLessSelfPrice.Location = new System.Drawing.Point(151, 35);
            this.moreOrLessSelfPrice.Name = "moreOrLessSelfPrice";
            this.moreOrLessSelfPrice.Size = new System.Drawing.Size(46, 21);
            this.moreOrLessSelfPrice.TabIndex = 19;
            // 
            // selfPrice
            // 
            this.selfPrice.AutoSize = true;
            this.selfPrice.Location = new System.Drawing.Point(12, 39);
            this.selfPrice.Name = "selfPrice";
            this.selfPrice.Size = new System.Drawing.Size(105, 17);
            this.selfPrice.TabIndex = 18;
            this.selfPrice.Text = "Себестоимость";
            this.selfPrice.UseVisualStyleBackColor = true;
            // 
            // choiseNumLabel
            // 
            this.choiseNumLabel.Location = new System.Drawing.Point(235, 13);
            this.choiseNumLabel.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.choiseNumLabel.Name = "choiseNumLabel";
            this.choiseNumLabel.Size = new System.Drawing.Size(68, 20);
            this.choiseNumLabel.TabIndex = 25;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(202, 16);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(26, 13);
            this.minLabel.TabIndex = 24;
            this.minLabel.Text = "чем";
            // 
            // moreOrLessMin
            // 
            this.moreOrLessMin.FormattingEnabled = true;
            this.moreOrLessMin.Location = new System.Drawing.Point(151, 12);
            this.moreOrLessMin.Name = "moreOrLessMin";
            this.moreOrLessMin.Size = new System.Drawing.Size(46, 21);
            this.moreOrLessMin.TabIndex = 23;
            // 
            // minimum
            // 
            this.minimum.AutoSize = true;
            this.minimum.Location = new System.Drawing.Point(12, 16);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(133, 17);
            this.minimum.TabIndex = 22;
            this.minimum.Text = "Минимальное кол-во";
            this.minimum.UseVisualStyleBackColor = true;
            // 
            // manufactor
            // 
            this.manufactor.AutoSize = true;
            this.manufactor.Location = new System.Drawing.Point(13, 86);
            this.manufactor.Name = "manufactor";
            this.manufactor.Size = new System.Drawing.Size(84, 17);
            this.manufactor.TabIndex = 26;
            this.manufactor.Text = "Пастовщик";
            this.manufactor.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // withDiscount
            // 
            this.withDiscount.AutoSize = true;
            this.withDiscount.Location = new System.Drawing.Point(13, 110);
            this.withDiscount.Name = "withDiscount";
            this.withDiscount.Size = new System.Drawing.Size(123, 17);
            this.withDiscount.TabIndex = 28;
            this.withDiscount.Text = "Только со скидкой";
            this.withDiscount.UseVisualStyleBackColor = true;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 339);
            this.Controls.Add(this.withDiscount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.manufactor);
            this.Controls.Add(this.choiseNumLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.moreOrLessMin);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.choiseNumSelf);
            this.Controls.Add(this.selfPriceLabel);
            this.Controls.Add(this.moreOrLessSelfPrice);
            this.Controls.Add(this.selfPrice);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.choiseNumPrice);
            this.Controls.Add(this.moneyOnCassLabel);
            this.Controls.Add(this.moreOrLessPrice);
            this.Controls.Add(this.inCass);
            this.Name = "ListItem";
            this.ShowIcon = false;
            this.Text = "Список, поиск и изменение товаров";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNumPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNumSelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNumLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown choiseNumPrice;
        private System.Windows.Forms.Label moneyOnCassLabel;
        private System.Windows.Forms.ComboBox moreOrLessPrice;
        private System.Windows.Forms.CheckBox inCass;
        private System.Windows.Forms.NumericUpDown choiseNumSelf;
        private System.Windows.Forms.Label selfPriceLabel;
        private System.Windows.Forms.ComboBox moreOrLessSelfPrice;
        private System.Windows.Forms.CheckBox selfPrice;
        private System.Windows.Forms.NumericUpDown choiseNumLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.ComboBox moreOrLessMin;
        private System.Windows.Forms.CheckBox minimum;
        private System.Windows.Forms.CheckBox manufactor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox withDiscount;
    }
}