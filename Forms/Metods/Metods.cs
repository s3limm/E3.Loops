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
    public partial class Metods : Form
    {
        public Metods()
        {
            InitializeComponent();
        }

        public void Selam()
        {
            MessageBox.Show("Selamlar.");
        }
        

    private void btnSelamla_Click(object sender, EventArgs e)
    {
            Selam();
    }
}
}
