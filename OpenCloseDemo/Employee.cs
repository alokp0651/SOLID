using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseDemo
{
    //public class Employee
    public abstract class Employee   // 2nd ---changed to abstract  (Employee class now open for extention but close for modification)
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public string EmployeeType { get; set; }  // 3rd remove employee type

        public Employee() { }
       // public Employee(int id, string name, string employeeType)
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            //EmployeeType = employeeType; //4th from here also
        }
        //public decimal CalculateBonus(decimal salary) // 5th create this method abstract
        public abstract decimal CalculateBonus(decimal salary);
       // {
            //if (this.EmployeeType == "Permanent") // 6th remove all this code from this method
            //    return salary * .1M;
            //else
            //    return salary * .05M;    //<<<1st---We enhance the same code according to new requirement ... so what we do we change now the Employee class to abstract class and the furter enhancement will be done in the derived class( Go to line no 9 and change it to abstract
       // }
        public override string ToString()
        {
            return string.Format("ID : {0} Name :{1}",this.Id,this.Name);
        }
    }
    public class PermanentEmployee : Employee   //7th step
    {
        public PermanentEmployee() 
        { }
        public PermanentEmployee(int id,string name) : base(id,name)
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    public class TemporaryEmployee:Employee
    {
        public TemporaryEmployee() { }
        public TemporaryEmployee(int id,string name) : base(id,name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

    }
}
