namespace kursovayaKuznetsova
{
    partial class DayRequest
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
            this.sellSumLabel = new System.Windows.Forms.Label();
            this.inCassLabel = new System.Windows.Forms.Label();
            this.terminalLabel = new System.Windows.Forms.Label();
            this.dayCassLabel = new System.Windows.Forms.Label();
            this.dayTerminalLabel = new System.Windows.Forms.Label();
            this.sellSum = new System.Windows.Forms.NumericUpDown();
            this.inCass = new System.Windows.Forms.NumericUpDown();
            this.inTerminal = new System.Windows.Forms.NumericUpDown();
            this.dayCass = new System.Windows.Forms.NumericUpDown();
            this.dayTerminal = new System.Windows.Forms.NumericUpDown();
            this.sells = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sellSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inCass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sells)).BeginInit();
            this.SuspendLayout();
            // 
            // sellSumLabel
            // 
            this.sellSumLabel.AutoSize = true;
            this.sellSumLabel.Location = new System.Drawing.Point(13, 13);
            this.sellSumLabel.Name = "sellSumLabel";
            this.sellSumLabel.Size = new System.Drawing.Size(124, 13);
            this.sellSumLabel.TabIndex = 0;
            this.sellSumLabel.Text = "Сумма продаж за день";
            // 
            // inCassLabel
            // 
            this.inCassLabel.AutoSize = true;
            this.inCassLabel.Location = new System.Drawing.Point(13, 38);
            this.inCassLabel.Name = "inCassLabel";
            this.inCassLabel.Size = new System.Drawing.Size(47, 13);
            this.inCassLabel.TabIndex = 1;
            this.inCassLabel.Text = "В кассе";
            // 
            // terminalLabel
            // 
            this.terminalLabel.AutoSize = true;
            this.terminalLabel.Location = new System.Drawing.Point(13, 62);
            this.terminalLabel.Name = "terminalLabel";
            this.terminalLabel.Size = new System.Drawing.Size(72, 13);
            this.terminalLabel.TabIndex = 2;
            this.terminalLabel.Text = "В терминале";
            // 
            // dayCassLabel
            // 
            this.dayCassLabel.AutoSize = true;
            this.dayCassLabel.Location = new System.Drawing.Point(290, 38);
            this.dayCassLabel.Name = "dayCassLabel";
            this.dayCassLabel.Size = new System.Drawing.Size(89, 13);
            this.dayCassLabel.TabIndex = 3;
            this.dayCassLabel.Text = "В кассе за день";
            // 
            // dayTerminalLabel
            // 
            this.dayTerminalLabel.AutoSize = true;
            this.dayTerminalLabel.Location = new System.Drawing.Point(290, 62);
            this.dayTerminalLabel.Name = "dayTerminalLabel";
            this.dayTerminalLabel.Size = new System.Drawing.Size(114, 13);
            this.dayTerminalLabel.TabIndex = 4;
            this.dayTerminalLabel.Text = "В терминале за день";
            // 
            // sellSum
            // 
            this.sellSum.Location = new System.Drawing.Point(143, 11);
            this.sellSum.Name = "sellSum";
            this.sellSum.ReadOnly = true;
            this.sellSum.Size = new System.Drawing.Size(75, 20);
            this.sellSum.TabIndex = 5;
            // 
            // inCass
            // 
            this.inCass.Location = new System.Drawing.Point(143, 36);
            this.inCass.Name = "inCass";
            this.inCass.ReadOnly = true;
            this.inCass.Size = new System.Drawing.Size(75, 20);
            this.inCass.TabIndex = 6;
            // 
            // inTerminal
            // 
            this.inTerminal.Location = new System.Drawing.Point(143, 60);
            this.inTerminal.Name = "inTerminal";
            this.inTerminal.ReadOnly = true;
            this.inTerminal.Size = new System.Drawing.Size(75, 20);
            this.inTerminal.TabIndex = 7;
            // 
            // dayCass
            // 
            this.dayCass.Location = new System.Drawing.Point(430, 36);
            this.dayCass.Name = "dayCass";
            this.dayCass.ReadOnly = true;
            this.dayCass.Size = new System.Drawing.Size(75, 20);
            this.dayCass.TabIndex = 8;
            // 
            // dayTerminal
            // 
            this.dayTerminal.Location = new System.Drawing.Point(430, 60);
            this.dayTerminal.Name = "dayTerminal";
            this.dayTerminal.ReadOnly = true;
            this.dayTerminal.Size = new System.Drawing.Size(75, 20);
            this.dayTerminal.TabIndex = 9;
            // 
            // sells
            // 
            this.sells.AllowUserToAddRows = false;
            this.sells.AllowUserToDeleteRows = false;
            this.sells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sells.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sells.Location = new System.Drawing.Point(16, 101);
            this.sells.Name = "sells";
            this.sells.ReadOnly = true;
            this.sells.Size = new System.Drawing.Size(489, 150);
            this.sells.TabIndex = 10;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(16, 258);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(494, 34);
            this.close.TabIndex = 11;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            // 
            // DayRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 304);
            this.Controls.Add(this.close);
            this.Controls.Add(this.sells);
            this.Controls.Add(this.dayTerminal);
            this.Controls.Add(this.dayCass);
            this.Controls.Add(this.inTerminal);
            this.Controls.Add(this.inCass);
            this.Controls.Add(this.sellSum);
            this.Controls.Add(this.dayTerminalLabel);
            this.Controls.Add(this.dayCassLabel);
            this.Controls.Add(this.terminalLabel);
            this.Controls.Add(this.inCassLabel);
            this.Controls.Add(this.sellSumLabel);
            this.Name = "DayRequest";
            this.ShowIcon = false;
            this.Text = "Отчет за день";
            ((System.ComponentModel.ISupportInitialize)(this.sellSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inCass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sellSumLabel;
        private System.Windows.Forms.Label inCassLabel;
        private System.Windows.Forms.Label terminalLabel;
        private System.Windows.Forms.Label dayCassLabel;
        private System.Windows.Forms.Label dayTerminalLabel;
        private System.Windows.Forms.NumericUpDown sellSum;
        private System.Windows.Forms.NumericUpDown inCass;
        private System.Windows.Forms.NumericUpDown inTerminal;
        private System.Windows.Forms.NumericUpDown dayCass;
        private System.Windows.Forms.NumericUpDown dayTerminal;
        private System.Windows.Forms.DataGridView sells;
        private System.Windows.Forms.Button close;
    }
}