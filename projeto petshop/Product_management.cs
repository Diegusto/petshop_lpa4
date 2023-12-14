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

        private void Product_management_Load(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "select descricao from produtos";
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var item = List_Products.Items.Add(reader[0].ToString());
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

        private void excluir_Click(object sender, EventArgs e)
        {
            if (List_Products.Items.Count > 0)
            {
                if (exclude.Checked == true)
                {
                    string nome_produto = List_Products.SelectedItem.ToString();

                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();

                    connection.OpenConnection();
                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = "delete from produtos where descricao like %@descricao%";
                    sqlCommand.Parameters.AddWithValue("@descricao", nome_produto);
                    try
                    {

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("produto removido");
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
                    MessageBox.Show("confirme antes de excluir");
                }
            }
        }
    }
}

