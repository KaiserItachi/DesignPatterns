using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new TomatoSauce(new Mozzeralla(new PlainPizza()));

            Console.WriteLine(pizza.GetDiscription());
        }
    }
}
