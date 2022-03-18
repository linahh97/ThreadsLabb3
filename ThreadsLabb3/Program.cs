using System;
using System.Threading;

namespace ThreadsLabb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car() { Name = "Ferrari", Distance = 4000, Speed = 80 };
            Car c2 = new Car() { Name = "\t\t\tBugatti", Distance = 4000, Speed = 80 };
            Car c3 = new Car() { Name = "\t\t\t\t\t\tLamborghini", Distance = 4000, Speed = 80 };

            Thread car1 = new Thread(() => Car.Race(c1));
            Thread car2 = new Thread(() => Car.Race(c2));
            Thread car3 = new Thread(() => Car.Race(c3));

            Console.WriteLine("WELCOME TO FORMULA 1 CAR RACING, LET'S BEGIN THE COMPETITION!");
            Console.WriteLine("ENTER 's' FOR STATUS UPDATE ON THE RACE");
            Console.ReadKey();
            Console.WriteLine("ON YOUR MARK");
            Console.ReadKey();
            Console.WriteLine("GET SET");
            Console.ReadKey();
            Console.WriteLine("GO!");
            car1.Start();
            car2.Start();
            car3.Start();
        }
    }
}
