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
    public partial class YazıTura : Form
    {
        public YazıTura()
        {
            InitializeComponent();
        }

        private void YazıTura_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Yazı tura oyununa hoşgeldiniz ");
        }

        Random rastgele = new Random();
        private void btnENGuess_Click(object sender, EventArgs e)
        {

            string[] question = { "Yes", "No" };
            string questions = "";
            DialogResult result;

            do
            {
                int number = rastgele.Next(0, 2);
                questions = question[number];
                result = MessageBox.Show("Yazı mı Tura mı\nYazı için Yes'i\n Tura için No'yu seçiniz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            } while (result.ToString() != questions);
            MessageBox.Show("Doğru cevap.");
        }
    }
}
