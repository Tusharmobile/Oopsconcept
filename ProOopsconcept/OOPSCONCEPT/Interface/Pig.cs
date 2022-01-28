using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Interface
{
    
    


    internal class Pig : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("jj");
        }
        public void Sleep()
        {
            Console.WriteLine("zz");
        }
        public void Details()
        {
            Console.WriteLine("aa");
        }
    }
}