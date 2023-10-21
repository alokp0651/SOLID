using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovDemo
{
        public abstract class Employee
        {
        
            public int Id { get; set; }
            public string Name { get; set; }
            

            public Employee() { }
            
            public Employee(int id, string name)
            {
                this.Id = id;
                this.Name = name;

            }
           
            public abstract decimal CalculateBonus(decimal salary);
           
            public override string ToString()
            {
                return string.Format("ID : {0} Name :{1}", this.Id, this.Name);
            }
        }
        public class PermanentEmployee : Employee   
        {
            public PermanentEmployee()
            { }
            public PermanentEmployee(int id, string name) : base(id, name)
            { }
            public override decimal CalculateBonus(decimal salary)
            {
                return salary * .1M;
            }
        }
        public class TemporaryEmployee : Employee
        {
            public TemporaryEmployee() { }
            public TemporaryEmployee(int id, string name) : base(id, name) { }
            public override decimal CalculateBonus(decimal salary)
            {
                return salary * 0.5M;
            }

        }
    /// <summary>
    /// 2nd so here we create one new derived class ContractEmployee in which we 
    /// </summary>
    public class ContractEmployee: Employee  
    {
        public ContractEmployee() { }
        public ContractEmployee(int id, string name) : base(id,name) { }

        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();  //3rd ContractEmployee is not eligble for any bonus hence we throw exception here in the implementation of CalculateBonus
        }

    }
}

