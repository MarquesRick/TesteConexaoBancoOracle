using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect
            //string constr = "User Id=grails;Password=ora16ALLIS#grails;Data Source=10.200.203.13:1521/fpwprd";
            string constr = "User Id=grails;Password=grailsnew;Data Source=10.200.203.13:1521/fpwhom";
            OracleConnection con = new OracleConnection(constr);
            con.Open();

            // Execute a SQL SELECT
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select email from usuario";
            OracleDataReader reader = cmd.ExecuteReader();

            // Print all employee numbers
            while (reader.Read())
                Console.WriteLine(reader.GetString(0));

            // Clean up
            reader.Dispose();
            cmd.Dispose();
            con.Dispose();
        }
    }
}
