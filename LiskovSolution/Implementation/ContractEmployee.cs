using LiskovSolution.Abstract;
using LiskovSolution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSolution.Implementation
{
    public class ContractEmployee :IEmployee
    {
      
        public int ID { get; set; }
        public string Name {  get; set; }
        public ContractEmployee()
        { }
        public ContractEmployee(int iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }
        public  decimal GetMinimumSalary()
        {
            return 5000;
        }
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
// note we can see here in ContractEmployee we only Inherting interface IEmployee interface not Employee abstract class because Employee abstract class inherting all two interface which is calculating bonus as well as getting minimum salary of employee and in open close priciple we see that contractEmployee throwing exception on  calculatebonus so we just Inherit IEmployee in ContractEmployee class because IEmployee interface dont have calculate bonus method soo it wiil not throw exception and also it follow all the guidlines for liscov. 