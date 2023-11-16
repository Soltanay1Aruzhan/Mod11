using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public interface IEmployee
    {
        string FName { get; set; }
        string LName { get; set; }
        DateTime HireDate { get; set; }
        string Position { get; set; }
        char Gender { get; set; }
        decimal Salary { get; set; }
    }
}
