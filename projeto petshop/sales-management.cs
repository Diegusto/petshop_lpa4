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
    public partial class sales_management : Form
    {
        public sales_management()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void add_sale_Click(object sender, EventArgs e)
        {
            this.Close();
            Cadastro_Venda venda = new Cadastro_Venda();
            venda.Show();
        }

        private void sales_management_Load(object sender, EventArgs e)
        {
            listar_vendas.View = View.Details;
            listar_vendas.GridLines = true;
            listar_vendas.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listar_vendas.Columns.Add("ID_Usuario", 100, HorizontalAlignment.Left);
            listar_vendas.Columns.Add("ID_Produto", 100, HorizontalAlignment.Left);
            listar_vendas.Columns.Add("Valor_total", 300, HorizontalAlignment.Left);
            listar_vendas.FullRowSelect = true;


            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "select * from vendas";
            try
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var item = listar_vendas.Items.Add(reader[0].ToString());
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
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            if (listar_vendas.Items.Count > 0)
            {
                if (exclude.Checked == true)
                { 
                    ListViewItem item = listar_vendas.SelectedItems[0];
                    string idtxt = item.SubItems[0].Text;
                    int id = Convert.ToInt32(idtxt);
                    Connection connection = new Connection();
                    SqlCommand sqlCommand = new SqlCommand();

                    connection.OpenConnection();
                    sqlCommand.Connection = connection.ReturnConnection();
                    sqlCommand.CommandText = "delete from vendas where id =@id";
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    try
                    {

                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("venda removida");
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
                }else
                {
                    MessageBox.Show("confirme antes de excluir");
                }
            }
        }

        private void relatory_Click(object sender, EventArgs e)
        {
            this.Close();
            relatorio rel = new relatorio();
            rel.Show();
        }
    }
}
