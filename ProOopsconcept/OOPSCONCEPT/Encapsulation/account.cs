using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.Encapsulation
{
    internal class account
    {
        private double balance = 2000;

        public void SetBalance(double balance)
        {
            if (balance < 0)
                Console.WriteLine("please enter valide amount like more than 100 rs");
            else
                this.balance = this.balance + balance;
        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        }

    }
}
