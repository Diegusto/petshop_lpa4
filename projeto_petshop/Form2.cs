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

        private void Cad_Prodbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro_Produto cad_prod = new Cadastro_Produto();
            cad_prod.Show();
        }

        private void Cad_Userbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro_Usuario cad_user = new Cadastro_Usuario();
            cad_user.Show();
        }
    }
}
