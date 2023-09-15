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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LogOutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }


        private void UserManagementbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement user_man = new UserManagement();
            user_man.Show();
        }

        private void adm_prodbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product_management prod_man = new Product_management();
            prod_man.Show();
        }
    }
}
