using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaKuznetsova
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var sault = SellerModel.Crypto("Puppy");
            // var result = SellerModel.Login(login, sault + password);
            var result = login.Text;

            switch (result)
            {
                case "продавец":
                    this.Hide();
                    var openShift = new OpenWorkShift();
                    openShift.Show();
                    break;
                case "админ":
                    this.Hide();
                    var admin = new AdminWorkSpace();
                    admin.Show();
                    break;
                case "забыл закрыть смену":
                    this.Hide();
                    var seller = new SellerWorkSpace();
                    seller.Show();
                    break;
                default:
                    MessageBox.Show("фИО или пароль введены неверно", "Ошибка");
                    break;
            }
        }
    }
}
