using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace qasimpos.Classes
{
    class SQLConnectionClass
    {

        public static string conReturn()
        {
            return (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\pos.accdb;Persist Security Info=True");
        }
    }
}
