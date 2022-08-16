using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Againfocused
{
    public partial class ReturnMetod : Form
    {
        public ReturnMetod()
        {
            InitializeComponent();
        }

       public int Hesapla(int number1 , int number2)
        {
            int number = number1 * number2;
            return number;
        }
            

        public string GetName()
        {
            return  "Yavuz";
        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            string name = GetName();
            MessageBox.Show(name);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Hesapla(5,2).ToString());
        }
    }
}
