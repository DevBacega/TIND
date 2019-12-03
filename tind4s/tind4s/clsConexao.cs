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
            //conexao.ConnectionString = "Server = TID-VICTOR\\TIDSCI; Database = tind4s; trusted_connection=true;";
            conexao.ConnectionString = "Server=tcp:tind-ifsp.database.windows.net,1433;Initial Catalog=TIND;Persist Security Info=False;User ID=Zendriak;Password=Z2y5rw3g!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            conexao.Open();
        }

        public void desconectar()
        {
            conexao.Close();
        }
        
    }
}
