using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        // Fields/Properties
        public string ManName { get; set; }

        // Constructors

        public Manager()
        {
            // Default Constructor
        }

        public Manager(string manName)
        {
            ManName = manName;
        }

        // Methods
        public override string ClockIn()
        {
            return "Manager clocked In.";
        }

        public override double ShowID()
        {
            return EmployeeID;
        }

        public string AdoptPet()
        {
            return "The pet has been adopted.";
        }
    }
}
