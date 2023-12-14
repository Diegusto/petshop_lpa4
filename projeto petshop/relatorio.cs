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
    public partial class relatorio : Form
    {
        public relatorio()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                connection.OpenConnection();

                sqlCommand.Connection = connection.ReturnConnection();

                sqlCommand.CommandText = "select id from produtos where descricao like %@descricao%";
                sqlCommand.Parameters.AddWithValue("@descricao", search.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                var id = reader[0];

                sqlCommand.CommandText = "select * from vendas where id_produto = @id";
                sqlCommand.Parameters.AddWithValue("@id", id);
                try
                {
                    while (reader.Read())
                    {
                        var item = relatorio_vendas.Items.Add(reader[0].ToString());
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
            else
            {
                MessageBox.Show("escreva o nome do produto no campo acima");
            }
        }


        private void relatorio_Load(object sender, EventArgs e)
        {
            relatorio_vendas.View = View.Details;
            relatorio_vendas.GridLines = true;
            relatorio_vendas.Columns.Add("ID", 100, HorizontalAlignment.Left);
            relatorio_vendas.Columns.Add("ID_Usuario", 100, HorizontalAlignment.Left);
            relatorio_vendas.Columns.Add("ID_Produto", 100, HorizontalAlignment.Left);
            relatorio_vendas.Columns.Add("Valor_total", 300, HorizontalAlignment.Left);
            relatorio_vendas.FullRowSelect = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            sales_management sales = new sales_management();
            sales.Show();
        }
    }
}
