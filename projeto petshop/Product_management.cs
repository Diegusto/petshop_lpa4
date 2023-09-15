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
    public partial class Product_management : Form
    {
        public Product_management()
        {
            InitializeComponent();
        }

        private void cad_prodbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro_Produto cad_prod = new Cadastro_Produto();
            cad_prod.Show();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
