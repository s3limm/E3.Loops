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
    public partial class MetodsExample : Form
    {
        public MetodsExample()
        {
            InitializeComponent();
        }



        private void MetodsExample_Load(object sender, EventArgs e)
        {
          
            MessageBox.Show("Merhabalar sayımız sıfırdan baslıyor ıstersenız (+) butonuna basıp arttırabılırsınız. İstersenizde (-) butonuna basıp eksıltebılırsınız.");
        }

        int number;

        public void Convert()
        {
            lblEN.Text = number.ToString();

        }


        private void btnENArttır_Click(object sender, EventArgs e)
        {

            number++;
            Convert();
        }

        private void btnEnEksilt_Click(object sender, EventArgs e)
        {
            number--;
            Convert();
        }
    }
}
