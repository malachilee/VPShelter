using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Cat : VirtualPet
    {
        //Fields/Properties

        public string CatBreed { get; set; }
        public string Diet { get; set; }

        //Constructors

        public Cat()
        {
            //Default Constructor
        }

        public Cat(string catBreed, string diet)
        {
            CatBreed = CatBreed;
            Diet = diet;
        }
    }
}
