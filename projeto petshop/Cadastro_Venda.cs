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

namespace projeto_petshop
{
    public partial class Cadastro_Venda : Form
    {
        public Cadastro_Venda()
        {
            InitializeComponent();
        }

        private void confirm_cad_sell_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(User_id.Text) && !string.IsNullOrEmpty(product_name.Text) && !string.IsNullOrEmpty(total_value.Text))
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                connection.OpenConnection();

                sqlCommand.Connection = connection.ReturnConnection();

                sqlCommand.CommandText = "select id from produtos where descricao like %@produto%";
                sqlCommand.Parameters.AddWithValue("@produto", product_name);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                var IdProduto = reader[0];

                sqlCommand.CommandText = "insert into vendas (id_cliente, id_produto, valor_total) Values (@id_cliente, @id_produto, @valor_total)";
                sqlCommand.Parameters.AddWithValue("@id_cliente", User_id.Text);
                sqlCommand.Parameters.AddWithValue("@id_produto", IdProduto);
                sqlCommand.Parameters.AddWithValue("@valor_total", total_value.Text);
             
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
                    sales_management sales = new sales_management();
                    sales.Show();
                }
            }
            else
            {
                MessageBox.Show("falha no cadastro, um ou mais campos não foram preenchidos");
            }
        }
    }
}
