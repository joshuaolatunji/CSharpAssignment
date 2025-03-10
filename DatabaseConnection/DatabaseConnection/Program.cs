using DatabaseConnection;
using System.Data.Common;
using DbConnection = DatabaseConnection.DbConnection;

public class Program
{
    static void Main()
    {
        DbConnection sqlConn = new SqlConnection("SQL_Connection_String");
        sqlConn.Open();
        sqlConn.Close();

        DbConnection oracleConn = new OracleConnection("Oracle_Connection_String");
        oracleConn.Open();
        oracleConn.Close();
    }
}

