using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommand
{
   public class SqlConnection : DbConnection
    {
        // Constructor to initialize an SQL connection with a connection string
        public SqlConnection(string connectionString) : base(connectionString) { }

        // Implementation of Open method
        public override void Open()
        {
            Console.WriteLine("SQL Connection opened.");
        }

        // Implementation of Close method
        public override void Close()
        {
            Console.WriteLine("SQL Connection closed.");
        }
    }
}
