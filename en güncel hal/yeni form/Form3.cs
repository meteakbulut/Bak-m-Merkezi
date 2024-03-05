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
    public partial class lazerepil : Form
    {
        public lazerepil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {  
               // geri dönmek için butona tıklanır ve bir önceki forma geçiş ypar 
            Form2 frm22 = new Form2();
            frm22.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // işlem yapılaak formuna yönlendirir 
            islemyapilacak islm11 = new islemyapilacak();
            islm11.Show();
            this.Hide();
        }
    }
}
