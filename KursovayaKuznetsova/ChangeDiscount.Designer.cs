namespace kursovayaKuznetsova
{
    partial class ChangeDiscount
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
            this.pickDiscountLabel = new System.Windows.Forms.Label();
            this.pickDiscount = new System.Windows.Forms.ComboBox();
            this.fromNum = new System.Windows.Forms.NumericUpDown();
            this.fromNumCheckBox = new System.Windows.Forms.CheckBox();
            this.selfPrice = new System.Windows.Forms.RadioButton();
            this.value = new System.Windows.Forms.NumericUpDown();
            this.valueLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.comboCheckBox = new System.Windows.Forms.CheckBox();
            this.fixedPrice = new System.Windows.Forms.RadioButton();
            this.percent = new System.Windows.Forms.RadioButton();
            this.forFree = new System.Windows.Forms.RadioButton();
            this.typeLabel = new System.Windows.Forms.Label();
            this.pickItem = new System.Windows.Forms.ComboBox();
            this.pickItemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fromNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            this.SuspendLayout();
            // 
            // pickDiscountLabel
            // 
            this.pickDiscountLabel.AutoSize = true;
            this.pickDiscountLabel.Location = new System.Drawing.Point(13, 13);
            this.pickDiscountLabel.Name = "pickDiscountLabel";
            this.pickDiscountLabel.Size = new System.Drawing.Size(89, 13);
            this.pickDiscountLabel.TabIndex = 0;
            this.pickDiscountLabel.Text = "Выбрать скидку";
            // 
            // pickDiscount
            // 
            this.pickDiscount.FormattingEnabled = true;
            this.pickDiscount.Location = new System.Drawing.Point(13, 30);
            this.pickDiscount.Name = "pickDiscount";
            this.pickDiscount.Size = new System.Drawing.Size(259, 21);
            this.pickDiscount.TabIndex = 1;
            // 
            // fromNum
            // 
            this.fromNum.Enabled = false;
            this.fromNum.Location = new System.Drawing.Point(16, 180);
            this.fromNum.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.fromNum.Name = "fromNum";
            this.fromNum.Size = new System.Drawing.Size(145, 20);
            this.fromNum.TabIndex = 27;
            // 
            // fromNumCheckBox
            // 
            this.fromNumCheckBox.AutoSize = true;
            this.fromNumCheckBox.Location = new System.Drawing.Point(16, 160);
            this.fromNumCheckBox.Name = "fromNumCheckBox";
            this.fromNumCheckBox.Size = new System.Drawing.Size(236, 17);
            this.fromNumCheckBox.TabIndex = 26;
            this.fromNumCheckBox.Text = "При покупке больше экземпляров, чем...";
            this.fromNumCheckBox.UseVisualStyleBackColor = true;
            // 
            // selfPrice
            // 
            this.selfPrice.AutoSize = true;
            this.selfPrice.Location = new System.Drawing.Point(13, 292);
            this.selfPrice.Name = "selfPrice";
            this.selfPrice.Size = new System.Drawing.Size(120, 17);
            this.selfPrice.TabIndex = 25;
            this.selfPrice.TabStop = true;
            this.selfPrice.Text = "По себестоимости";
            this.selfPrice.UseVisualStyleBackColor = true;
            // 
            // value
            // 
            this.value.Enabled = false;
            this.value.Location = new System.Drawing.Point(13, 333);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(148, 20);
            this.value.TabIndex = 24;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(13, 316);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(94, 13);
            this.valueLabel.TabIndex = 23;
            this.valueLabel.Text = "Значение скидки";
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(13, 364);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 35);
            this.start.TabIndex = 22;
            this.start.Text = "Отредактировать";
            this.start.UseVisualStyleBackColor = true;
            // 
            // combo
            // 
            this.combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo.Enabled = false;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(16, 132);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(256, 21);
            this.combo.TabIndex = 21;
            // 
            // comboCheckBox
            // 
            this.comboCheckBox.AutoSize = true;
            this.comboCheckBox.Location = new System.Drawing.Point(16, 108);
            this.comboCheckBox.Name = "comboCheckBox";
            this.comboCheckBox.Size = new System.Drawing.Size(148, 17);
            this.comboCheckBox.TabIndex = 20;
            this.comboCheckBox.Text = "При покупке вместе с...";
            this.comboCheckBox.UseVisualStyleBackColor = true;
            // 
            // fixedPrice
            // 
            this.fixedPrice.AutoSize = true;
            this.fixedPrice.Location = new System.Drawing.Point(13, 268);
            this.fixedPrice.Name = "fixedPrice";
            this.fixedPrice.Size = new System.Drawing.Size(95, 17);
            this.fixedPrice.TabIndex = 19;
            this.fixedPrice.TabStop = true;
            this.fixedPrice.Text = "Выбрать цену";
            this.fixedPrice.UseVisualStyleBackColor = true;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(13, 244);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(87, 17);
            this.percent.TabIndex = 18;
            this.percent.TabStop = true;
            this.percent.Text = "В процентах";
            this.percent.UseVisualStyleBackColor = true;
            // 
            // forFree
            // 
            this.forFree.AutoSize = true;
            this.forFree.Location = new System.Drawing.Point(13, 220);
            this.forFree.Name = "forFree";
            this.forFree.Size = new System.Drawing.Size(79, 17);
            this.forFree.TabIndex = 17;
            this.forFree.TabStop = true;
            this.forFree.Text = "Бесплатно";
            this.forFree.UseVisualStyleBackColor = true;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(13, 203);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(116, 13);
            this.typeLabel.TabIndex = 16;
            this.typeLabel.Text = "Выберите тип скидки";
            // 
            // pickItem
            // 
            this.pickItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickItem.Enabled = false;
            this.pickItem.FormattingEnabled = true;
            this.pickItem.Location = new System.Drawing.Point(16, 80);
            this.pickItem.Name = "pickItem";
            this.pickItem.Size = new System.Drawing.Size(256, 21);
            this.pickItem.TabIndex = 15;
            // 
            // pickItemLabel
            // 
            this.pickItemLabel.AutoSize = true;
            this.pickItemLabel.Location = new System.Drawing.Point(13, 63);
            this.pickItemLabel.Name = "pickItemLabel";
            this.pickItemLabel.Size = new System.Drawing.Size(89, 13);
            this.pickItemLabel.TabIndex = 14;
            this.pickItemLabel.Text = "Выберите товар";
            // 
            // ChangeDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.fromNum);
            this.Controls.Add(this.fromNumCheckBox);
            this.Controls.Add(this.selfPrice);
            this.Controls.Add(this.value);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.comboCheckBox);
            this.Controls.Add(this.fixedPrice);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.forFree);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.pickItem);
            this.Controls.Add(this.pickItemLabel);
            this.Controls.Add(this.pickDiscount);
            this.Controls.Add(this.pickDiscountLabel);
            this.Name = "ChangeDiscount";
            this.ShowIcon = false;
            this.Text = "Изменить скидку";
            ((System.ComponentModel.ISupportInitialize)(this.fromNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickDiscountLabel;
        private System.Windows.Forms.ComboBox pickDiscount;
        private System.Windows.Forms.NumericUpDown fromNum;
        private System.Windows.Forms.CheckBox fromNumCheckBox;
        private System.Windows.Forms.RadioButton selfPrice;
        private System.Windows.Forms.NumericUpDown value;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.CheckBox comboCheckBox;
        private System.Windows.Forms.RadioButton fixedPrice;
        private System.Windows.Forms.RadioButton percent;
        private System.Windows.Forms.RadioButton forFree;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox pickItem;
        private System.Windows.Forms.Label pickItemLabel;
    }
}