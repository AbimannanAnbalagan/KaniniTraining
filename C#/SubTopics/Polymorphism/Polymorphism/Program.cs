//method overloading

using Polymorphism;
class program { 
public static void Main(string[] args)
{
    BankAccount bankAccount = new BankAccount(1234,927487429,"Abimannan",536666,"Active");
        Console.WriteLine("1.custId 2.AccNo");
        int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {
            case 1:
                bankAccount.checkaccstatus(927487429);
                break;
            case 2:
                bankAccount.checkaccstatus(1234);
                break;
            default:
                Console.WriteLine("Enter 1 or 2");
                break;
        }
    }
}


