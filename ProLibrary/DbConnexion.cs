using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ProLibrary
{
    public class DbConnexion
    {
        private string _connectionString { get; set; }
        private SqlConnection _connection { get; set; }
        public DbConnexion()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Dylan"].ConnectionString;
        }

        public SqlConnection RenvoiObjetConnnexion()
        {
            this._connection = new SqlConnection(this._connectionString);

            return this._connection;
        }
    }
}
