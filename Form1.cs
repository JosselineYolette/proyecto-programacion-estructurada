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
            String usuario, contrase�a;

            usuario = textBox1.Text;
            contrase�a = textBox2.Text;

            if ((usuario == "Josseline" || usuario == "Jailuz") && contrase�a == "1234")
            {
                menu principal = new menu();
                principal.Show();
            }
            this.Hide();

        }
    }
}