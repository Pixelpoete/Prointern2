using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace proLibrary
{
    public class DbConnexion
    {
        private string _ConnectionString { get; set; }
        private SqlConnection connection { get; set; }
        public DbConnexion()
        {
            this._ConnectionString = ConfigurationManager.ConnectionStrings["Dylan"].ConnectionString;


        }

        public SqlConnection RenvoiObjetConnexion()
        {
            this.connection = new SqlConnection(this._ConnectionString);
            return connection;
        }
    }
}
