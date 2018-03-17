namespace kursovayaKuznetsova
{
    partial class NewDiscount
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
            this.pickItemLabel = new System.Windows.Forms.Label();
            this.pickItem = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.forFree = new System.Windows.Forms.RadioButton();
            this.percent = new System.Windows.Forms.RadioButton();
            this.fixedPrice = new System.Windows.Forms.RadioButton();
            this.comboCheckBox = new System.Windows.Forms.CheckBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.NumericUpDown();
            this.selfPrice = new System.Windows.Forms.RadioButton();
            this.fromNumCheckBox = new System.Windows.Forms.CheckBox();
            this.fromNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.moreCombo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pickItemLabel
            // 
            this.pickItemLabel.AutoSize = true;
            this.pickItemLabel.Location = new System.Drawing.Point(13, 13);
            this.pickItemLabel.Name = "pickItemLabel";
            this.pickItemLabel.Size = new System.Drawing.Size(89, 13);
            this.pickItemLabel.TabIndex = 0;
            this.pickItemLabel.Text = "Выберите товар";
            // 
            // pickItem
            // 
            this.pickItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickItem.FormattingEnabled = true;
            this.pickItem.Location = new System.Drawing.Point(16, 30);
            this.pickItem.Name = "pickItem";
            this.pickItem.Size = new System.Drawing.Size(256, 21);
            this.pickItem.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(16, 208);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(116, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Выберите тип скидки";
            // 
            // forFree
            // 
            this.forFree.AutoSize = true;
            this.forFree.Location = new System.Drawing.Point(16, 225);
            this.forFree.Name = "forFree";
            this.forFree.Size = new System.Drawing.Size(79, 17);
            this.forFree.TabIndex = 3;
            this.forFree.TabStop = true;
            this.forFree.Text = "Бесплатно";
            this.forFree.UseVisualStyleBackColor = true;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(16, 249);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(87, 17);
            this.percent.TabIndex = 4;
            this.percent.TabStop = true;
            this.percent.Text = "В процентах";
            this.percent.UseVisualStyleBackColor = true;
            // 
            // fixedPrice
            // 
            this.fixedPrice.AutoSize = true;
            this.fixedPrice.Location = new System.Drawing.Point(16, 273);
            this.fixedPrice.Name = "fixedPrice";
            this.fixedPrice.Size = new System.Drawing.Size(95, 17);
            this.fixedPrice.TabIndex = 5;
            this.fixedPrice.TabStop = true;
            this.fixedPrice.Text = "Выбрать цену";
            this.fixedPrice.UseVisualStyleBackColor = true;
            // 
            // comboCheckBox
            // 
            this.comboCheckBox.AutoSize = true;
            this.comboCheckBox.Location = new System.Drawing.Point(16, 58);
            this.comboCheckBox.Name = "comboCheckBox";
            this.comboCheckBox.Size = new System.Drawing.Size(148, 17);
            this.comboCheckBox.TabIndex = 6;
            this.comboCheckBox.Text = "При покупке вместе с...";
            this.comboCheckBox.UseVisualStyleBackColor = true;
            // 
            // combo
            // 
            this.combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo.Enabled = false;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(16, 82);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(256, 21);
            this.combo.TabIndex = 7;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(13, 373);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 32);
            this.start.TabIndex = 8;
            this.start.Text = "Создать";
            this.start.UseVisualStyleBackColor = true;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(16, 321);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(94, 13);
            this.valueLabel.TabIndex = 9;
            this.valueLabel.Text = "Значение скидки";
            // 
            // value
            // 
            this.value.Enabled = false;
            this.value.Location = new System.Drawing.Point(16, 338);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(148, 20);
            this.value.TabIndex = 10;
            // 
            // selfPrice
            // 
            this.selfPrice.AutoSize = true;
            this.selfPrice.Location = new System.Drawing.Point(16, 297);
            this.selfPrice.Name = "selfPrice";
            this.selfPrice.Size = new System.Drawing.Size(120, 17);
            this.selfPrice.TabIndex = 11;
            this.selfPrice.TabStop = true;
            this.selfPrice.Text = "По себестоимости";
            this.selfPrice.UseVisualStyleBackColor = true;
            // 
            // fromNumCheckBox
            // 
            this.fromNumCheckBox.AutoSize = true;
            this.fromNumCheckBox.Location = new System.Drawing.Point(16, 110);
            this.fromNumCheckBox.Name = "fromNumCheckBox";
            this.fromNumCheckBox.Size = new System.Drawing.Size(236, 17);
            this.fromNumCheckBox.TabIndex = 12;
            this.fromNumCheckBox.Text = "При покупке больше экземпляров, чем...";
            this.fromNumCheckBox.UseVisualStyleBackColor = true;
            // 
            // fromNum
            // 
            this.fromNum.Enabled = false;
            this.fromNum.Location = new System.Drawing.Point(16, 130);
            this.fromNum.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.fromNum.Name = "fromNum";
            this.fromNum.Size = new System.Drawing.Size(145, 20);
            this.fromNum.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(16, 176);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // moreCombo
            // 
            this.moreCombo.AutoSize = true;
            this.moreCombo.Location = new System.Drawing.Point(16, 156);
            this.moreCombo.Name = "moreCombo";
            this.moreCombo.Size = new System.Drawing.Size(230, 17);
            this.moreCombo.TabIndex = 14;
            this.moreCombo.Text = "При покупке комбо-товара более, чем...";
            this.moreCombo.UseVisualStyleBackColor = true;
            // 
            // NewDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.moreCombo);
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
            this.Name = "NewDiscount";
            this.ShowIcon = false;
            this.Text = "Создать скидку";
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickItemLabel;
        private System.Windows.Forms.ComboBox pickItem;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.RadioButton forFree;
        private System.Windows.Forms.RadioButton percent;
        private System.Windows.Forms.RadioButton fixedPrice;
        private System.Windows.Forms.CheckBox comboCheckBox;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.NumericUpDown value;
        private System.Windows.Forms.RadioButton selfPrice;
        private System.Windows.Forms.CheckBox fromNumCheckBox;
        private System.Windows.Forms.NumericUpDown fromNum;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox moreCombo;
    }
}