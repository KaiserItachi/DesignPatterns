using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Mozzeralla : ToppingDecorator
    {
        public Mozzeralla(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Dough");

            Console.WriteLine("Adding Moz");
        }

        public new double GetCost()
        {
            return tempPizza.GetCost()+ 0.5;
        }

        public new string GetDiscription()
        {
            return tempPizza.GetDiscription() + "Mozzeralla Sauce";
        }
    }
}
