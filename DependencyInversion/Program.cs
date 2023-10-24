using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{/// <summary>
 /// The Dependency Inversion Principle (DIP) is one of the SOLID principles of object-oriented design and encourages decoupling between high-level and low-level modules in your code. In C#, this is often achieved through the use of interfaces and dependency injection. Here's a simple example to illustrate the Dependency Inversion Principle:
 /// Suppose you have a high-level class called Car that depends on a low-level class called Engine.Without following the Dependency Inversion Principle, your code might look like this:
/// </summary>
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }

    public class Car
    {
        private Engine engine;

        public Car()
        {
            engine = new Engine();
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartCar();
        }
    }
}
