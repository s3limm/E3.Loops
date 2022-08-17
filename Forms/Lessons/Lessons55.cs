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
    public partial class Lessons55 : Form
    {
        public Lessons55()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string yavuz = "yavuz";
            object name = yavuz;

            int number1 = 43;
            object count = number1;

            yavuz = name as string; // strıng olarak atanmıs bı degerı object tıpıne atamak ıcın bu yontem kullanılabılır.
            yavuz = (string)name;  // strıng olarak atanmıs bı degerı object tıpıne atamak ıcın bu yontem kullanılabılır.

            number1 = (int)count;  // iny olarak atanmıs bır degerı object tıpıne atamak ıcın bu yontem kullanılabılır.




        }
    }
}
