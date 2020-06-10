using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test();
            Console.WriteLine("Testing completed");
            Console.ReadKey();
        }

        private static void Test()
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\temp\test.xlsx';Extended Properties=\"Excel 12.0;HDR=YES;\"";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbDataAdapter oleDbDa = new OleDbDataAdapter("select *from [Sheet$1]", conn);
                    DataSet ds = new DataSet();
                    oleDbDa.Fill(ds);
                    var noOfTable = ds.Tables.Count;
                    var output = String.Format("No of Tables :{0}", noOfTable);
                    Console.WriteLine(output);
                    conn.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
