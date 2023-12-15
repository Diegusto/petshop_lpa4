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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void user_cadbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastro_Usuario cad_user = new Cadastro_Usuario();
            cad_user.Show();
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            listar_usuarios.View = View.Details;
            listar_usuarios.GridLines = true;
            listar_usuarios.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listar_usuarios.Columns.Add("Nome", 300, HorizontalAlignment.Left);
            listar_usuarios.Columns.Add("Email", 300, HorizontalAlignment.Left);
            listar_usuarios.FullRowSelect = true;


            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "select id, nome, email from clientes";
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var item = listar_usuarios.Items.Add(reader[0].ToString());
                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(reader[2].ToString());
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
            if (listar_usuarios.Items.Count > 0)
            {
                if (exclude.Checked == true) {
                    ListViewItem item = listar_usuarios.SelectedItems[0];
                    string idtxt = item.SubItems[0].Text;
                    int id = Convert.ToInt32(idtxt);
                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();

                    connection.OpenConnection();
                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = "delete from clientes where id =@id";
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    try
                    {

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("usuario removido");
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
