using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioResponsabilidadUnica
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal HourlySalary { get; set; }

        public Employee(string name, string position, decimal hourlySalary)
        {
            Name = name;
            Position = position;
            HourlySalary = hourlySalary;
        }

        public decimal CalculatePayRoll(int hoursWorked)
        {
            return HourlySalary * hoursWorked;
        }
    }

}
