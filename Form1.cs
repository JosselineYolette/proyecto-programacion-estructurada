namespace MARATONES_PROGRAMACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, contraseña;

            usuario = textBox1.Text;
            contraseña = textBox2.Text;

            if ((usuario == "Josseline" || usuario == "Jailuz") && contraseña == "1234")
            {
                menu principal = new menu();
                principal.Show();
            }
            this.Hide();

        }
    }
}