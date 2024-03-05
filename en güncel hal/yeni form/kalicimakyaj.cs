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
    public partial class kalicimakyaj : Form
    {
        public kalicimakyaj()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm22 = new Form2();
            frm22.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //  ilgili sayfaya yönlendrilmek için formlar arası geçiş yapıyoruz
            islemyapilacak islm11 = new islemyapilacak();
            islm11.Show();
            this.Hide();
        }
    }
}
