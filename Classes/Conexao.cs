using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_tarefas.Classes
{
    public class Conexao
    {
        SqlConnection conn = new SqlConnection();

        public Conexao()
        {
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DesafioUNO;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        public void desconection()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            
        }

    }
}
