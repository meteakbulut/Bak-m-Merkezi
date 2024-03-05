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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // pictureboxta belirtilen resimin tıklandığında ilgili işlem ile ilgili sayfaya yönlendrilmek için formlar arası geçiş yapıyoruz 
            lazerepil lzrpl = new lazerepil();
            lzrpl.Show();  // lazerepil göster diyoruz
            this.Hide();
            // öneki form saklandı 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // pictureboxta belirtilen resimin tıklandığında ilgili işlem ile ilgili sayfaya yönlendrilmek için formlar arası geçiş yapıyoruz
            kastasarim kastasaarim = new kastasarim();
            kastasaarim.Show();  // kastasarim göster diyoruz
            this.Hide();
            // öneki form saklandı 
        }
    }
}
