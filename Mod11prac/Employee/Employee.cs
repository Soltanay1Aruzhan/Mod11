using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeelib
{
    public enum Vacancies
    {
        PoliceOfficer,
        Military,
        Firefighter,
        Medic
    }

    public struct Employee
    {
        
        public string name;

       
        public Vacancies vacancy;

        
        public int[] hireDate;

        
        public int salary;
    }
}
