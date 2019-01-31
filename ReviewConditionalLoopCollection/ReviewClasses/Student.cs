using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewClasses
{
    class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance { get; set; }

        /// <summary>
        /// Default constructor for the Student class
        /// </summary>
        public Student()
        {
            SoonerID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 0;
        }

        /// <summary>
        /// Overloaded constructor for the Student class
        /// </summary>
        /// <param name="id">Sooner ID of the student</param>
        /// <param name="fName">First Name of the student</param>
        /// <param name="lName">Last name of the student</param>
        /// <param name="bursarBalance">Bursar Balance of the student</param>
        public Student(int id, string fName, string lName, double bursarBalance)
        {
            SoonerID = id;
            FirstName = fName;
            LastName = fName;
            BursarBalance = bursarBalance;
        }

        public void MakePayment(double amount)
        {
            if (amount > 0)
            {
                BursarBalance -= amount;
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

    }
}
