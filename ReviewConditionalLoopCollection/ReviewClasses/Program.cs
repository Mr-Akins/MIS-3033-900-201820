using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student adam = new Student();
            adam.FirstName = "Adam";
            adam.LastName = "Ackerman";
            adam.GPA = 1.5;
            adam.IsOnProbation = true;
            adam.SoonerID = 1;

            Student tim = new Student(2, "Timothy", "Fisher", 85000);

            Console.ReadKey();
        }
    }
}
