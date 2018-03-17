namespace kursovayaKuznetsova
{
    partial class DeleteSeller
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
            this.dismissRadio = new System.Windows.Forms.RadioButton();
            this.hireRadio = new System.Windows.Forms.RadioButton();
            this.dismiss = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dismissRadio
            // 
            this.dismissRadio.AutoSize = true;
            this.dismissRadio.Checked = true;
            this.dismissRadio.Location = new System.Drawing.Point(12, 12);
            this.dismissRadio.Name = "dismissRadio";
            this.dismissRadio.Size = new System.Drawing.Size(68, 17);
            this.dismissRadio.TabIndex = 0;
            this.dismissRadio.TabStop = true;
            this.dismissRadio.Text = "Уволить";
            this.dismissRadio.UseVisualStyleBackColor = true;
            // 
            // hireRadio
            // 
            this.hireRadio.AutoSize = true;
            this.hireRadio.Location = new System.Drawing.Point(13, 84);
            this.hireRadio.Name = "hireRadio";
            this.hireRadio.Size = new System.Drawing.Size(110, 17);
            this.hireRadio.TabIndex = 1;
            this.hireRadio.Text = "Нанять бывшего";
            this.hireRadio.UseVisualStyleBackColor = true;
            // 
            // dismiss
            // 
            this.dismiss.FormattingEnabled = true;
            this.dismiss.Location = new System.Drawing.Point(28, 36);
            this.dismiss.Name = "dismiss";
            this.dismiss.Size = new System.Drawing.Size(244, 21);
            this.dismiss.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 155);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(259, 32);
            this.start.TabIndex = 4;
            this.start.Text = "Применить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // DeleteSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.start);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dismiss);
            this.Controls.Add(this.hireRadio);
            this.Controls.Add(this.dismissRadio);
            this.Name = "DeleteSeller";
            this.ShowIcon = false;
            this.Text = "Удалить продавца";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dismissRadio;
        private System.Windows.Forms.RadioButton hireRadio;
        private System.Windows.Forms.ComboBox dismiss;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button start;
    }
}