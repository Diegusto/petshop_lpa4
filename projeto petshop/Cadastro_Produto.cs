using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            Product_management product = new Product_management();
            product.Show();
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

                sqlCommand.CommandText = "select id from tipo_animal where descricao =@animal";
                sqlCommand.Parameters.AddWithValue("@animal", Animal);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                string IdAnimal;
                Int32 id_animal;

                string IdProduto;
                Int32 id_produto;

                if (reader.Read())
                {
                    IdAnimal = reader[0].ToString();
                    id_animal = Convert.ToInt32(IdAnimal);

                    sqlCommand.CommandText = "select id from tipo_produto where descricao =@produto";
                    sqlCommand.Parameters.AddWithValue("@produto", ProductType);

                    IdProduto = reader[0].ToString();
                    id_produto = Convert.ToInt32(IdProduto);

                    connection.CloseConnection();

                    connection.OpenConnection();
                    sqlCommand.Connection = connection.ReturnConnection();

                    sqlCommand.CommandText = "insert into produtos (tipo, descricao, valor, tipo_animal) Values (@tipo, @descricao, @valor, @tipo_animal)";
                    sqlCommand.Parameters.AddWithValue("@tipo", id_produto);
                    sqlCommand.Parameters.AddWithValue("@descricao", ProductName);
                    sqlCommand.Parameters.AddWithValue("@valor", ProductValue);
                    sqlCommand.Parameters.AddWithValue("@tipo_animal", id_animal);

                }

                
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
                    Product_management product = new Product_management();
                    product.Show();
                }
            }
            else
            {
                MessageBox.Show("falha no cadastro, um ou mais campos não foram preenchidos");
            }

        }

        private void Cadastro_Produto_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "select t.descricao, p.descricao from tipo_animal t, tipo_produto p where t.id = p.id";
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var AnimalItem = animal.Items.Add(reader[0].ToString());
                    var ProductItem = product_type.Items.Add(reader[1].ToString());
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Erro" + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

    }
}

