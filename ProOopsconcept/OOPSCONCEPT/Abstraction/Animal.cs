using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Abstraction
{
    abstract class Animal

    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("non abstract method");

        }

    }
}
