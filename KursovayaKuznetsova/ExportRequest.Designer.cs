namespace kursovayaKuznetsova
{
    partial class ExportRequest
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
            this.storesCollection = new System.Windows.Forms.CheckedListBox();
            this.choiseStoreLabel = new System.Windows.Forms.Label();
            this.choisePath = new System.Windows.Forms.Button();
            this.pathString = new System.Windows.Forms.ComboBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storesCollection
            // 
            this.storesCollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storesCollection.FormattingEnabled = true;
            this.storesCollection.Location = new System.Drawing.Point(16, 29);
            this.storesCollection.Name = "storesCollection";
            this.storesCollection.Size = new System.Drawing.Size(259, 94);
            this.storesCollection.TabIndex = 0;
            // 
            // choiseStoreLabel
            // 
            this.choiseStoreLabel.AutoSize = true;
            this.choiseStoreLabel.Location = new System.Drawing.Point(13, 13);
            this.choiseStoreLabel.Name = "choiseStoreLabel";
            this.choiseStoreLabel.Size = new System.Drawing.Size(133, 13);
            this.choiseStoreLabel.TabIndex = 1;
            this.choiseStoreLabel.Text = "Выбрать торговые точки";
            // 
            // choisePath
            // 
            this.choisePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choisePath.Location = new System.Drawing.Point(200, 129);
            this.choisePath.Name = "choisePath";
            this.choisePath.Size = new System.Drawing.Size(75, 23);
            this.choisePath.TabIndex = 2;
            this.choisePath.Text = "Выбрать";
            this.choisePath.UseVisualStyleBackColor = true;
            // 
            // pathString
            // 
            this.pathString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathString.FormattingEnabled = true;
            this.pathString.Location = new System.Drawing.Point(16, 130);
            this.pathString.Name = "pathString";
            this.pathString.Size = new System.Drawing.Size(178, 21);
            this.pathString.TabIndex = 3;
            // 
            // fileName
            // 
            this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileName.Location = new System.Drawing.Point(16, 158);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(259, 20);
            this.fileName.TabIndex = 4;
            this.fileName.Text = "Имя файла";
            // 
            // export
            // 
            this.export.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.export.Location = new System.Drawing.Point(16, 185);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(259, 43);
            this.export.TabIndex = 5;
            this.export.Text = "Экспортировать";
            this.export.UseVisualStyleBackColor = true;
            // 
            // ExportRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 239);
            this.Controls.Add(this.export);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.pathString);
            this.Controls.Add(this.choisePath);
            this.Controls.Add(this.choiseStoreLabel);
            this.Controls.Add(this.storesCollection);
            this.Name = "ExportRequest";
            this.ShowIcon = false;
            this.Text = "Экспорт заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox storesCollection;
        private System.Windows.Forms.Label choiseStoreLabel;
        private System.Windows.Forms.Button choisePath;
        private System.Windows.Forms.ComboBox pathString;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button export;
    }
}