namespace kursovayaKuznetsova
{
    partial class OpenWorkShift
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
            this.isWrong = new System.Windows.Forms.CheckBox();
            this.realSumLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.realSum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.realSum)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата";
            // 
            // shiftingDate
            // 
            this.shiftingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shiftingDate.Location = new System.Drawing.Point(13, 30);
            this.shiftingDate.Name = "shiftingDate";
            this.shiftingDate.Size = new System.Drawing.Size(270, 20);
            this.shiftingDate.TabIndex = 1;
            this.shiftingDate.Value = new System.DateTime(2018, 3, 3, 18, 50, 50, 0);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(13, 57);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(39, 13);
            this.placeLabel.TabIndex = 2;
            this.placeLabel.Text = "Место";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Enabled = false;
            this.moneyLabel.Location = new System.Drawing.Point(13, 124);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(47, 13);
            this.moneyLabel.TabIndex = 4;
            this.moneyLabel.Text = "В кассе";
            // 
            // money
            // 
            this.money.Enabled = false;
            this.money.Location = new System.Drawing.Point(13, 141);
            this.money.Name = "money";
            this.money.ReadOnly = true;
            this.money.Size = new System.Drawing.Size(123, 20);
            this.money.TabIndex = 5;
            this.money.TabStop = false;
            this.money.Text = "0";
            // 
            // isWrong
            // 
            this.isWrong.AutoSize = true;
            this.isWrong.Enabled = false;
            this.isWrong.Location = new System.Drawing.Point(13, 168);
            this.isWrong.Name = "isWrong";
            this.isWrong.Size = new System.Drawing.Size(240, 17);
            this.isWrong.TabIndex = 6;
            this.isWrong.Text = "Не совпадает с реальной суммой в кассе";
            this.isWrong.UseVisualStyleBackColor = true;
            this.isWrong.CheckedChanged += new System.EventHandler(this.isWrong_CheckedChanged);
            // 
            // realSumLabel
            // 
            this.realSumLabel.AutoSize = true;
            this.realSumLabel.Enabled = false;
            this.realSumLabel.Location = new System.Drawing.Point(11, 188);
            this.realSumLabel.Name = "realSumLabel";
            this.realSumLabel.Size = new System.Drawing.Size(134, 13);
            this.realSumLabel.TabIndex = 8;
            this.realSumLabel.Text = "Реальная сумма в кассе";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(12, 250);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(271, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Открыть смену";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // realSum
            // 
            this.realSum.DecimalPlaces = 2;
            this.realSum.Enabled = false;
            this.realSum.Location = new System.Drawing.Point(14, 206);
            this.realSum.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.realSum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.realSum.Name = "realSum";
            this.realSum.Size = new System.Drawing.Size(120, 20);
            this.realSum.TabIndex = 10;
            this.realSum.ThousandsSeparator = true;
            this.realSum.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // OpenWorkShift
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 283);
            this.Controls.Add(this.realSum);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.realSumLabel);
            this.Controls.Add(this.isWrong);
            this.Controls.Add(this.money);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.shiftingDate);
            this.Controls.Add(this.dateLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenWorkShift";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Открыть смену";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenWorkShift_FormClosed);
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
        private System.Windows.Forms.CheckBox isWrong;
        private System.Windows.Forms.Label realSumLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown realSum;
    }
}