// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//case sensitive - csharp  
/*
 Author : Abimannan
 Date :22/03/2023
 Description :program 1
 */
/*
Console.Write("Hello World" + "write keeps the string in same line");
Console.WriteLine("Hello World");

int num1, num2, ans;

num1 = 10; num2 = 20;

ans = num1 + num2;
Console.WriteLine("Result :" + ans);

int input1; //read the input
Console.WriteLine("Enter the input1");
input1 = Convert.ToInt32(Console.ReadLine()); //converting datatype
Console.WriteLine("input1:" + input1);


int number = 5;
float flnum = number;
Console.WriteLine(flnum);

char chr = Convert.ToChar(number);
Console.WriteLine(chr);

double sr = Math.Sqrt(9);
Console.WriteLine(sr);

Console.WriteLine(Math.Equals(sr, 3)); //Equals - checking the objects are same or not
Console.WriteLine(Math.Equals(sr, sr));

int sr =3;

Console.WriteLine(sr.Equals(3)); //Equals - checking the objects are same or not
Console.WriteLine(Math.Equals(sr, sr));

//Console.WriteLine(string);

string s1 = "string" , s2 = "string" , s3="THE BOYS";
int int5 = 44;
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s3.Length);
Console.WriteLine(s1.Substring(3)); //index starts in 0
Console.WriteLine(s1.Substring(2,3)); //2 - starting index & 3 length of substring
Console.WriteLine(s3.IndexOf('S')); //case sensitive
Console.WriteLine(s3.IndexOf('s'));
Console.WriteLine(s3.IndexOf(' '));
Console.WriteLine($"{ s1} inbetween  { s3 }"); //string interpolation
Console.WriteLine($"{1} inbetween {3} {s3}");
Console.WriteLine($"{s1} text inbetween two strings {int5}");



//day2(23/03/2023)
int num1 = Convert.ToInt32( Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine()) , num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) 
{
    Console.WriteLine($"{num1} is bigger");
}
else if (num2 > num1 && num2 > num3) 
{
    Console.WriteLine($"{num2} is bigger");
}
else
{
    Console.WriteLine($"{num3} is bigger");
}

int day = 7;
switch (day - 4)
{
case 1:
    Console.WriteLine("Monday");
    break;
case 2:
    Console.WriteLine("Tuesday");
    break;
case 3:
    Console.WriteLine("Wednesday");
    break;
case 4:
    Console.WriteLine("Thursday");
    break;
case 5:
    Console.WriteLine("Friday");
    break;
case 6:
    Console.WriteLine("Saturday");
    break;
case 7:
    Console.WriteLine("Sunday");
    break;
default:
    Console.WriteLine("Looking forward to the Weekend.");
    break;
}
int days = 7;
switch (days - 4)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("Monday or Tuesday or Thursday");
        break;
}



class Demo1
{
    public static void Main(string[] args)
    {
        int variable1 = Convert.ToInt32(Console.ReadLine()), variable2 = Convert.ToInt32(Console.ReadLine());
        string compare;
        compare = variable1 == variable2 ? "Both the numbers are equal" : "These are different numbers";
        Console.WriteLine(compare);
    }
}


int iterator = 0;
while (iterator < 5) {
    Console.Write(iterator + " " );
    ++iterator;
}
Console.WriteLine();    

int iterator2 = 0;
do
{
    Console.Write(iterator2+" ");
    ++iterator2;
}
while (iterator2 < 5);
*/

using Basic_Programs;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml.Linq;

