using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace Repository.Repository
{
    public class Factory
    {
        private readonly string _connString;

        public Factory()
        {
            _connString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
            GetDBConnection = new SQLiteConnection(_connString);
        }

        public SQLiteConnection GetDBConnection { get; }
    }
}
