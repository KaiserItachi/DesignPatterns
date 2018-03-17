using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class PlainPizza : IPizza
    {
        public double GetCost()
        {
            return 4.00;
        }

        public string GetDiscription()
        {
            return "Thin Dough";
        }
    }
}
