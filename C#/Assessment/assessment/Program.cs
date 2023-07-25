using assessment;

class Program
{
    //Q1

    public static void Main()
    {
        /*
        Console.WriteLine("Enter the no of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 1 for character pattern:\nEnter 2 for numeric pattern:");
        int input = Convert.ToInt32(Console.ReadLine());

        Qstn1 qstn1 = new Qstn1(rows);

        switch (input)
        {
            case 1:
                {
                    qstn1.CharacterPattern();
                    break;
                }
            case 2:
                {
                    qstn1.NumericPattern();
                    break;
                }
            default:
                {
                    Console.WriteLine("Enter the correct input");
                    break;
                }
        }
    }
}
        */

        //Q2 A


        /*
        Console.WriteLine("For Addtion:1 \t For Subtraction:2 \t For Multiplication:3 \t For Division:4 \t For Modular:5");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value1:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value2");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Qstn2_a1 qstn2_A = new Qstn2_a1(num1, num2);
        switch (input)
        {
            case 1:
                {
                    qstn2_A.add();
                    Console.WriteLine($"{num1}+{num2} = {qstn2_A.Result}");
                    break;
                }
            case 2:
                {
                    qstn2_A.sub();
                    Console.WriteLine($"{num1}-{num2} = {qstn2_A.Result}");
                    break;
                }
            case 3:
                {
                    qstn2_A.mul();
                    Console.WriteLine($"{num1}*{num2} = {qstn2_A.Result}");
                    break;
                }
            case 4:
                {
                    qstn2_A.div();
                    Console.WriteLine($"{num1}/{num2} = {qstn2_A.Result}");
                    break;
                }
            case 5:
                {
                    qstn2_A.mod();
                    Console.WriteLine($"{num1}%{num2} = {qstn2_A.Result}");
                    break;
                }
            default:
                {
                    Console.WriteLine("Enter the correct input");
                    break;
                }
        }
    }
}
        
        //Q2 B 


        
            Qstn2_b fileHandling = new Qstn2_b();
            fileHandling.CreateFile();
            fileHandling.Readfile();

        }
    }
*/
        //Q2



//Q3  Using list



            List<long> list = new List<long>();
            list.Add(6785785857);
            list.Add(9839875612);
            list.Add(6329008934);
            list.Add(8849379834);
            list.Add(8492797589);
            list.Add(9492797589);
            list.Add(6492797532);
            list.Add(9462797580);
            list.Add(9834789347);
            list.Add(8372637634);
            Console.WriteLine("Enter the balance amount:");
            double balance  = Convert.ToDouble(Console.ReadLine());
            Qstn3_2 ques = new Qstn3_2(balance);
            ques.CallLog(list);
            ques.DialLastCall(list);

    }
}


