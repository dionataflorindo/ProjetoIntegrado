using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrado
{
    internal class ConectaDB
    {
        private readonly string ConexaoDB;

        public ConectaDB()
        {
            ConexaoDB = "Data Source=DESKTOP-R45EGP4;Initial Catalog=SeuBancoDeDados;Integrated Security=True";
        }

        public SqlConnection ConectarBanco()
        {
            return new SqlConnection(ConexaoDB);
        }
    }
}
