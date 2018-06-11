using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //Fields/Properties

        public int EmployeeID { get; set; }

        //Methods

        public abstract double ShowID();
        public abstract string ClockIn();
    }
}
