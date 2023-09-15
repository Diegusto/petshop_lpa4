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
    public partial class Cadastro_Produto : Form
    {
        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void cancel_cad_prod_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void confirm_cad_prod_Click(object sender, EventArgs e)
        {
            string productName = product_name.Text;
            string productValue = product_value.Text;
            string productType = product_type.Text;
            string Animal = animal.Text;

            if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(productValue) && !string.IsNullOrEmpty(productType) && !string.IsNullOrEmpty(Animal))
            {
                this.Close();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("falha no cadastro, um ou mais campos não foram preenchidos");
            }

        }
    }
}
