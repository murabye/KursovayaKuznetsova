namespace kursovayaKuznetsova
{
    partial class ChangeStore
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
            this.pickStore = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pickStoreLabel
            // 
            this.pickStoreLabel.AutoSize = true;
            this.pickStoreLabel.Location = new System.Drawing.Point(13, 13);
            this.pickStoreLabel.Name = "pickStoreLabel";
            this.pickStoreLabel.Size = new System.Drawing.Size(87, 13);
            this.pickStoreLabel.TabIndex = 0;
            this.pickStoreLabel.Text = "Выберите точку";
            // 
            // pickStore
            // 
            this.pickStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickStore.FormattingEnabled = true;
            this.pickStore.Location = new System.Drawing.Point(16, 30);
            this.pickStore.Name = "pickStore";
            this.pickStore.Size = new System.Drawing.Size(231, 21);
            this.pickStore.TabIndex = 1;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(16, 174);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(231, 35);
            this.start.TabIndex = 9;
            this.start.Text = "Создать";
            this.start.UseVisualStyleBackColor = true;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 114);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(38, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Адрес";
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address.Location = new System.Drawing.Point(16, 130);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(231, 20);
            this.address.TabIndex = 7;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(16, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 20);
            this.name.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Название";
            // 
            // ChangeStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 221);
            this.Controls.Add(this.start);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pickStore);
            this.Controls.Add(this.pickStoreLabel);
            this.Name = "ChangeStore";
            this.ShowIcon = false;
            this.Text = "Изменить магазин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pickStoreLabel;
        private System.Windows.Forms.ComboBox pickStore;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
    }
}