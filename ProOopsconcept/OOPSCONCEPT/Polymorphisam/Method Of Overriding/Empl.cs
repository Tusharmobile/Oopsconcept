using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Polymorphisam.Method_Of_Overriding
{
    internal class Empl
    {
        public string name;
        public double salary;


        public void EmplDetails()
        {
            Console.WriteLine("name:" + name);
        }


        public void GetSalary()
        {
            Console.WriteLine("salary:500");
        }

        }

    }

