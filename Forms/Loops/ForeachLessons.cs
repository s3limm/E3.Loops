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
    public partial class ForeachLessons : Form
    {
        public ForeachLessons()
        {
            InitializeComponent();
        }

        string[] books = { "Sefiller", "Beyaz Diş", "Çizgili Pijamalı Çocuk", "Nasrettin Hoca", "80 Günde Devr-i Alem", "Su ALtı Dünyası", "Keloğlan Masalları" };

        private void button1_Click(object sender, EventArgs e)
        {
            // foreach'ın mantıgı daha onceden belırlenmıs bır koleksıyonu foreachın ıcerısınde baska bır adla tanımlayıp cagırıyoruz ve yapmak ıstedıgımız ıslemı koleksıyon bıtene kadar yaptırtıyoruz.

            foreach (string book in books)
            {
                listBox1.Items.Add(book);
            }

        }

        private void ForeachLessons_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{books.Length} tane kitap bulunmaktadır.");


        }
    }
}
