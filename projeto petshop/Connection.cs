﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_petshop
{
    internal class Connection
    {
        //Propriedades ou atributos
        private readonly SqlConnection con;
        private readonly string Database = "petshop";

        //Construtor
        public Connection()
        {
            //@"Data Source=LAB02-PC12\SQLEXPRESS;Initial Catalog=SIST_CHAMOU;Integrated Security=True"
            string stringConnection = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=" + Database + ";Integrated Security = true";

            con = new SqlConnection(stringConnection);

        }
        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
