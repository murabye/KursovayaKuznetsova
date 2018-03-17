namespace kursovayaKuznetsova
{
    partial class ListSeller
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
            this.start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // withDiscount
            // 
            this.withDiscount.AutoSize = true;
            this.withDiscount.Location = new System.Drawing.Point(13, 14);
            this.withDiscount.Name = "withDiscount";
            this.withDiscount.Size = new System.Drawing.Size(152, 17);
            this.withDiscount.TabIndex = 45;
            this.withDiscount.Text = "Только администраторы";
            this.withDiscount.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(12, 193);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // ListSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 243);
            this.Controls.Add(this.withDiscount);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListSeller";
            this.ShowIcon = false;
            this.Text = "Список, поиск и редактирование сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox withDiscount;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}