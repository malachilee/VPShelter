using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {   //Fields/Properties

        public int HoursAvailable { get; set; }
        public string VolunteerName { get; set; }

        // Constructors

        public Volunteer()
        {
            // Default Constructor
        }

        public Volunteer(int hoursAvailable, string volunteerName)
        {
            HoursAvailable = hoursAvailable;
            VolunteerName = volunteerName;
        }

        //Methods

        public override string ClockIn()
        {
            return "Volunteer clocked in!";
        }
        public override double ShowID()
        {
            return EmployeeID;
        }

        public string FeedPets()
        {
            return "All pets have been fed.";
        }

        public string WaterPets()
        {
            return "All pets now have water.";
        }

        //internal bool Play()
        //{
        //    throw new NotImplementedException();
        //}

        
    }
}
