using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yeni_form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        string KartNoTemizle(string text)
        {
            text = text.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "").Replace("_", "");
            return text;
        }
        bool KartNoUzunlukKontrol(string kartno)
        {
            if (kartno.Length == 16)
                return true;
            else
                return false;
        }
        bool SayisalDegerKontrol(string deger)
        {
            foreach (char chr in deger)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        int SayiBasamaklariTopla(int sayi)
        {
            int toplam = 0;
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }
            return toplam;
        }
        bool Kredi_Kart_Lunh_Algoritmasi(string kartno)
        {
            kartno = KartNoTemizle(kartno); // kart numarasını temizledik.

            if (KartNoUzunlukKontrol(kartno) == false) // uzunluğu kontrol ettik
                return false;
            else if (SayisalDegerKontrol(kartno) == false) // sayısal değerleri kontrol ettik
                return false;
            else
            {
                int ciftlerin_toplami = 0;
                int teklerin_toplami = 0;
                for (int i = 0; i < kartno.Length; i++)
                {
                    int eleman = Convert.ToInt32(kartno[i].ToString());
                    if (i % 2 == 0)
                        ciftlerin_toplami += SayiBasamaklariTopla(eleman * 2);
                    else
                        teklerin_toplami += eleman;
                }
                int sonuc = (teklerin_toplami + ciftlerin_toplami) % 10;
                if (sonuc == 0)
                    return true;
                else
                    return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Kredi_Kart_Lunh_Algoritmasi(textBox1.Text) == true)
                MessageBox.Show ("Kart No Geçerli ; ödeme alındı ") ;
            else
                MessageBox.Show("Kart No Geçersiz") ;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
