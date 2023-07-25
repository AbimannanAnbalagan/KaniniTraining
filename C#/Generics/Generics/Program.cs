using GenericsAndDelegates;
using System;
/*
class program
{
    //static ArithmeticException arithmeticException;

    static void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }


    public static void Main(string[] args )
    {
        /*
        GenUsage<int> guint = new GenUsage<int>(10);
        GenUsage<double> gudble= new GenUsage<double>(10.54);
        GenUsage<string> gustr = new GenUsage<string>("Ten");

        Console.WriteLine(guint.Number);
        Console.WriteLine(gudble.Number);
        Console.WriteLine(gustr.Number);

        Console.WriteLine(guint);
        Console.WriteLine(gudble);
        Console.WriteLine(gustr);
        */
/*
GenUsageArr<int> usageArr = new GenUsageArr<int>(5);
for (int i=0; i<5; i++)
{
    usageArr.setarr(i, i+1);
}
for (int i = 0; i<5; i++)
{
    Console.WriteLine(usageArr.getarr(i));
}


GUConstraints<ArithmeticException> ae = new GUConstraints<ArithmeticException>(arithmeticException);
Console.WriteLine( ae.disp().Message);




int n1 = 10 , n2= 20;
char c1 = 'a' , c2 = 'b';

Swap<int>(ref n1, ref n2);
Swap<char>(ref c1, ref c2);

Console.WriteLine("a={0},b={1}", n1, n2);
Console.WriteLine("a={0},b={1}", c1, c2);

}
}
*/

public delegate void MyDelegate(string msg);
class program
{

    static void InvokeDeligate(MyDelegate del)
    {
        del("hello world");
    }

    public static void Main(string[] args)
    {

        //MyDelegate myDelegate = new MyDelegate(DelUsage1.Method);
        MyDelegate myDelegate , myDelegate1;
        myDelegate = DelUsage1.Method;
        //myDelegate.Invoke("Hello ");
        //myDelegate("Hello1");

        myDelegate1 = DelUsage2.Method;
        //myDelegate("Hello2");

        InvokeDeligate(myDelegate);

        InvokeDeligate(myDelegate1);
        Console.WriteLine("Multi Deligate");
        MyDelegate del = myDelegate + myDelegate1;
        del("Hello");
        MyDelegate del1 = myDelegate + myDelegate1 - myDelegate;
        del1("Hello del1");

    }
}    