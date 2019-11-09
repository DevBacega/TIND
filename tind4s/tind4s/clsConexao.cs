using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tind4s
{
    class ClsConexao
    {
        public SqlConnection conexao = new SqlConnection();

        public void conectar()
        {
            conexao.ConnectionString = "Server = DESKTOP-BAE84FH\\SQLEXPRESS; Database = tind4s; trusted_connection=true;";
            conexao.Open();
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
