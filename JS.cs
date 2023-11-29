using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARATONES_PROGRAMACION
{
    public partial class JS : Form
    {
        public JS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n1, n2, n3, n4;

            n1 = textBox1.Text; n2 = textBox2.Text; n3 = textBox3.Text; n4 = textBox4.Text;

            if ((n1 == "numero1 <= numero2")&&(n2 == "numero2 >= 0")&& (n3 == "numero1 < 0 || numero1 != 0") && (n4== "++numero1 < numero2"))
            {
                correcto principal = new correcto();
                principal.Show();
            }
            else
            {
                GRACIAS principal = new GRACIAS();
                principal.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (1 == 1)
            {
                menu principal = new menu();
                principal.Show();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (1 == 1)
            {
                PSayu principal = new PSayu();
                principal.Show();
            }
        }
    }
}
