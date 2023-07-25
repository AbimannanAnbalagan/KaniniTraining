using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    //1
    /*
    internal class Result
    {
        private int x;
        private int y; 

        public Result(int x , int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void calculate()
        {
            if (this.x > 0 && this.y > 0)
                Console.WriteLine($"The coordinate point ({this.x},{this.y}) lies in the First quadrant");
            else if (this.x < 0 && this.y > 0)
                Console.WriteLine($"The coordinate point ({this.x},{this.y}) lies in the Second quadrant");
            else if (this.x > 0 && this.y < 0)
                Console.WriteLine($"The coordinate point ({this.x},{this.y}) lies in the Fourth quadrant");
            else
                Console.WriteLine($"The coordinate point ({this.x},{this.y}) lies in the Third quadrant");

        }
    }
     */
    //2
    /*
    internal class Result
    {
        private int physics;
        private int chemistry;
        private int cmpapp;
        private int total;
        private int percentage;
        private string division;

        public Result(int physics,int chemistry,int cmpapp)
        {
            this.physics = physics;
            this.chemistry = chemistry; 
            this.cmpapp = cmpapp;
        }

        public int Total { get => total; set => total = value; }
        public int Percentage { get => percentage; set => percentage = value; }
        public string Division { get => division; set => division = value; }

        public void calculate()
        {
            this.total = this.chemistry+this.physics+this.cmpapp;
            this.percentage = this.total / 3;
            if (this.percentage >= 80)
                this.Division = "First";
            else if (this.percentage >= 60 && this.percentage < 80)
                this.Division = "Second";
            else if (this.percentage >= 40 && this.percentage < 60)
                this.Division = "Third";
            else
                this.Division = "No Grade";

        }
    }
    */
    //3
    /*
    internal class Result
    {
        private int unit;
        private double cost;

        public Result(int unit)
        {
            this.unit = unit;
        }

        public double Cost { get => cost; set => cost = value; }

        public void calculate()
        {
            if (this.unit > 0 && this.unit <= 199)
            { 
                cost = unit*1.20;
            }
            else if (this.unit >= 200 && this.unit < 400)
                cost =unit* 1.50;
            else if (this.unit >= 400 && this.unit < 600)
             cost = unit*1.80;
            else
                cost =unit* 2.00;


            if (cost > 400)
            {
                cost = unit * (15 / 100);
            }
            if (cost <100)
            { 
                Console.WriteLine(cost);
                cost = 100;
            }
        }
    }
    */
    //4
    /*
    internal class Result
    {
        public int d = 1;
        public void pattern()
        {
            for (int i = 1; i <5 ; i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.Write(d + " ");
                    d++;
                }
                Console.WriteLine();
            }
        }
    }
    
    //4
    internal class Result
    {
        private int increament_variable = 1;
        private int rows = 5;
        public void pattern()
        {
            
        }

    }
    */
    //5
    /*
    internal class Result
    {
        string[] cars = { "hyundai", "kia", "tata", "Mahindra" ,"maruti" ,"Mahindra"};
        int[] marks = { 55, 20, 45, 90, 42 };

        public void Fivef()
        {
            int num1 = 0;
            int num2 = 0;
            for (int i =0;i<marks.Length;i++)
            {
                if (marks[i]>num1)
                    num1 = marks[i];
            }
            
            for (int i =0; i<marks.Length;i++) 
            {
                if (marks[i]>num2 && marks[i]!=num1)
                    num2 = marks[i];
            }
            Console.WriteLine(num2);
        }

        public void Fivea() 
        { 
            for (int i = 0; i<cars.Length; i++)
            {
                Console.WriteLine(cars[cars.Length-(i+1)]);
            } 
        }
        public void Fiveb()
        {
            string[] Cars = cars;
            for (int i = 0;i< Cars.Length;i++)
            {
                Console.WriteLine(Cars[i]);
            }
        }
        public void Fivec()
        {
            int[] marks = { 55, 20, 45, 90, 42 };
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum+=marks[i];
            }
        }
        public void Fived()
        {
            
            int count = 0;
            int dummy = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                
                for (int j=0; j<cars.Length; j++)
                {
                    
                    if (cars[i] == cars[j])
                        {
                        dummy++;
                        }
                }
                if (dummy >1)
                {
                    count++;
                }
                dummy = 0;
                
            }
        Console.WriteLine(count/2);
        }

        public void Fivee()
        {
            int count = 0;
            int dummy = 0;
            for (int i=0; i<cars.Length ; i++)
            {
                for (int j=0; j<cars.Length;j++)
                    if (cars[i] != cars[j])
                    {
                        dummy++;
                    }
                if (dummy==cars.Length - 1)
                {
                    count++;
                }
                dummy = 0;
            }
            Console.WriteLine(count);
        }

    }

    */
    //7
    /*
    internal class Result
    {
        int[] array = {11,12,13,14,15,16};
        private int dummy1 = 1;
        private int dummy2 = 0;

        public int Dummy1 { get => dummy1; set => dummy1 = value; }
        public int Dummy2 { get => dummy2; set => dummy2 = value; }

        public int primenumber()
        {
            for (int i = 0; i< array.Length; i++)
            {
                for (int j = (array[i]-1);j>1;j--)
                {
                    
                    //Console.WriteLine(array[i]%j);
                    if (array[i] % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        Dummy1++;
                    }
                }
                //Console.WriteLine(Dummy1);
                if (Dummy1 == array[i]-1)
                {

                    Dummy2 += array[i];
                }
                Dummy1 = 1;
            }
            return Dummy2;
        }
    }
    */
    //8
    /*
    internal class Result
    {
        
        private string str = "hello all where are you ";
        private int count = 0 ;
        public string Str { get => str; set => str = value; }
        public int Count { get => count; set => count = value; }

        public int strlen()
        {
            for (int i =0; i<str.Length; i++)
            {
                if (str[i] == ' ' && i != str.Length-1)
                {
                    count++;
                }
            }
            return count+1;
        }
    }*/
    //9
    /*
    internal class Result
    {
        private string str = string.Empty; 
        private int alphabet = 0, numbers = 0, splchr = 0;
    public Result(string str)
        {
            this.Str = str;
        }

        public string Str { get => str; set => str = value; }
        public int Alphabet { get => alphabet; set => alphabet = value; }
        public int Numbers { get => numbers; set => numbers = value; }
        public int Splchr { get => splchr; set => splchr = value; }

        public void count()
        {
            for (int i =0; i<str.Length;i++)
            {
                if ((str[i]>'a' && str[i]<'z') || (str[i]>'A' && str[i]<'Z' ))
                {
                    this.Alphabet++;
                }
                else if (str[i]>='0' && str[i]<'9') 
                {
                    this.Numbers++;
                }
                else
                {
                    this.Splchr++;
                }
            }
            
        }
    }
    */
    //10
    /*
    internal class Result
    {
        string str = "abcd";
        int oe = 0;
        string str1 = string.Empty;

        public void middle()
        {
            oe = str.Length % 2;
            if (oe != 0)
            {
                Console.WriteLine("The Middle character is "+str[str.Length / 2]);
            }
            else
            {
                Console.WriteLine($"The Middle Characters are {str[(str.Length / 2)-1]} {str[str.Length / 2]}");
            }
        }
    }
    */
    //11
    /*
    internal class Result
    {
        int num = 10;
        int num1= 0, num2= 1 ,fib=0 , dummy =0;
        
        public void fibonacci()
        {
            Console.WriteLine(num1);
            for (int i =1; i<num; i++)
            {
                fib = num1 + num2;
                dummy= num2;
                num2= fib;
                num1 = dummy;
                Console.WriteLine(fib);
            }
        }
    }*/
    //12
    /*
    internal class Result
    {
        int num = 374;
        int dummy =0 , rem =0 ,total = 0;
        
        public void armstrong() 
        {
            dummy = num;
            while (dummy>0)
            {
                rem = dummy % 10;
                total += rem * rem * rem;
                dummy /= 10;
            }
            if (total == num)
            {
                Console.WriteLine($"{num} is a armstrong number");
            }
            else
            {
                Console.WriteLine($"{num} is a armstrong number");
            }
        }
    }
    */
    //13
    /*
    internal class Result
    {
        int num = 27;
        int total = 0;
        public void perfectnum()
        {
            for (int i = num-1;i>0;i--)
            {
                if (num % i == 0)
                {
                    total += i;
                }
            }
            if (num == total)
            {
                Console.WriteLine(total+" is a perfect number");
            }
            else
            {
                Console.WriteLine(num+" is not a perfect number");
            }
        }   
    }*/
    //14
    /*
    internal class Result
    {
        private int num = 17;
        int dummy = 0;

        public void primenumber()
        {
        for (int i=num-1; i>1; i--) 
            {
                if (num % i != 0)
                {
                    dummy += 1;
                }
            }
        if (dummy == num-2)
            {
                Console.WriteLine(num + " is a prime number");
            }
        else
            {
                Console.WriteLine(num + " is not a prime number");
            }
        }
    }
    */
    //15
    /*
    internal class Result
    {
        string num = "12133121";
        int dummy = 0, j=0;
        public void palindrome()
        {
            for (int i =num.Length-1; i >=0; i--)
            {
                if (num[i] == num[j])
                {
                    dummy += 1;
                }
                j += 1;
            }
            //Console.WriteLine(dummy);
            if (dummy == num.Length)
            {
                Console.WriteLine(num + " is a palindrome");
            }
            else
            {
                Console.WriteLine(num + " is not a palindrome");
            }
        }
    }
    */
    

}
