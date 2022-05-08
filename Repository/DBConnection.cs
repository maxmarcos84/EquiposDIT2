using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DBConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["default"].ConnectionString;
    }
}
