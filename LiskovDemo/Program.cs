using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovDemo
{

    /// <summary>
    /// 1st This Example also satisfied the Liskov substitution principle partialy because it is not following one of the implementation guideline of liskov that is no new exception can be thrown by the sub type 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empJhon = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");

            Employee empMike = new ContractEmployee(3, "Mike"); //4th now we add empMike as Contract employee

            Console.WriteLine(string.Format("Emploee {0} Bonus :{1}",
                empJhon.ToString(),
                empJhon.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Emploee {0} Bonus :{1}",
               empJason.ToString(),
               empJason.CalculateBonus(150000).ToString()));
            Console.WriteLine(string.Format("Emploee {0} Bonus :{1}",
              empMike.ToString(),
              empMike.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}
//note : if we run program after step 4th step it will thow exception and unsatisfied implementation of liskov
// 5th create a new app that will satisfy the guidline for the implementation of liskov principle