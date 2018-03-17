namespace kursovayaKuznetsova
{
    partial class NewRequest
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
            this.addItemExcel = new System.Windows.Forms.Button();
            this.addItemGenerate = new System.Windows.Forms.Button();
            this.addItemNumber = new System.Windows.Forms.NumericUpDown();
            this.addItemButton = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.ComboBox();
            this.addItemLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.addItemNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 294);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(531, 32);
            this.start.TabIndex = 18;
            this.start.Text = "Закончить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // addItemExcel
            // 
            this.addItemExcel.AutoSize = true;
            this.addItemExcel.Location = new System.Drawing.Point(12, 258);
            this.addItemExcel.Name = "addItemExcel";
            this.addItemExcel.Size = new System.Drawing.Size(270, 23);
            this.addItemExcel.TabIndex = 17;
            this.addItemExcel.Text = "Добавить из файла Excel";
            this.addItemExcel.UseVisualStyleBackColor = true;
            // 
            // addItemGenerate
            // 
            this.addItemGenerate.AutoSize = true;
            this.addItemGenerate.Location = new System.Drawing.Point(288, 229);
            this.addItemGenerate.Name = "addItemGenerate";
            this.addItemGenerate.Size = new System.Drawing.Size(258, 23);
            this.addItemGenerate.TabIndex = 16;
            this.addItemGenerate.Text = "Добавить по автоматической заявке";
            this.addItemGenerate.UseVisualStyleBackColor = true;
            // 
            // addItemNumber
            // 
            this.addItemNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemNumber.Location = new System.Drawing.Point(425, 202);
            this.addItemNumber.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.addItemNumber.Name = "addItemNumber";
            this.addItemNumber.Size = new System.Drawing.Size(121, 20);
            this.addItemNumber.TabIndex = 15;
            this.addItemNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addItemButton
            // 
            this.addItemButton.AutoSize = true;
            this.addItemButton.Location = new System.Drawing.Point(12, 229);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(270, 23);
            this.addItemButton.TabIndex = 14;
            this.addItemButton.Text = "Добавить выбранный товар";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // addItem
            // 
            this.addItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItem.FormattingEnabled = true;
            this.addItem.Location = new System.Drawing.Point(12, 202);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(408, 21);
            this.addItem.TabIndex = 13;
            // 
            // addItemLabel
            // 
            this.addItemLabel.AutoSize = true;
            this.addItemLabel.Location = new System.Drawing.Point(16, 185);
            this.addItemLabel.Name = "addItemLabel";
            this.addItemLabel.Size = new System.Drawing.Size(89, 13);
            this.addItemLabel.TabIndex = 12;
            this.addItemLabel.Text = "Добавить товар";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(13, 12);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(46, 13);
            this.dataLabel.TabIndex = 11;
            this.dataLabel.Text = "Товары";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // NewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 339);
            this.Controls.Add(this.start);
            this.Controls.Add(this.addItemExcel);
            this.Controls.Add(this.addItemGenerate);
            this.Controls.Add(this.addItemNumber);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.addItemLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewRequest";
            this.ShowIcon = false;
            this.Text = "Создать заявку";
            ((System.ComponentModel.ISupportInitialize)(this.addItemNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button addItemExcel;
        private System.Windows.Forms.Button addItemGenerate;
        private System.Windows.Forms.NumericUpDown addItemNumber;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ComboBox addItem;
        private System.Windows.Forms.Label addItemLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}