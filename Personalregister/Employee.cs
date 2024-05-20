using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public double wage;

        public Employee(string first, string last, double wageValue) 
        {
            firstName = first;
            lastName = last;
            wage = wageValue;
        }
    }
}
