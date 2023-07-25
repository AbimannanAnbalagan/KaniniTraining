using Assignment4;

//Q1
/*
class program
{
    public static void Main(string[] args)
    {

        Console.Write("Enter the no of strings: ");
        int count = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the string to be displayed and not displayed: ");
        string input = Console.ReadLine();

        string[] arr = new string[count];
        for (int i=0; i<count; i++)
        {
            Console.Write($"Enter the string {i + 1}: ");
            arr[i] = Console.ReadLine();           
        }

        Qstn1 qstn1 = new Qstn1();
        qstn1.a(arr);
        qstn1.b(arr);
        
    }
}
*/

/*
//Qstn2
 
class program
{
    public static void Main(string[] args)
    {
        
        
        Console.WriteLine("Enter the string");
        string input1 = Console.ReadLine();
        Qstn2 qstn2 = new Qstn2();
        Console.WriteLine( qstn.StringCount(input1));
        
    }
}
*/

//Q3
/*
class program
{
    public static void Main(string[] args)
    {

        
        Console.WriteLine("Enter the string");
        string input1 = Console.ReadLine();
        Qstn3 qstn3 = new Qstn3();
        Console.WriteLine( qstn3.SubstringCount(input1));
    }
}       
*/



//Q4
/*
class program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the string 1:");
        string string1 = Console.ReadLine();
        Console.WriteLine("Enter the string 2:");
        string string2 = Console.ReadLine();

        Qstn4 qstn4 = new Qstn4(string1,string2);
        qstn4.process();
        Console.WriteLine(qstn4.Preffix.Length +" "+ qstn4.Preffix);
        Console.WriteLine(qstn4.Content1.Length + " " + qstn4.Content1);
        Console.WriteLine(qstn4.Content2.Length + " " + qstn4.Content2);
        
    }

}
*/



//Q6
/*
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number :");
        int num  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of times :");
        int times  = Convert.ToInt32(Console.ReadLine());

        Qstn6 qstn6 = new Qstn6(num , times);
        qstn6.process();
        Console.WriteLine("Result: "+qstn6.Value);

    }
}
*/

//Qstn5
/*
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the count: ");
        int count = Convert.ToInt32(Console.ReadLine());
        Qstn5 qstn5= new Qstn5();
        for (int i= 0;i< count;i++)
        {
            Console.WriteLine(qstn5.process( Console.ReadLine()));
        }
    }
}
*/

//Qstn 7
/*

class Program
{
    static int[] parent;
    static int[] size;

    static int Find(int x)
    {
        if (parent[x] == x)
        {
            return x;
        }
        return parent[x] = Find(parent[x]);
    }

    static void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);
        if (rootX != rootY)
        {
            if (size[rootX] < size[rootY])
            {
                int temp = rootX;
                rootX = rootY;
                rootY = temp;
            }
            parent[rootY] = rootX;
            size[rootX] += size[rootY];
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        parent = new int[n + 1];
        size = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            parent[i] = i;
            size[i] = 1;
        }
        for (int i = 0; i < m; i++)
        {
            string[] line = Console.ReadLine().Split();
            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);
            Union(x, y);
        }
        int[] groupSize = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            groupSize[Find(i)]++;
        }
        int cost = 0;
        int remaining = n;
        for (int i = 1; i <= n; i++)
        {
            if (groupSize[i] > 0)
            {
                int k = (int)Math.Ceiling(Math.Sqrt(groupSize[i]));
                cost += k;
                remaining -= k * k;
            }
        }
        if (remaining > 0)
        {
            cost += (int)Math.Ceiling((double)remaining / Math.Sqrt(remaining));
        }
        Console.WriteLine(cost);
    }
}
*/



//Qstn8
/*
class Solution
{
    static void Main(string[] args)
    {
        string[] line1 = Console.ReadLine().Split();
        int n = int.Parse(line1[0]);
        int q = int.Parse(line1[1]);


        List<int>[] armies = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            armies[i] = new List<int>();
        }


        int[] maxCombat = new int[n];
        for (int i = 0; i < n; i++)
        {
            maxCombat[i] = int.MinValue;
        }


        for (int i = 0; i < q; i++)
        {
            string[] line = Console.ReadLine().Split();
            int type = int.Parse(line[0]);

            if (type == 1)
            {
                int army = int.Parse(line[1]) - 1;
                Console.WriteLine(maxCombat[army]);
            }
            else if (type == 2)
            {
                int army = int.Parse(line[1]) - 1;
                int maxCombatIndex = armies[army].Count - 1;
                for (int j = armies[army].Count - 2; j >= 0; j--)
                {
                    if (armies[army][j] > armies[army][maxCombatIndex])
                    {
                        maxCombatIndex = j;
                    }
                }
                armies[army].RemoveAt(maxCombatIndex);
                if (armies[army].Count > 0)
                {
                    maxCombat[army] = armies[army][armies[army].Count - 1];
                }
                else
                {
                    maxCombat[army] = int.MinValue;
                }
            }
            else if (type == 3)
            {
                int army = int.Parse(line[1]) - 1;
                int combat = int.Parse(line[2]);
                armies[army].Add(combat);
                if (combat > maxCombat[army])
                {
                    maxCombat[army] = combat;
                }
            }
            else
            {
                int army1 = int.Parse(line[1]) - 1;
                int army2 = int.Parse(line[2]) - 1;
                armies[army1].AddRange(armies[army2]);
                armies[army2] = null;
                maxCombat[army1] = Math.Max(maxCombat[army1], maxCombat[army2]);
                maxCombat[army2] = int.MinValue;
            }
        }
    }
}
*/
