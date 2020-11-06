using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DbWorker.Tools
{
    public class DbConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server=127.0.0.1;database=myonlinebank;user=root;password=dashasofia2;port=5000;charset=utf8;";

            return new MySqlConnection(connectionString);
        }

    }
}

