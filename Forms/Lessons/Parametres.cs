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
    public partial class Parametres : Form
    {
        public Parametres()
        {
            InitializeComponent();
        }


        public void Attack(string attackStyle, int health, int damage)
        {
            MessageBox.Show($"{attackStyle} ile {health} canla {damage} hasar verdiniz. ");
        }

        private void btnWizzard_Click(object sender, EventArgs e)
        {
            txtWizzard1.Text = "";
            txtWizzard2.Text = "";

            label1.Enabled = true;
            label2.Enabled = true;
            txtWizzard1.Enabled = true;
            txtWizzard2.Enabled = true;
            btnWizzardFinal.Enabled = true;
        }

        private void btnWarriors_Click(object sender, EventArgs e)
        {
            txtWarriors1.Text = "";
            txtWarriors2.Text = "";


            label3.Enabled = true;
            label4.Enabled = true;
            txtWarriors1.Enabled = true;
            txtWarriors2.Enabled = true;
            btnWarriorsFinal.Enabled = true;
        }

        private void btnArchar_Click(object sender, EventArgs e)
        {
            txtArchars1.Text = "";
            txtArchars2.Text = "";

            label5.Enabled = true;
            label6.Enabled = true;
            txtArchars1.Enabled = true;
            txtArchars2.Enabled = true;
            btnArcharFinal.Enabled = true;
        }

        private void Parametres_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhabalar belirlediğiniz karakter ile düşmana ne kadar hasar vermek istediğinizi seçiniz.");
        }

        private void btnWizzardFinal_Click(object sender, EventArgs e)
        {
            int damage = Convert.ToInt32(txtWizzard1.Text);
            int health = Convert.ToInt32(txtWizzard2.Text);

            Attack("Büyücü", health, damage);
        }

        private void btnWarriorsFinal_Click(object sender, EventArgs e)
        {
            int damage = Convert.ToInt32(txtWarriors1.Text);
            int health = Convert.ToInt32(txtWarriors2.Text);

            Attack("Savaşçı", health, damage);
        }

        private void btnArcharFinal_Click(object sender, EventArgs e)
        {
            int damage = Convert.ToInt32(txtArchars1.Text);
            int health = Convert.ToInt32(txtArchars2.Text);

            Attack("Okçu", health, damage);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            #region Wizzard

            txtWizzard1.Text = "";
            txtWizzard2.Text = "";

            label1.Enabled = false;
            label2.Enabled = false;
            txtWizzard1.Enabled = false;
            txtWizzard2.Enabled = false;
            btnWizzardFinal.Enabled = false;

            #endregion

            #region Warriors 

            txtWarriors1.Text = "";
            txtWarriors2.Text = "";


            label3.Enabled = false;
            label4.Enabled = false;
            txtWarriors1.Enabled = false;
            txtWarriors2.Enabled = false;
            btnWarriorsFinal.Enabled = false;

            #endregion

            #region Archar 
            txtArchars1.Text = "";
            txtArchars2.Text = "";

            label5.Enabled = false;
            label6.Enabled = false;
            txtArchars1.Enabled = false;
            txtArchars2.Enabled = false;
            btnArcharFinal.Enabled = false;

            #endregion

        }

        public void Attack()
        {
            Random rastgele = new Random();
            Random random = new Random();

            string[] attackStyle = { "balta", "büyü", "ok", "mızrak", "bıçak", "kılıç" };

            int attack = random.Next(0, 6);
            string damage = Convert.ToString(rastgele.Next(0, 500));

            MessageBox.Show($"Npc düşmana {attackStyle[attack]} ile {damage} hasar verdi.");
        }

        private void btnNpc_Click(object sender, EventArgs e)
        {
            Attack();
        }
    }
}
