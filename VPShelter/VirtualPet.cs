using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPet
    {
        //Fields/Properties
        public int Age { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get;set; }
        public int Boredom { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Constructors

        public VirtualPet()
        {
            // Default Constructor
        }

        public VirtualPet(int age, int hunger, int thrist, int boredom, string name, string description)
        {
            this.Age = age;
            this.Hunger = hunger;
            this.Thirst = thrist;
            this.Boredom = boredom;
            this.Name = name;
            this.Description = description;
        }

        public VirtualPet(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        //Methods

        public void Tick()// Tick Method
        {
            this.Age++;
            this.Hunger += 5;
            this.Thirst += 4;
            this.Boredom += 5;
        }

        public void Feed()
        {
            this.Tick();
            this.Hunger -= 30;
            this.Thirst += 5;
            Console.WriteLine("{0} says thanks, that tasted great!", this.Name);
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now is: {1}", this.Name, this.Thirst);
            Console.WriteLine("{0}s Boredom level now is: {1}", this.Name, this.Boredom);
        }

        public void GiveWater()
        {
            this.Tick();
            this.Thirst -= 40;
            Console.WriteLine("{0} says that was refreshing!", this.Name);
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now: {1}", this.Name, this.Thirst);
            Console.WriteLine("{0}s Boredom level now is: {1}", this.Name, this.Boredom);
        }

        public void Play()
        {
            this.Tick();
            this.Boredom -= 40;
            this.Hunger += 10;
            this.Thirst += 10;
            Console.WriteLine("{0} is No longer bored", this.Name);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now: {1}", this.Name, this.Thirst);
            Console.WriteLine("{0}s Boredom level now is: {1}", this.Name, this.Boredom);
        }

        public void DoNothing()
        {
            this.Tick();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now: {1}", this.Name, this.Thirst);
            Console.WriteLine("{0}s Boredom level now is: {1}", this.Name, this.Boredom);
        }

    }
}
