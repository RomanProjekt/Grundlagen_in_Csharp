using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_in_Csharp
{
    internal class DatenbankZugriff
    {

        private void Connect() 
        {
            string connectionString = @"Data Source=MyServerName;Initial Catalog=MyDbName; User ID=Admin; Password=Root";
            //SqlConnection connection = new SqlConnection(connectionString);
        }  
    }
}
