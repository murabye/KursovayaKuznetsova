namespace kursovayaKuznetsova
{
    partial class NewAdmin
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
            this.newAdmin = new System.Windows.Forms.RadioButton();
            this.oldAdmin = new System.Windows.Forms.RadioButton();
            this.phone = new System.Windows.Forms.TextBox();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oldEmail = new System.Windows.Forms.TextBox();
            this.oldEmailLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAdmin
            // 
            this.newAdmin.AutoSize = true;
            this.newAdmin.Checked = true;
            this.newAdmin.Location = new System.Drawing.Point(13, 13);
            this.newAdmin.Name = "newAdmin";
            this.newAdmin.Size = new System.Drawing.Size(105, 17);
            this.newAdmin.TabIndex = 0;
            this.newAdmin.TabStop = true;
            this.newAdmin.Text = "Создать нового";
            this.newAdmin.UseVisualStyleBackColor = true;
            // 
            // oldAdmin
            // 
            this.oldAdmin.AutoSize = true;
            this.oldAdmin.Location = new System.Drawing.Point(261, 12);
            this.oldAdmin.Name = "oldAdmin";
            this.oldAdmin.Size = new System.Drawing.Size(112, 17);
            this.oldAdmin.TabIndex = 1;
            this.oldAdmin.Text = "Выбрать старого";
            this.oldAdmin.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phone.Location = new System.Drawing.Point(13, 180);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(212, 20);
            this.phone.TabIndex = 15;
            // 
            // repeatPassword
            // 
            this.repeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatPassword.Location = new System.Drawing.Point(13, 133);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.PasswordChar = '*';
            this.repeatPassword.Size = new System.Drawing.Size(212, 20);
            this.repeatPassword.TabIndex = 14;
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Location = new System.Drawing.Point(13, 91);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(212, 20);
            this.password.TabIndex = 13;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(10, 163);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(93, 13);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Номер телефона";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(10, 116);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.repeatPasswordLabel.TabIndex = 11;
            this.repeatPasswordLabel.Text = "Повторите пароль";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Пароль";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Location = new System.Drawing.Point(13, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(212, 20);
            this.name.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "ФИО";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.Location = new System.Drawing.Point(13, 227);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 20);
            this.email.TabIndex = 17;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 210);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // oldEmail
            // 
            this.oldEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldEmail.Enabled = false;
            this.oldEmail.Location = new System.Drawing.Point(261, 91);
            this.oldEmail.Name = "oldEmail";
            this.oldEmail.Size = new System.Drawing.Size(202, 20);
            this.oldEmail.TabIndex = 20;
            // 
            // oldEmailLabel
            // 
            this.oldEmailLabel.AutoSize = true;
            this.oldEmailLabel.Location = new System.Drawing.Point(258, 74);
            this.oldEmailLabel.Name = "oldEmailLabel";
            this.oldEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.oldEmailLabel.TabIndex = 19;
            this.oldEmailLabel.Text = "Email";
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Location = new System.Drawing.Point(13, 254);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(450, 39);
            this.start.TabIndex = 21;
            this.start.Text = "Применить";
            this.start.UseVisualStyleBackColor = true;
            // 
            // CreateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 305);
            this.Controls.Add(this.start);
            this.Controls.Add(this.oldEmail);
            this.Controls.Add(this.oldEmailLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.oldAdmin);
            this.Controls.Add(this.newAdmin);
            this.Name = "CreateAdmin";
            this.ShowIcon = false;
            this.Text = "Назначить администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton newAdmin;
        private System.Windows.Forms.RadioButton oldAdmin;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox oldEmail;
        private System.Windows.Forms.Label oldEmailLabel;
        private System.Windows.Forms.Button start;
    }
}