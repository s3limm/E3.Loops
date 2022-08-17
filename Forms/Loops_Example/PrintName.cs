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
    public partial class PrintName : Form
    {
        string[] en = { "Yavuz", "Selim", "Emrem" };

        public PrintName()
        {
            InitializeComponent();
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < en.Length; i++)
            {
                lstEN.Items.Add(en[i]);
            }
        }
    }
}
