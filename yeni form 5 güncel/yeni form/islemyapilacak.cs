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
    public partial class islemyapilacak : Form
    {
        public islemyapilacak()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form4 form4 = new Form4();
                form4.ShowDialog();
                this.Hide();
            }
            else if (radioButton2.Checked) {
                MessageBox.Show("NAKİT ÖDEME ALINDI ");
            }
              
             
            
            
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
