using DatabaseCommand;
using System.Data.Common;
using DbCommand = DatabaseCommand.DbCommand;
using DbConnection = DatabaseCommand.DbConnection;

public class Program
{
    static void Main()
    {
        // Create an SQL connection object
        DbConnection sqlConn = new SqlConnection("SQL_Connection_String");
        // Create a database command with the connection and SQL query
        DbCommand sqlCommand = new DbCommand(sqlConn, "SELECT * FROM Users");
        // Execute the command
        sqlCommand.Execute();
    }
}

