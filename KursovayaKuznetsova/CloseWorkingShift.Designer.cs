namespace kursovayaKuznetsova
{
    partial class CloseWorkingShift
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.shiftingDate = new System.Windows.Forms.DateTimePicker();
            this.placeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.TextBox();
            this.realMoneyLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.realSum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.realSum)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата";
            // 
            // shiftingDate
            // 
            this.shiftingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shiftingDate.Location = new System.Drawing.Point(12, 25);
            this.shiftingDate.Name = "shiftingDate";
            this.shiftingDate.Size = new System.Drawing.Size(283, 20);
            this.shiftingDate.TabIndex = 2;
            this.shiftingDate.Value = new System.DateTime(2018, 3, 3, 18, 50, 50, 0);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(12, 48);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(39, 13);
            this.placeLabel.TabIndex = 3;
            this.placeLabel.Text = "Место";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(12, 110);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(116, 13);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "В кассе должно быть";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(12, 126);
            this.money.Name = "money";
            this.money.ReadOnly = true;
            this.money.Size = new System.Drawing.Size(123, 20);
            this.money.TabIndex = 6;
            this.money.TabStop = false;
            this.money.Text = "0";
            // 
            // realMoneyLabel
            // 
            this.realMoneyLabel.AutoSize = true;
            this.realMoneyLabel.Location = new System.Drawing.Point(12, 153);
            this.realMoneyLabel.Name = "realMoneyLabel";
            this.realMoneyLabel.Size = new System.Drawing.Size(178, 13);
            this.realMoneyLabel.TabIndex = 7;
            this.realMoneyLabel.Text = "В кассе реально (без доложения)";
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 209);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(283, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Закрыть смену";
            this.start.UseVisualStyleBackColor = true;
            // 
            // realSum
            // 
            this.realSum.DecimalPlaces = 2;
            this.realSum.Location = new System.Drawing.Point(15, 169);
            this.realSum.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.realSum.Name = "realSum";
            this.realSum.Size = new System.Drawing.Size(120, 20);
            this.realSum.TabIndex = 10;
            this.realSum.ThousandsSeparator = true;
            // 
            // CloseWorkingShift
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 241);
            this.Controls.Add(this.realSum);
            this.Controls.Add(this.start);
            this.Controls.Add(this.realMoneyLabel);
            this.Controls.Add(this.money);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.shiftingDate);
            this.Controls.Add(this.dateLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseWorkingShift";
            this.ShowIcon = false;
            this.Text = "Закрыть смену";
            ((System.ComponentModel.ISupportInitialize)(this.realSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker shiftingDate;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Label realMoneyLabel;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown realSum;
    }
}