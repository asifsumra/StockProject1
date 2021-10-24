using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace pos.Classes 
{
	class SQLConnectionClass
	{

        public static string conReturn()
        {
            return (@"Data Source=(LocalDb)\LocalDBDemo;AttachDbFilename=" + System.IO.Path.GetFullPath("pos.mdf") + "; Integrated Security=True;Connect Timeout;");
        }
	}
}
