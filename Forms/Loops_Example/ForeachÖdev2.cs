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
    public partial class ForeachÖdev2 : Form
    {
        public ForeachÖdev2()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        string secretKey;

        private void ForeachÖdev2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kelime tahmin etme oyununa hoşgeldiniz ");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lstEN.Items.Clear();
            string[] guessValue = { "Eyfel Kulesi", "Galata Kulesi", "Arthemis Tapınağı", "Efes Antik Kenti", "Yerebatan Sarnıcı", "İshaPaşa Sarayı" };
            secretKey = guessValue[rastgele.Next(0, 6)];
            txtCheck.Enabled = true;
            btnCheck.Enabled = true;
            txtCheck.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string secretValue = txtCheck.Text;
            if (secretKey == secretValue)
            {
                MessageBox.Show("Kazandınız :D");
            }
            else
            {
                char[] letters = secretKey.ToCharArray();
                string matchedletters = "";

                foreach (char letter in letters)
                {
                    if (secretValue.Contains(letter))
                    {
                        matchedletters += $"{letter},";
                    }

                }

                if (matchedletters != "")
                {
                    matchedletters = matchedletters.TrimEnd(',');
                    lstEN.Items.Add(matchedletters);


                    
                }

            }
        }
    }
}
