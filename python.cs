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
    public partial class python : Form
    {
        public python()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texx;
            texx = textBox1.Text;

            if (1 == 1)
            {
                GRACIAS principal = new GRACIAS();
                principal.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (1 == 1)
            {
                menu principal = new menu();
                principal.Show();
                this.Hide();
            }
        }
    }
}
