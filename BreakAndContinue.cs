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
    public partial class BreakAndContinue : Form
    {
        public BreakAndContinue()
        {
            InitializeComponent();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <10; i++)
            {
                listBox1.Items.Add(i);
                if(i == 5)
                {
                    break;
                }
               
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
                if (i == 5)
                {
                    continue;
                }

            }
        }
    }
}
