namespace kursovayaKuznetsova
{
    partial class MixPay
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
            this.toPayLabel = new System.Windows.Forms.Label();
            this.toPay = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.NumericUpDown();
            this.card = new System.Windows.Forms.NumericUpDown();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card)).BeginInit();
            this.SuspendLayout();
            // 
            // toPayLabel
            // 
            this.toPayLabel.AutoSize = true;
            this.toPayLabel.Location = new System.Drawing.Point(13, 13);
            this.toPayLabel.Name = "toPayLabel";
            this.toPayLabel.Size = new System.Drawing.Size(55, 13);
            this.toPayLabel.TabIndex = 0;
            this.toPayLabel.Text = "К оплате:";
            // 
            // toPay
            // 
            this.toPay.AutoSize = true;
            this.toPay.Location = new System.Drawing.Point(75, 13);
            this.toPay.Name = "toPay";
            this.toPay.Size = new System.Drawing.Size(28, 13);
            this.toPay.TabIndex = 1;
            this.toPay.Text = "0.00";
            // 
            // money
            // 
            this.money.Location = new System.Drawing.Point(16, 42);
            this.money.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(120, 20);
            this.money.TabIndex = 2;
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(142, 42);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(120, 20);
            this.card.TabIndex = 3;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(13, 26);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(66, 13);
            this.moneyLabel.TabIndex = 4;
            this.moneyLabel.Text = "Наличными";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(142, 26);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(53, 13);
            this.cardLabel.TabIndex = 5;
            this.cardLabel.Text = "По карте";
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(16, 69);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(246, 23);
            this.start.TabIndex = 6;
            this.start.Text = "Продать";
            this.start.UseVisualStyleBackColor = true;
            // 
            // MixPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 104);
            this.ControlBox = false;
            this.Controls.Add(this.start);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.card);
            this.Controls.Add(this.money);
            this.Controls.Add(this.toPay);
            this.Controls.Add(this.toPayLabel);
            this.Name = "MixPay";
            this.ShowIcon = false;
            this.Text = "Смешанная оплата";
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toPayLabel;
        private System.Windows.Forms.Label toPay;
        private System.Windows.Forms.NumericUpDown money;
        private System.Windows.Forms.NumericUpDown card;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Button start;
    }
}