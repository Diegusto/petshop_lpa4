using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
