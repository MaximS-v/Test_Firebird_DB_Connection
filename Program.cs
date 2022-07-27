using FirebirdSql.Data.FirebirdClient;
using Dapper;

namespace TestDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");

            FbConnectionStringBuilder csb = new FbConnectionStringBuilder();
            csb.DataSource = "127.0.0.1";
            csb.Port = 3050;
            csb.Database = @"E:\db\1.fdb";
            csb.UserID = "admin";
            csb.Password = "****";
            csb.ServerType = FbServerType.Default;

            FbConnection db = new FbConnection(csb.ToString());
            db.Open();

            //FbCommand cmd = new FbCommand("select FLD_MANUF from PRICES", db);
            String companyname = db.Query<String>("select FLD_MANUF from PRICES").First();
            Console.WriteLine(companyname);
        }
    }
}