namespace kursovayaKuznetsova
{
    partial class ListDiscount
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
            this.withDiscount = new System.Windows.Forms.CheckBox();
            this.manufactor = new System.Windows.Forms.CheckBox();
            this.minimum = new System.Windows.Forms.CheckBox();
            this.selfPrice = new System.Windows.Forms.CheckBox();
            this.start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inCass = new System.Windows.Forms.CheckBox();
            this.moreOrLessPrice = new System.Windows.Forms.ComboBox();
            this.moneyOnCassLabel = new System.Windows.Forms.Label();
            this.moreOrLessSelfPrice = new System.Windows.Forms.ComboBox();
            this.selfPriceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // withDiscount
            // 
            this.withDiscount.AutoSize = true;
            this.withDiscount.Location = new System.Drawing.Point(13, 110);
            this.withDiscount.Name = "withDiscount";
            this.withDiscount.Size = new System.Drawing.Size(169, 17);
            this.withDiscount.TabIndex = 45;
            this.withDiscount.Text = "Только при покупке больше";
            this.withDiscount.UseVisualStyleBackColor = true;
            // 
            // manufactor
            // 
            this.manufactor.AutoSize = true;
            this.manufactor.Location = new System.Drawing.Point(13, 86);
            this.manufactor.Name = "manufactor";
            this.manufactor.Size = new System.Drawing.Size(107, 17);
            this.manufactor.TabIndex = 43;
            this.manufactor.Text = "Только с комбо";
            this.manufactor.UseVisualStyleBackColor = true;
            // 
            // minimum
            // 
            this.minimum.AutoSize = true;
            this.minimum.Location = new System.Drawing.Point(12, 16);
            this.minimum.Name = "minimum";
            this.minimum.Size = new System.Drawing.Size(98, 17);
            this.minimum.TabIndex = 39;
            this.minimum.Text = "Действующие";
            this.minimum.UseVisualStyleBackColor = true;
            // 
            // selfPrice
            // 
            this.selfPrice.AutoSize = true;
            this.selfPrice.Location = new System.Drawing.Point(12, 39);
            this.selfPrice.Name = "selfPrice";
            this.selfPrice.Size = new System.Drawing.Size(75, 17);
            this.selfPrice.TabIndex = 35;
            this.selfPrice.Text = "Начались";
            this.selfPrice.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 289);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(466, 38);
            this.start.TabIndex = 34;
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
            this.dataGridView1.TabIndex = 33;
            // 
            // inCass
            // 
            this.inCass.AutoSize = true;
            this.inCass.Location = new System.Drawing.Point(13, 62);
            this.inCass.Name = "inCass";
            this.inCass.Size = new System.Drawing.Size(80, 17);
            this.inCass.TabIndex = 29;
            this.inCass.Text = "Кончились";
            this.inCass.UseVisualStyleBackColor = true;
            // 
            // moreOrLessPrice
            // 
            this.moreOrLessPrice.FormattingEnabled = true;
            this.moreOrLessPrice.Location = new System.Drawing.Point(123, 58);
            this.moreOrLessPrice.Name = "moreOrLessPrice";
            this.moreOrLessPrice.Size = new System.Drawing.Size(74, 21);
            this.moreOrLessPrice.TabIndex = 30;
            // 
            // moneyOnCassLabel
            // 
            this.moneyOnCassLabel.AutoSize = true;
            this.moneyOnCassLabel.Location = new System.Drawing.Point(203, 62);
            this.moneyOnCassLabel.Name = "moneyOnCassLabel";
            this.moneyOnCassLabel.Size = new System.Drawing.Size(26, 13);
            this.moneyOnCassLabel.TabIndex = 31;
            this.moneyOnCassLabel.Text = "чем";
            // 
            // moreOrLessSelfPrice
            // 
            this.moreOrLessSelfPrice.FormattingEnabled = true;
            this.moreOrLessSelfPrice.Location = new System.Drawing.Point(123, 35);
            this.moreOrLessSelfPrice.Name = "moreOrLessSelfPrice";
            this.moreOrLessSelfPrice.Size = new System.Drawing.Size(74, 21);
            this.moreOrLessSelfPrice.TabIndex = 36;
            // 
            // selfPriceLabel
            // 
            this.selfPriceLabel.AutoSize = true;
            this.selfPriceLabel.Location = new System.Drawing.Point(202, 39);
            this.selfPriceLabel.Name = "selfPriceLabel";
            this.selfPriceLabel.Size = new System.Drawing.Size(26, 13);
            this.selfPriceLabel.TabIndex = 37;
            this.selfPriceLabel.Text = "чем";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 47;
            // 
            // ListDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 339);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.withDiscount);
            this.Controls.Add(this.manufactor);
            this.Controls.Add(this.minimum);
            this.Controls.Add(this.selfPriceLabel);
            this.Controls.Add(this.moreOrLessSelfPrice);
            this.Controls.Add(this.selfPrice);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.moneyOnCassLabel);
            this.Controls.Add(this.moreOrLessPrice);
            this.Controls.Add(this.inCass);
            this.Name = "ListDiscount";
            this.ShowIcon = false;
            this.Text = "Список, поиск и изменение скидок";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox withDiscount;
        private System.Windows.Forms.CheckBox manufactor;
        private System.Windows.Forms.CheckBox minimum;
        private System.Windows.Forms.CheckBox selfPrice;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox inCass;
        private System.Windows.Forms.ComboBox moreOrLessPrice;
        private System.Windows.Forms.Label moneyOnCassLabel;
        private System.Windows.Forms.ComboBox moreOrLessSelfPrice;
        private System.Windows.Forms.Label selfPriceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}