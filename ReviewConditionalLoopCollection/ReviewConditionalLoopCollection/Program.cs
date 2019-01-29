using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewConditionalLoopCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int favoriteNumber;

            //Console.WriteLine("Please enter your first name : >>");
            //firstName = Console.ReadLine();

            //Console.WriteLine("Please enter your favorite number : >>");
            //favoriteNumber = Convert.ToInt32(Console.ReadLine());

            //if (favoriteNumber == 5) // Check to see if 5 is their favorite number
            //{
            //    Console.WriteLine("Hey that's my favorite nuber too!!");
            //}
            //else if (favoriteNumber == 7)
            //{
            //    Console.WriteLine("Way to be original");
            //}
            //else
            //{
            //    Console.WriteLine(favoriteNumber + " is still a good number even though it's not my favorite.");
            //}

            //switch (favoriteNumber)
            //{
            //    case 5:
            //        Console.WriteLine("Hey that's my favorite number too!!");
            //        break;
            //    case 7:
            //        Console.WriteLine("Way to be original");
            //        break;
            //    default:
            //        Console.WriteLine(favoriteNumber + " is still a good number even though it's not my favorite.");
            //        break;
            //}


            //loop
            //int counter = -1;
            //while (counter <= 10)
            //{
            //    counter++;
            //    if (counter <= 10  )
            //    {
            //        Console.WriteLine(counter);

            //    }
            //}
            int counter;
            //for (counter = 0; counter <= 10; counter = counter + 1) // for loop to count from 0 to 10 inclusive
            //{
            //    Console.WriteLine(counter);
            //}
            //for (counter = 10; counter >= 0; counter--) // for loop to count from 10 to 0 inclusive
            //{
            //    if (counter == 0)
            //    {
            //        Console.WriteLine("BLAST OFF");
            //    }
            //    else
            //    {
            //        Console.WriteLine(counter);

            //    }
            //}

            //for(counter = 1; counter <= 100; counter++)
            //{
            //    int answer = counter % 2;
            //    if (answer == 1)
            //    {
            //        Console.WriteLine(counter);
            //    }
            //}



            //for (counter = 1; counter <= 100; counter = counter + 2)
            //{
            //    Console.WriteLine(counter);
            //}
            //Console.WriteLine("The last value of counter is now " + counter);

            //Console.WriteLine("Knock knock");
            //string reply;// = Console.ReadLine();
            ////reply = reply.ToLower();
            //do{
            //    Console.WriteLine("Knock knock");
            //    reply = Console.ReadLine();
            //} while (reply.Equals("who's there?", StringComparison.CurrentCultureIgnoreCase)) ;

            //Console.WriteLine("Dontcha love knock knock jokes? ;) <3");

            //string[] firstNames = new string[5];
            //string[] lastNames = new string[5];
            //firstNames[0] = "Adam";
            //lastNames[0] = "Ackerman";
            //firstNames[1] = "Steve";
            //lastNames[1] = "Jobs";

            //for (int i = 0; i < 5; i++)
            //{
            //    if (lastNames[i] != null && firstNames[i] != null)
            //    {
            //        Console.WriteLine($"{lastNames[i]}, {firstNames[i]}");

            //    }
            //}

            //List<double> examScores = new List<double>();
            //examScores.Add(75.5);
            //examScores.Add(5.5);
            //examScores.Add(85.5);
            //examScores.Add(95.5);
            //examScores.Add(100);

            //double total = 0;
            //foreach (double item in examScores)
            //{
            //    total = item + total;
            //}

            //double average = total / examScores.Count;

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Adam Ackerman");
            students.Add(500, "billy bob");
            if (students.ContainsKey(1) == true)
            {
                students[1] = "Jilly Jane";
            }
            else
            {
                students.Add(1, "jilly jane");
            }
            //Console.WriteLine(students[1]);

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Value} ({item.Key})");
            }

            Console.ReadKey();
        }



    }
}
