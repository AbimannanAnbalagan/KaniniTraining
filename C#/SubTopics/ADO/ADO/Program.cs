using DbConnect;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

class progarm : ConfigurationSection
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(ConfigurationManager.AppSettings["num1"]);
        //Console.WriteLine(ConfigurationManager.AppSettings["num2"]);



        /*
        StringBuilder cnnstr = new StringBuilder("Data source=");
        Console.WriteLine("Enter Data Source");
        cnnstr.Append(Console.ReadLine());
        cnnstr.Append(";Initial catalog=");
        Console.WriteLine("Enter Database Name");
        cnnstr.Append(Console.ReadLine());
        cnnstr.Append(";Integrated Security=SSPI;");
        Console.WriteLine(cnnstr);

        DBConnect dBConnect = new DBConnect();
        
        dBConnect.OpenConn(cnnstr.ToString());
        */
        //dBConnect.CreateTable();
        //dBConnect.InsertTable();
        //dBConnect.UpdateTable();
        //dBConnect.DeleteTable();
        //dBConnect.ReadTable();
        //dBConnect.CloseConn();

        DBDisconnected dBDisconnected = new DBDisconnected();
        dBDisconnected.OpenConn();
        //dBDisconnected.ReadData();
        //dBDisconnected.Insert();
        dBDisconnected.Update(23099);
    }
}