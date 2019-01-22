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

            Console.WriteLine("Please enter your first name : >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number : >>");
            favoriteNumber = Convert.ToInt32(Console.ReadLine());

            if (favoriteNumber == 5)
            {
                Console.WriteLine("Hey that's my favorite nuber too!!");
            }
            else
            {
                Console.WriteLine(favoriteNumber + " is still a good number even though it's not my favorite.");
            }

            Console.ReadKey();
        }


    }
}
