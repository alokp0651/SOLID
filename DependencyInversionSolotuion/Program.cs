using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionSolotuion
{
    /// <summary>
    /// In the above code, the Car class directly depends on the Engine class, violating the Dependency Inversion Principle. To follow DIP, you should introduce an interface to abstract the low-level dependency (Engine) and use dependency injection to provide the concrete implementation. Here's the modified code:
    /// </summary>
    public interface IEngine
    {
        void Start();
    }

    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }

    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }
    }
    /// <summary>
    /// The example  provided illustrates the Dependency Inversion Principle (DIP) by using interfaces and dependency injection in C#. It's a simplified example to demonstrate the concept, but it is indeed a correct and valid way to follow DIP. 

      //In this example:

    //1. An interface `IEngine` is introduced to define a contract that any engine implementation should adhere to.
    //2. The `Engine` class implements the `IEngine` interface, ensuring that it provides the required functionality.
   //3. The `Car` class takes an `IEngine` object as a constructor parameter, allowing for dependency injection.This means that you can supply any class that implements the `IEngine` interface when creating a `Car` object, making it more flexible and following the DIP.

      //This example effectively decouples the `Car` class from the concrete implementation of the engine, promoting the principles of dependency inversion.If you have any specific concerns or questions about this example, please feel free to ask, and I'll be happy to provide further clarification.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine carEngine = new Engine();
            Car car = new Car(carEngine);
            car.StartCar();
        }
    }
}
