namespace kursovayaKuznetsova
{
    partial class PickProfit
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
            this.pickStockLabel = new System.Windows.Forms.Label();
            this.pickStock = new System.Windows.Forms.ComboBox();
            this.moneyInCass = new System.Windows.Forms.Label();
            this.inCass = new System.Windows.Forms.NumericUpDown();
            this.pickCassLabel = new System.Windows.Forms.Label();
            this.pickCass = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.pickTerminal = new System.Windows.Forms.NumericUpDown();
            this.pickTerminalLabel = new System.Windows.Forms.Label();
            this.inTerminal = new System.Windows.Forms.NumericUpDown();
            this.inTerminalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inCass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inTerminal)).BeginInit();
            this.SuspendLayout();
            // 
            // pickStockLabel
            // 
            this.pickStockLabel.AutoSize = true;
            this.pickStockLabel.Location = new System.Drawing.Point(13, 13);
            this.pickStockLabel.Name = "pickStockLabel";
            this.pickStockLabel.Size = new System.Drawing.Size(84, 13);
            this.pickStockLabel.TabIndex = 0;
            this.pickStockLabel.Text = "Выбрать склад";
            // 
            // pickStock
            // 
            this.pickStock.FormattingEnabled = true;
            this.pickStock.Location = new System.Drawing.Point(13, 30);
            this.pickStock.Name = "pickStock";
            this.pickStock.Size = new System.Drawing.Size(171, 21);
            this.pickStock.TabIndex = 1;
            // 
            // moneyInCass
            // 
            this.moneyInCass.AutoSize = true;
            this.moneyInCass.Enabled = false;
            this.moneyInCass.Location = new System.Drawing.Point(13, 58);
            this.moneyInCass.Name = "moneyInCass";
            this.moneyInCass.Size = new System.Drawing.Size(81, 13);
            this.moneyInCass.TabIndex = 2;
            this.moneyInCass.Text = "Денег в кассе";
            // 
            // inCass
            // 
            this.inCass.DecimalPlaces = 2;
            this.inCass.Enabled = false;
            this.inCass.Location = new System.Drawing.Point(13, 75);
            this.inCass.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.inCass.Name = "inCass";
            this.inCass.Size = new System.Drawing.Size(171, 20);
            this.inCass.TabIndex = 3;
            // 
            // pickCassLabel
            // 
            this.pickCassLabel.AutoSize = true;
            this.pickCassLabel.Location = new System.Drawing.Point(16, 102);
            this.pickCassLabel.Name = "pickCassLabel";
            this.pickCassLabel.Size = new System.Drawing.Size(49, 13);
            this.pickCassLabel.TabIndex = 4;
            this.pickCassLabel.Text = "Забрать";
            // 
            // pickCass
            // 
            this.pickCass.DecimalPlaces = 2;
            this.pickCass.Enabled = false;
            this.pickCass.Location = new System.Drawing.Point(13, 118);
            this.pickCass.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.pickCass.Name = "pickCass";
            this.pickCass.Size = new System.Drawing.Size(171, 20);
            this.pickCass.TabIndex = 5;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 163);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(376, 27);
            this.start.TabIndex = 6;
            this.start.Text = "Применить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // pickTerminal
            // 
            this.pickTerminal.DecimalPlaces = 2;
            this.pickTerminal.Enabled = false;
            this.pickTerminal.Location = new System.Drawing.Point(201, 118);
            this.pickTerminal.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.pickTerminal.Name = "pickTerminal";
            this.pickTerminal.Size = new System.Drawing.Size(171, 20);
            this.pickTerminal.TabIndex = 10;
            // 
            // pickTerminalLabel
            // 
            this.pickTerminalLabel.AutoSize = true;
            this.pickTerminalLabel.Location = new System.Drawing.Point(204, 102);
            this.pickTerminalLabel.Name = "pickTerminalLabel";
            this.pickTerminalLabel.Size = new System.Drawing.Size(49, 13);
            this.pickTerminalLabel.TabIndex = 9;
            this.pickTerminalLabel.Text = "Забрать";
            // 
            // inTerminal
            // 
            this.inTerminal.DecimalPlaces = 2;
            this.inTerminal.Enabled = false;
            this.inTerminal.Location = new System.Drawing.Point(201, 75);
            this.inTerminal.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.inTerminal.Name = "inTerminal";
            this.inTerminal.Size = new System.Drawing.Size(171, 20);
            this.inTerminal.TabIndex = 8;
            // 
            // inTerminalLabel
            // 
            this.inTerminalLabel.AutoSize = true;
            this.inTerminalLabel.Enabled = false;
            this.inTerminalLabel.Location = new System.Drawing.Point(201, 58);
            this.inTerminalLabel.Name = "inTerminalLabel";
            this.inTerminalLabel.Size = new System.Drawing.Size(81, 13);
            this.inTerminalLabel.TabIndex = 7;
            this.inTerminalLabel.Text = "Денег в кассе";
            // 
            // PickProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 199);
            this.Controls.Add(this.pickTerminal);
            this.Controls.Add(this.pickTerminalLabel);
            this.Controls.Add(this.inTerminal);
            this.Controls.Add(this.inTerminalLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pickCass);
            this.Controls.Add(this.pickCassLabel);
            this.Controls.Add(this.inCass);
            this.Controls.Add(this.moneyInCass);
            this.Controls.Add(this.pickStock);
            this.Controls.Add(this.pickStockLabel);
            this.Name = "PickProfit";
            this.ShowIcon = false;
            this.Text = "Забрать доход";
            ((System.ComponentModel.ISupportInitialize)(this.inCass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inTerminal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickStockLabel;
        private System.Windows.Forms.ComboBox pickStock;
        private System.Windows.Forms.Label moneyInCass;
        private System.Windows.Forms.NumericUpDown inCass;
        private System.Windows.Forms.Label pickCassLabel;
        private System.Windows.Forms.NumericUpDown pickCass;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown pickTerminal;
        private System.Windows.Forms.Label pickTerminalLabel;
        private System.Windows.Forms.NumericUpDown inTerminal;
        private System.Windows.Forms.Label inTerminalLabel;
    }
}