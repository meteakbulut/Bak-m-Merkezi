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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {   
              // otomasyonu açabilecek tek kullanıcı adı ve şifre : kullanıcı adı personel ; şifre se admin şeklinde ayarlandı . 
            string sifre = "admin";
            string kullaniciadi = "personel";
        
          
            // tolower kullanarak girilen metnin btün karakterleri büyük veya küçük farketmeksizin küçük harfe dönüştürüld 
            if ((textBox1.Text.ToLower()==kullaniciadi  ) &&  (textBox2.Text.ToLower() == sifre ))
            {
                Form2 form2 = new Form2();
                form2.Show();  // form2 göster diyoruz
                this.Hide();

            }


            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ ");
                // sağlanmayan şartta hatalı giriş uyarısı verilir 
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2.PasswordChar = '*';
                // şifre için karakter belirlendi girilen şifre karakterleri * şeklinde görülecektir ;
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
