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
    public partial class ForeachÖdevcs : Form
    {
        public ForeachÖdevcs()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        string secretKey;

        private void ForeachÖdevcs_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Hoşgeldiniz.Lütfen yeni üretilen değeri bulmaya çalışınız.");

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lstEN.Items.Clear();
            string[] animals = { "Aslan", "Ayı", "Su Aygırı", "Maymun", "Çita", "Kaplan", "Kurt" };
            secretKey = animals[rastgele.Next(0, 6)];
            txtGuess.Enabled = true;
            btnGuess.Enabled = true;
            txtGuess.Text = "";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;
            string matchedLetters = "";
            if (guess == secretKey)
            {
                MessageBox.Show("Kazandınız :D");
            }
            else
            {
                char[] letters = guess.ToCharArray();

                foreach (char letter in letters)
                {
                    if (secretKey.Contains(letter))
                    {
                        matchedLetters += $"{letter},";
                    }
                }
                if (matchedLetters != "")
                {

                    matchedLetters = matchedLetters.TrimEnd(',');
                    lstEN.Items.Add(matchedLetters);

                }

            }
        }


    }
}
