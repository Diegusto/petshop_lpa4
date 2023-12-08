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
                    item.SubItems.Add(reader[3].ToString());
                }
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
    }
}
