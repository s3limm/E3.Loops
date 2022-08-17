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
    public partial class ForExample : Form
    {
        public ForExample()
        {
            InitializeComponent();
        }

        private void ForExample_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                lstEn.Items.Add(i);
            }
        }


        private void btnAktar_Click(object sender, EventArgs e)
        {

            for (int nax = lstEn.Items.Count -1; nax >= 0; nax--)
            {

                int number = Convert.ToInt32(lstEn.Items[nax]);
                if (number % 5 == 0)
                {
                    lstYs.Items.Add(number);
                }

            }

        }
    }
}
