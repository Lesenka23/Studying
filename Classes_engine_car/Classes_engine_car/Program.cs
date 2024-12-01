using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_engine_car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine();
            Car car1 = new Car(engine1);
            bool canFill = car1.TryFillTank(50);
            Console.WriteLine(canFill);
            Console.WriteLine(car1.GetFuel());
            canFill = car1.TryFillTank(50);
            Console.WriteLine(canFill);
            Console.WriteLine(car1.GetFuel());
            Console.ReadKey();
        }
    }
}
