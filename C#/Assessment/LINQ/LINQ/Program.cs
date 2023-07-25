using LINQ;
using System.Collections;

delegate bool EligibilityCheck(People person);
class program
{
    public static void Main(string[] args)
    {
        People[] people =
        {
            new People(){Name = "Abi" , Age = 16},
            new People(){Name = "Mozhi" , Age = 17},
            new People(){Name = "Anbu" , Age = 18},
            new People(){Name = "Aswin" , Age = 19},
            new People(){Name = "Nivin" , Age = 20},
        };

        /*
        People[] voters = new People[people.Length];

        int i = 0;

        foreach (People person in people)
        {
            //Console.WriteLine(person.Name);
            if (person.Age > 18)
            {
                voters[i] = person;
                Console.WriteLine(person.Name);
                i++;
            }
        }
        */
        /*
        List<People> voters = VoterCheck.where(people, delegate(People person)
        {
            return person.Age >= 18;
        } );
        foreach ( People person in voters )
        {
            Console.WriteLine( person.Name + person.Age );
        }
        */

        /*

        List<People> voters = people.Where(p=> p.Age>=18).ToList();

        var voters1 = (from p in people where p.Age >= 18 select p);

        foreach (People person in voters)
        {
            Console.WriteLine(person.Name + person.Age);
        }

        foreach (People person in voters1)
        {
            Console.WriteLine(person.Name + person.Age);
        }
        */
        ExamplesForClassification examples = new ExamplesForClassification();
        //examples.Example1();
        //examples.Example3();
        //examples.Sorting_OrderBy();
        examples.GroupBy();
    }
}
