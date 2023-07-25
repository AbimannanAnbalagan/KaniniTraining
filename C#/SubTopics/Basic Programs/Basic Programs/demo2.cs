/*
 Author : Abimannan
 Date :23/03/2023
 Description :program 2
 */

class demo2
{
    public void ComparisionOfTwoNumbers()
    {
        Console.WriteLine("Enter the 1st number then press enter after that enter the 2nd number");
        int variable1 = Convert.ToInt32(Console.ReadLine()), variable2 = Convert.ToInt32(Console.ReadLine());
        string compare;
        compare = variable1 == variable2 ? "Both the numbers are equal" : "These are different numbers";
        Console.WriteLine(compare);
    }

    public void forLoop()
    {
        int sum = 0;
        for (int i = 0; sum < 5; i++)
        {
            sum += i;
        }
        Console.WriteLine($"sum of numbers = {sum}");

    }
    public void simplePattern()
    {
        for (int i = 1; i < 6; i++)
        {
            for (int j = 0; j != i; j++)
            { 
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public void simplePattern2() 
    {
        for (int i = 0; i < 5; i++) 
        {
            for (int j = 5; j != i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //for each loop
    public string foreachloop(string s1)
    {
       
        foreach (char s in s1)
        {
            Console.WriteLine(" "+s);
        }
        string s2 = "hii";
        return s2;
    }

    //Array
    public void arrayDisp()
    {
        string[] nums = { "hyundai", "volvo" , "kia" };

        Console.WriteLine(nums);
    }


 }

