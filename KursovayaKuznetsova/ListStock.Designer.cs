namespace kursovayaKuznetsova
{
    partial class ListStock
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
            this.choiseNum = new System.Windows.Forms.NumericUpDown();
            this.moneyOnCassLabel = new System.Windows.Forms.Label();
            this.moreOrLess = new System.Windows.Forms.ComboBox();
            this.inCass = new System.Windows.Forms.CheckBox();
            this.onlyActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNum)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 216);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(466, 41);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // choiseNum
            // 
            this.choiseNum.Location = new System.Drawing.Point(279, 33);
            this.choiseNum.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.choiseNum.Name = "choiseNum";
            this.choiseNum.Size = new System.Drawing.Size(68, 20);
            this.choiseNum.TabIndex = 15;
            // 
            // moneyOnCassLabel
            // 
            this.moneyOnCassLabel.AutoSize = true;
            this.moneyOnCassLabel.Location = new System.Drawing.Point(247, 37);
            this.moneyOnCassLabel.Name = "moneyOnCassLabel";
            this.moneyOnCassLabel.Size = new System.Drawing.Size(26, 13);
            this.moneyOnCassLabel.TabIndex = 14;
            this.moneyOnCassLabel.Text = "чем";
            // 
            // moreOrLess
            // 
            this.moreOrLess.FormattingEnabled = true;
            this.moreOrLess.Location = new System.Drawing.Point(195, 33);
            this.moreOrLess.Name = "moreOrLess";
            this.moreOrLess.Size = new System.Drawing.Size(46, 21);
            this.moreOrLess.TabIndex = 13;
            // 
            // inCass
            // 
            this.inCass.AutoSize = true;
            this.inCass.Location = new System.Drawing.Point(12, 35);
            this.inCass.Name = "inCass";
            this.inCass.Size = new System.Drawing.Size(177, 17);
            this.inCass.TabIndex = 12;
            this.inCass.Text = "Количество товара на складе";
            this.inCass.UseVisualStyleBackColor = true;
            // 
            // onlyActive
            // 
            this.onlyActive.AutoSize = true;
            this.onlyActive.Location = new System.Drawing.Point(13, 12);
            this.onlyActive.Name = "onlyActive";
            this.onlyActive.Size = new System.Drawing.Size(135, 17);
            this.onlyActive.TabIndex = 9;
            this.onlyActive.Text = "Только действующие";
            this.onlyActive.UseVisualStyleBackColor = true;
            // 
            // ListStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 269);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.choiseNum);
            this.Controls.Add(this.moneyOnCassLabel);
            this.Controls.Add(this.moreOrLess);
            this.Controls.Add(this.inCass);
            this.Controls.Add(this.onlyActive);
            this.Name = "ListStock";
            this.ShowIcon = false;
            this.Text = "Список, поиск и редактирование складов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown choiseNum;
        private System.Windows.Forms.Label moneyOnCassLabel;
        private System.Windows.Forms.ComboBox moreOrLess;
        private System.Windows.Forms.CheckBox inCass;
        private System.Windows.Forms.CheckBox onlyActive;
    }
}