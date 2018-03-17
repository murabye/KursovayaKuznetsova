using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO: показывать пользователю сообщение о зарплате с вычетом разницы
// TODO: плюс оставлять в кассе
namespace kursovayaKuznetsova
{
    public partial class CloseWorkingShift : Form
    {
        public CloseWorkingShift()
        {
            InitializeComponent();
            shiftingDate.Value = DateTime.Now;
        }
    }
}
