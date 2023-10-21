using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSolution.Interface
{
    internal interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);//1st it is the part of the base class which is now we created interface.
    }
}