class Program
{
    public static void Main(string[] args)
    {

        //Console.WriteLine("Hello World!");
        //demo2 Demo = new demo2();
        //string s1 = Console.ReadLine();
        //Console.WriteLine( Demo.foreachloop(s1));
        //Demo.arrayDisp();

        /*
        Console.WriteLine("Enter Customer id," + "accno, name,balance");
        int custid = Convert.ToInt32(Console.ReadLine());
        long accountNumber = Convert.ToInt64(Console.ReadLine());
        string accountHolderName = Console.ReadLine();
        decimal balance = Convert.ToDecimal(Console.ReadLine());
        BankTransactions bankTransactions = new BankTransactions(custid , accountNumber , accountHolderName, balance);
        bankTransactions.WriteCustomerDetails();
       
        BankTransactions bktr = new BankTransactions(1234,78874,"Abimannan Anbalagan" , 40000);
        decimal balance = bktr.performTransactions();
        //Console.WriteLine($"Name: {accountHolderName} \n Balance: {balance} \n Status: {status}");
        int d = bktr.Custid;
        Console.WriteLine(balance);
        string accountHolderName = bktr.accHname();
        Console.WriteLine($"Name: {accountHolderName} \nBalance: {balance}\nStatus: {bktr.Status} ");
         */

        /*
        Console.WriteLine("Enter roll no,name and 3 marks");
        int rno = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        double mark1 = Convert.ToDouble(Console.ReadLine());
        double mark2 = Convert.ToDouble(Console.ReadLine());
        double mark3 = Convert.ToDouble(Console.ReadLine());

        StudentCalculation studentCalculation = new StudentCalculation(rno, name, mark1, mark2, mark3, 0.0, 0.0);
        studentCalculation.Calculate();
        Console.WriteLine("name:" + studentCalculation.Name + " total:" +
            studentCalculation.Tot + " avg:" + studentCalculation.Avg);
        */
        /*

        Console.WriteLine("Enter collegename , address , pin");
        string collegename = Console.ReadLine();
        string address = Console.ReadLine();
        int pin = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("if admin enter 2 else enter 1 ");
        int i = Convert.ToInt32( Console.ReadLine());
        if (i == 1)
        {
            Console.WriteLine("Enter eid,name, dept, fvtsubject,salary");
            int eid = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string dept = Console.ReadLine();
            string fvtsubject = Console.ReadLine();
            double salaryE = Convert.ToDouble(Console.ReadLine());
            

            TeachingStaff teachingstaff = new TeachingStaff(collegename, address, pin, eid, name, dept, fvtsubject, salaryE);
            double empsalary = teachingstaff.calculatesalary();
            Console.WriteLine("Employee salary" + empsalary );

        }
        else if (i==2)
        { 
        Console.WriteLine("Enter adminid,name,salary");
        int adminid = Convert.ToInt32( Console.ReadLine());
        string namea = Console.ReadLine();
        double salaryA = Convert.ToDouble(Console.ReadLine());

            AdminStaff adminstaff = new AdminStaff(collegename, address, pin, adminid, namea, salaryA);
            double adminsal = adminstaff.calculatesalary();
            Console.WriteLine("Admin salary" + adminsal);

        }
*/

        //Console.WriteLine("Enter the 2 numbers");
        //call by value
        /*
        Addition addition = new Addition(2,4);
        int num1 = 10, num2 = 10;
        Console.WriteLine( addition.add(num1,num2));
        Console.WriteLine(num1);
        */
        //call by reference
        /*
        Console.WriteLine(addition.add(ref num1, ref num2));
        Console.WriteLine(num1);
        */
        //
        //returning multiple value
        /*
        Addition addition = new Addition();
        int num1 = 10, num2 = 10;
        addition.add(out num1,out num2);
        Console.WriteLine(num1+" "+num2);
        */
        //abstraction
        /*
        Interest interest = new Interest(1,1224,"aaa",20000,0);
        double intamt = interest.CalculateInterest();
        Console.WriteLine(interest.Accno+"\n" + interest.Accname + "\n" + intamt);
        */
        //interface
        //need to fill about interface
        //
        //Animals dog = new Animals("dog", 2, 1, 4, 1);
        //Animals cow = new Animals("cow", 2, 1, 4, 1);
        //Animals cat = new Animals("cat", 2, 1, 4, 1);

        //cat.MakeSound(cat.Name);
        //cat.MakeSound(dog.Name);
        int n = 5;
        Console.WriteLine(-n);
    }
}
