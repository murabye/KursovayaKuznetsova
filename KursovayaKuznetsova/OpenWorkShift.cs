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
    public partial class OpenWorkShift : Form
    {
        public OpenWorkShift()
        {
            InitializeComponent();
            shiftingDate.Value = DateTime.Now;
        }

        private void isWrong_CheckedChanged(object sender, EventArgs e)
        {
            realSumLabel.Enabled = isWrong.Checked;
            realSum.Enabled = isWrong.Checked;
            startButton.Enabled = realSum.Value > -1 || !isWrong.Checked;
        }

        private void OpenWorkShift_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
