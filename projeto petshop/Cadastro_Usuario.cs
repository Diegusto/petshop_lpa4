using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projeto_petshop
{
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void cancel_cad_user_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void confirm_cad_user_Click(object sender, EventArgs e)
        {
            string username = userText.Text;
            string password = passwordText.Text;
            string confirm_password = confirmPasswordText.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirm_password))
            {
                if (password == confirm_password)
                {

                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();

                    connection.OpenConnection();

                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = "insert into clientes (email, nome, senha) Values (@email, @nome, @senha)" ;
                        sqlCommand.Parameters.AddWithValue("@email", "teste@teste");
                        sqlCommand.Parameters.AddWithValue("@nome", username);
                        sqlCommand.Parameters.AddWithValue("@senha", password);
                    try
                    {

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("cadastrado com sucesso");
                    }
                    catch (Exception ex) {
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
                    MessageBox.Show("falha no cadastro, a senha e a confirmação da senha não são iguais");
                }
            }
            else
            {
                MessageBox.Show("falha no cadastro, um ou mais campos não foram preeenchidos");
            }
         

        }
    }
}
