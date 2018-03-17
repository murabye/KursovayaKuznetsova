namespace kursovayaKuznetsova
{
    partial class ChangeParametres
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.NumericUpDown();
            this.startWageLabel = new System.Windows.Forms.Label();
            this.startWage = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startWage)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(13, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 20);
            this.name.TabIndex = 1;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 53);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(90, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Основной адрес";
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address.Location = new System.Drawing.Point(13, 70);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(259, 20);
            this.address.TabIndex = 3;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(13, 97);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(164, 13);
            this.percentLabel.TabIndex = 6;
            this.percentLabel.Text = "Процент с продаж на зарплату";
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(13, 114);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(120, 20);
            this.percent.TabIndex = 7;
            // 
            // startWageLabel
            // 
            this.startWageLabel.AutoSize = true;
            this.startWageLabel.Location = new System.Drawing.Point(16, 141);
            this.startWageLabel.Name = "startWageLabel";
            this.startWageLabel.Size = new System.Drawing.Size(139, 13);
            this.startWageLabel.TabIndex = 8;
            this.startWageLabel.Text = "Сумма за выход на смену";
            // 
            // startWage
            // 
            this.startWage.Location = new System.Drawing.Point(13, 158);
            this.startWage.Name = "startWage";
            this.startWage.Size = new System.Drawing.Size(120, 20);
            this.startWage.TabIndex = 9;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(13, 185);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(259, 46);
            this.start.TabIndex = 10;
            this.start.Text = "Применить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // ChangeParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.start);
            this.Controls.Add(this.startWage);
            this.Controls.Add(this.startWageLabel);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Name = "ChangeParametres";
            this.ShowIcon = false;
            this.Text = "Изменить параметры сети";
            ((System.ComponentModel.ISupportInitialize)(this.percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.NumericUpDown percent;
        private System.Windows.Forms.Label startWageLabel;
        private System.Windows.Forms.NumericUpDown startWage;
        private System.Windows.Forms.Button start;
    }
}