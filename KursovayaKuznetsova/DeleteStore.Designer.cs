namespace kursovayaKuznetsova
{
    partial class DeleteStore
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
            this.pickStoreLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.onlyStock = new System.Windows.Forms.RadioButton();
            this.moveItems = new System.Windows.Forms.RadioButton();
            this.deleteItems = new System.Windows.Forms.RadioButton();
            this.noItems = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pickStoreLabel
            // 
            this.pickStoreLabel.AutoSize = true;
            this.pickStoreLabel.Location = new System.Drawing.Point(13, 13);
            this.pickStoreLabel.Name = "pickStoreLabel";
            this.pickStoreLabel.Size = new System.Drawing.Size(81, 13);
            this.pickStoreLabel.TabIndex = 0;
            this.pickStoreLabel.Text = "Выбрать точку";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // onlyStock
            // 
            this.onlyStock.AutoSize = true;
            this.onlyStock.Location = new System.Drawing.Point(16, 58);
            this.onlyStock.Name = "onlyStock";
            this.onlyStock.Size = new System.Drawing.Size(127, 17);
            this.onlyStock.TabIndex = 2;
            this.onlyStock.TabStop = true;
            this.onlyStock.Text = "Оставить как склад";
            this.onlyStock.UseVisualStyleBackColor = true;
            // 
            // moveItems
            // 
            this.moveItems.AutoSize = true;
            this.moveItems.Location = new System.Drawing.Point(16, 82);
            this.moveItems.Name = "moveItems";
            this.moveItems.Size = new System.Drawing.Size(112, 17);
            this.moveItems.TabIndex = 3;
            this.moveItems.TabStop = true;
            this.moveItems.Text = "Перенести товар";
            this.moveItems.UseVisualStyleBackColor = true;
            // 
            // deleteItems
            // 
            this.deleteItems.AutoSize = true;
            this.deleteItems.Location = new System.Drawing.Point(16, 106);
            this.deleteItems.Name = "deleteItems";
            this.deleteItems.Size = new System.Drawing.Size(99, 17);
            this.deleteItems.TabIndex = 4;
            this.deleteItems.TabStop = true;
            this.deleteItems.Text = "Списать товар";
            this.deleteItems.UseVisualStyleBackColor = true;
            // 
            // noItems
            // 
            this.noItems.AutoSize = true;
            this.noItems.Location = new System.Drawing.Point(16, 130);
            this.noItems.Name = "noItems";
            this.noItems.Size = new System.Drawing.Size(141, 17);
            this.noItems.TabIndex = 5;
            this.noItems.TabStop = true;
            this.noItems.Text = "Товар уже отсутствует";
            this.noItems.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(16, 154);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(256, 33);
            this.start.TabIndex = 6;
            this.start.Text = "Удалить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // DeleteStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.start);
            this.Controls.Add(this.noItems);
            this.Controls.Add(this.deleteItems);
            this.Controls.Add(this.moveItems);
            this.Controls.Add(this.onlyStock);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pickStoreLabel);
            this.Name = "DeleteStore";
            this.ShowIcon = false;
            this.Text = "Удалить торговую точку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickStoreLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton onlyStock;
        private System.Windows.Forms.RadioButton moveItems;
        private System.Windows.Forms.RadioButton deleteItems;
        private System.Windows.Forms.RadioButton noItems;
        private System.Windows.Forms.Button start;
    }
}