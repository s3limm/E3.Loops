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
    public partial class doWhıle : Form
    {
        public doWhıle()
        {
            InitializeComponent();
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtbEN.Text);
            string resultEN = "";
            try
            {
                do
                {
                    resultEN += $"{number},";
                    number--;
                    
                } while (number >= 0 && number < 5);
                resultEN = resultEN.TrimEnd(',');
                lblEN.Text = resultEN;
              
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayı giriniz");

            }


        }
    }
}
