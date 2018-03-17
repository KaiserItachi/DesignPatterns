using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;

        public ToppingDecorator(IPizza newPizza)
        {
            tempPizza = newPizza;
        }

        public double GetCost()
        {
            return tempPizza.GetCost();
        }

        public string GetDiscription()
        {
            return tempPizza.GetDiscription();
        }
    }
}
