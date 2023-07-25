using ADO_Assessment;
using System.Data.SqlClient;
using System.Text;


class program 
{
    public static void Main(string[] args)
    {
        StringBuilder cnnstr = new StringBuilder("Data source=");
        Console.WriteLine("Enter Data Source");
        cnnstr.Append(Console.ReadLine());
        cnnstr.Append(";Initial catalog=");
        Console.WriteLine("Enter Database Name");
        cnnstr.Append(Console.ReadLine());
        cnnstr.Append(";Integrated Security=SSPI;");
        Console.WriteLine(cnnstr);

        bool n = true;

        while (n)
        {
            Console.WriteLine("To exit Enter 0");
            Console.WriteLine("Enter the query number to be executed:");
            int num = Convert.ToInt32( Console.ReadLine());
            

            if (num == 0)
            {
                break;
            }
            switch (num)
            {

                case 1:
                    {
                        Console.WriteLine("qstn1");
                        Qstn1 qstn1 = new Qstn1(cnnstr.ToString());
                        qstn1.ReadData();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("qstn2");
                        Qstn2 qstn2 = new Qstn2(cnnstr.ToString());
                        qstn2.ReadData();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("qstn3");
                        Qstn3 qstn3 = new Qstn3(cnnstr.ToString());
                        qstn3.ReadData();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("qstn4");
                        Qstn4 qstn4 = new Qstn4(cnnstr.ToString());
                        qstn4.ReadData();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("qstn5");
                        Qstn5 qstn5 = new Qstn5(cnnstr.ToString());
                        qstn5.ReadData();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Enter the correct key");
                        break;
                    }
            }
        }
    }
}