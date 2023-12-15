using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace projeto_petshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username;
        string password;


        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string senha = textBox2.Text;

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            try
            {
                sqlCommand.CommandText = "select nome, senha from clientes where nome = @nome and senha = @senha";
                sqlCommand.Parameters.AddWithValue("@nome", usuario);
                sqlCommand.Parameters.AddWithValue("@senha", senha);

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    username = reader[0].ToString();
                    password = reader[1].ToString();
                   

                }
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("login incorreto");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erro" + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}