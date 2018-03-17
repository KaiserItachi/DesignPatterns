using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Sauce");
        }

        public new double GetCost()
        {
            return tempPizza.GetCost() + 1.5;
        }

        public new string GetDiscription()
        {
            return tempPizza.GetDiscription() + "Tomato Sauce";
        }
    }
}
