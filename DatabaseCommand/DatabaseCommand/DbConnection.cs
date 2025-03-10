using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommand
{
    public abstract class DbConnection
    {
        // Property to hold the database connection string
        public string ConnectionString { get; }
        // Property to hold the timeout duration for the connection 
        public TimeSpan Timeout { get; set; }

        // Constructor to initialize the connection string (must not be empty or null)
        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.");

            ConnectionString = connectionString;
        }

        // Abstract method to be implemented by subclasses for opening a connection
        public abstract void Open();

        // Abstract method to be implemented by subclasses for closing a connection
        public abstract void Close();                                  
    }
}
