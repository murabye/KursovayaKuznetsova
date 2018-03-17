namespace kursovayaKuznetsova
{
    partial class DeleteDiscount
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
            this.todayLabel = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Location = new System.Drawing.Point(13, 13);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(49, 13);
            this.todayLabel.TabIndex = 0;
            this.todayLabel.Text = "Сегодня";
            // 
            // today
            // 
            this.today.Location = new System.Drawing.Point(68, 10);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(100, 20);
            this.today.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 36);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(259, 37);
            this.start.TabIndex = 2;
            this.start.Text = "Удалить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // DeleteDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(this.start);
            this.Controls.Add(this.today);
            this.Controls.Add(this.todayLabel);
            this.Name = "DeleteDiscount";
            this.ShowIcon = false;
            this.Text = "Удалить скидку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.TextBox today;
        private System.Windows.Forms.Button start;
    }
}