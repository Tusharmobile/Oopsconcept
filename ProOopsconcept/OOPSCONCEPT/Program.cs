using System;
using OOPSCONCEPT.Inheritance;
using OOPSCONCEPT.Abstraction;
using OOPSCONCEPT.Interface;
using OOPSCONCEPT.Encapsulation;
using OOPSCONCEPT.Classobject;
using OOPSCONCEPT.Polymorphisam.Method_Of_Overloading;
using OOPSCONCEPT.Polymorphisam.Method_Of_Overriding;
using OOPSCONCEPT.Constractor;
using OOPSCONCEPT.Constractor;
using OOPSCONCEPT.PassByValue;
using OOPSCONCEPT.PassByValue;
using OOPSCONCEPT.Array;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dog d = new Dog();
             d.display();
             Tiger tiger = new Tiger();
             tiger.animalsound();
             Pig p = new Pig();
             p.AnimalSound();
             p.Details();
            */
            /* account ac = new account();
              ac.SetBalance(-1000);
              ac.GetBalance();
              Console.ReadLine();
              Rectanger r = new Rectanger();
              r.RectangleDetails();
              r.display();*/

            /* Dog1 pug = new Dog1();
             pug.age = 10;
             pug.breed = "pug";
             pug.color = "black";
             pug.size = 23;
             pug.Sleep();
             Console.WriteLine("pug details:age;{0},size;{1},color:{2},breed:{3}", pug.age, pug.size, pug.color, pug.breed);

             Dog1 puppy = new Dog1();
             puppy.age = 20;
             puppy.breed = "puppy";
             puppy.color = "white";
             puppy.size = 23;
             puppy.Sleep();
             Console.WriteLine("puppy details:age;{0},size;{1},color:{2},breed:{3}", puppy.age, puppy.size, puppy.color, puppy.breed);

             Dog1 moti = new Dog1();
             moti.age = 30;
             moti.breed = "moti";
             moti.color = "";
             moti.size = 23;
             moti.Sleep();

             Console.WriteLine("moti details:age;{0},size;{1},color:{2},breed:{3}", moti.age, moti.size, moti.color, moti.breed);
           */
            Console.WriteLine("method overloading....");
            Addition add = new Addition();
            add.SumOfNumbers(10, 20, 30);
            PartTimeEmpl pt = new PartTimeEmpl();
            pt.GetSalary();
            Empl1 emp = new Empl1();
            Empl12 e = new Empl12(101, "tushar", 50000);
            e.Display();
            PassBy.Test();
            PassByRefrence.TestReferenceType();
            Console.ReadLine();
            ArrayMultiplication.GetArrrayMultiplication();
            Console.ReadLine();
















        }
    }
}
