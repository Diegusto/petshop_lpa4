namespace projeto_petshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;
            if (usuario == "admin" && senha == "admin")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("login incorreto");
            }
        }
    }
}