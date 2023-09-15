using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_petshop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Cad_Userbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro_Usuario cad_user = new Cadastro_Usuario();
            cad_user.Show();
        }

        private void Cad_Prodbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro_Produto cad_prod = new Cadastro_Produto();
            cad_prod.Show();
        }
    }
}
