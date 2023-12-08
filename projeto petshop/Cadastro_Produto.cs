using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string ProductName = product_name.Text;
            string ProductValue = product_value.Text;
            string ProductType = product_type.Text;
            string Animal = animal.Text;

            if (!string.IsNullOrEmpty(ProductName) && !string.IsNullOrEmpty(ProductValue) && !string.IsNullOrEmpty(ProductType) && !string.IsNullOrEmpty(Animal))
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                connection.OpenConnection();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "insert into produtos (tipo, descricao, valor, tipo_animal) Values (@tipo, @descricao, @valor, @tipo_animal)";
                sqlCommand.Parameters.AddWithValue("@tipo", ProductType);
                sqlCommand.Parameters.AddWithValue("@descricao", ProductName);
                sqlCommand.Parameters.AddWithValue("@valor", ProductValue);
                sqlCommand.Parameters.AddWithValue("@valor", Animal);
                try
                {

                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("cadastrado com sucesso");
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro" + ex.Message);
                }
                finally
                {
                    connection.CloseConnection();
                    this.Close();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
            }
            else
            {
                MessageBox.Show("falha no cadastro, um ou mais campos não foram preenchidos");
            }

        }
    }
}
