using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommand
{
    public class DbCommand
    {

        private readonly DbConnection _connection;  // Holds the database connection
        private readonly string _instruction; // Holds the command to be executed

        // Constructor requires a valid DbConnection and an instruction (SQL query)
        public DbCommand(DbConnection connection, string instruction)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection), "DbConnection cannot be null.");
            _instruction = !string.IsNullOrWhiteSpace(instruction) ? instruction : throw new ArgumentException("Instruction cannot be null or empty.");
        }

        // Method to execute the command
        public void Execute()
        {
            _connection.Open(); // Open the database connection
            Console.WriteLine($"Executing command: {_instruction}"); // Print the command being executed
            _connection.Close(); // Close the connection
        }
    }
}
