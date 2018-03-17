namespace kursovayaKuznetsova
{
    partial class ListStore
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
            this.onlyActive = new System.Windows.Forms.CheckBox();
            this.onlyMore = new System.Windows.Forms.CheckBox();
            this.onlyLess = new System.Windows.Forms.CheckBox();
            this.inCass = new System.Windows.Forms.CheckBox();
            this.moreOrLess = new System.Windows.Forms.ComboBox();
            this.moneyOnCassLabel = new System.Windows.Forms.Label();
            this.choiseNum = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.choiseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // onlyActive
            // 
            this.onlyActive.AutoSize = true;
            this.onlyActive.Location = new System.Drawing.Point(13, 13);
            this.onlyActive.Name = "onlyActive";
            this.onlyActive.Size = new System.Drawing.Size(135, 17);
            this.onlyActive.TabIndex = 0;
            this.onlyActive.Text = "Только действующие";
            this.onlyActive.UseVisualStyleBackColor = true;
            // 
            // onlyMore
            // 
            this.onlyMore.AutoSize = true;
            this.onlyMore.Location = new System.Drawing.Point(13, 36);
            this.onlyMore.Name = "onlyMore";
            this.onlyMore.Size = new System.Drawing.Size(187, 17);
            this.onlyMore.TabIndex = 1;
            this.onlyMore.Text = "Только магазины с излишками";
            this.onlyMore.UseVisualStyleBackColor = true;
            // 
            // onlyLess
            // 
            this.onlyLess.AutoSize = true;
            this.onlyLess.Location = new System.Drawing.Point(13, 60);
            this.onlyLess.Name = "onlyLess";
            this.onlyLess.Size = new System.Drawing.Size(134, 17);
            this.onlyLess.TabIndex = 2;
            this.onlyLess.Text = "Только с недосдачей";
            this.onlyLess.UseVisualStyleBackColor = true;
            // 
            // inCass
            // 
            this.inCass.AutoSize = true;
            this.inCass.Location = new System.Drawing.Point(13, 84);
            this.inCass.Name = "inCass";
            this.inCass.Size = new System.Drawing.Size(163, 17);
            this.inCass.TabIndex = 3;
            this.inCass.Text = "Количество денег на точке";
            this.inCass.UseVisualStyleBackColor = true;
            // 
            // moreOrLess
            // 
            this.moreOrLess.FormattingEnabled = true;
            this.moreOrLess.Location = new System.Drawing.Point(182, 80);
            this.moreOrLess.Name = "moreOrLess";
            this.moreOrLess.Size = new System.Drawing.Size(46, 21);
            this.moreOrLess.TabIndex = 4;
            // 
            // moneyOnCassLabel
            // 
            this.moneyOnCassLabel.AutoSize = true;
            this.moneyOnCassLabel.Location = new System.Drawing.Point(234, 84);
            this.moneyOnCassLabel.Name = "moneyOnCassLabel";
            this.moneyOnCassLabel.Size = new System.Drawing.Size(26, 13);
            this.moneyOnCassLabel.TabIndex = 5;
            this.moneyOnCassLabel.Text = "чем";
            // 
            // choiseNum
            // 
            this.choiseNum.Location = new System.Drawing.Point(267, 84);
            this.choiseNum.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.choiseNum.Name = "choiseNum";
            this.choiseNum.Size = new System.Drawing.Size(68, 20);
            this.choiseNum.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(13, 280);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(466, 41);
            this.start.TabIndex = 8;
            this.start.Text = "Принять";
            this.start.UseVisualStyleBackColor = true;
            // 
            // ListStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 333);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.choiseNum);
            this.Controls.Add(this.moneyOnCassLabel);
            this.Controls.Add(this.moreOrLess);
            this.Controls.Add(this.inCass);
            this.Controls.Add(this.onlyLess);
            this.Controls.Add(this.onlyMore);
            this.Controls.Add(this.onlyActive);
            this.Name = "ListStore";
            this.ShowIcon = false;
            this.Text = "Список, поиск и изменение товара";
            ((System.ComponentModel.ISupportInitialize)(this.choiseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox onlyActive;
        private System.Windows.Forms.CheckBox onlyMore;
        private System.Windows.Forms.CheckBox onlyLess;
        private System.Windows.Forms.CheckBox inCass;
        private System.Windows.Forms.ComboBox moreOrLess;
        private System.Windows.Forms.Label moneyOnCassLabel;
        private System.Windows.Forms.NumericUpDown choiseNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button start;
    }
}