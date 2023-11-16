using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee: IEmployee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public char Gender { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Аты: {FName}, Фамилия: {LName}, Жұмысқа қабылданған уақыты: {HireDate.ToShortDateString()}, Лауазым: {Position}, Жынысы: {Gender}, Жалақы: {Salary}";
        }
    }
}
