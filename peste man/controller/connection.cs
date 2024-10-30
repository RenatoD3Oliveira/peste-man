using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace peste_man.controller
{
    internal class connection
    {
        private SqlConnection con;
        private string DataBase = "TKLOJINHA";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public connection()
        {
            string strinConnection = @"Data Source = " + Server
                + "; initial Catalog = " + DataBase
                + "; User Id = " + Username
                + "; Password = " + Password
                + "; Encrypt = false";

            con = new SqlConnection(strinConnection);
            con.Open();
        }
        public void CloseConnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public SqlConnection ReturnConnect()
        {
            return con;
        }
    }
}

