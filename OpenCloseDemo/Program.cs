using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee empJhon = new Employee(1 ,"John","Permanent");
            //Employee empJason = new Employee(1 ,"Jason","Temp");   //8th
            Employee empJhon = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Emploee {0} Bonus :{1}",
                empJhon.ToString(),
                empJhon.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Emploee {0} Bonus :{1}",
               empJason.ToString(),
               empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}
