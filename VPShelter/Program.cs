using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manOne = new Manager("Bob");
            Volunteer vol = new Volunteer();
            Volunteer volOne = new Volunteer(30, "Tim");
            Volunteer volTwo = new Volunteer(20, "Cody");
            Volunteer volThree = new Volunteer(15, "Bill");

            VirtualPet Cat = new VirtualPet();
            VirtualPet catOne = new VirtualPet(2,30,30,30,"Mittens", "Young and Shy");
            VirtualPet catTwo = new VirtualPet(13,20,20,15,"Furball","Old and Fat");
            VirtualPet catThree = new VirtualPet(7,22,43,56,"Sir Pur-a-lot","Mid-Aged and Average");
           
            manOne.EmployeeID = 1111;
            volOne.EmployeeID = 2222;
            volTwo.EmployeeID = 3333;
            volThree.EmployeeID = 4444;
            

            //Main Menu

            int userChoice = 0;
            do
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("Employee Type:");
                Console.WriteLine("Managers press 1.");
                Console.WriteLine("Volunteers press 2.");
                Console.WriteLine();
                Console.WriteLine("To exit press 3.");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (userChoice == 1)
                {
                    do
                    {

                        Console.WriteLine();
                        Console.WriteLine("Manager menu:");
                        Console.WriteLine("To check Volunteer status press 1.");
                        Console.WriteLine("Clock in press 2.");
                        Console.WriteLine("Status of the pets press 3.");
                        Console.WriteLine("To start the adoption process press 4.");
                        Console.WriteLine("To go back to the main menu press 5.");
                        userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine("Employee information:");
                                Console.WriteLine("Name   ID   Hours");
                                Console.WriteLine("-------------------");
                                Console.WriteLine("{0}  {1}  {2}", volOne.VolunteerName, volOne.EmployeeID, volOne.HoursAvailable);
                                Console.WriteLine("{0}  {1}  {2}", volTwo.VolunteerName, volTwo.EmployeeID, volTwo.HoursAvailable);
                                Console.WriteLine("{0}  {1}  {2}", volThree.VolunteerName, volThree.EmployeeID, volThree.HoursAvailable);
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine(manOne.ClockIn());
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                            case 3:

                                Console.Clear();
                                Console.WriteLine("Name Hunger Thirst Age");
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("{0} {1} {2} {3}", catOne.Name, catOne.Hunger, catOne.Thirst, catOne.Age);
                                Console.WriteLine();
                                Console.WriteLine("{0} {1} {2} {3}", catTwo.Name, catTwo.Hunger, catTwo.Thirst, catTwo.Hunger, catTwo.Age);
                                Console.WriteLine();
                                Console.WriteLine("{0} {1} {2} {3}", catThree.Name, catThree.Hunger, catThree.Thirst, catThree.Hunger, catThree.Age);
                                Console.WriteLine();
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Type the name of the pet which is getting adopted.");
                                Console.WriteLine();
                                Console.WriteLine("Available pets:");
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("{0}" + " is " + "{1}", catOne.Name, catOne.Description);
                                Console.WriteLine();
                                Console.WriteLine("{0}" + " is " + "{1}", catTwo.Name, catTwo.Description);
                                Console.WriteLine();
                                Console.WriteLine("{0}" + " is " + "{1}", catThree.Name, catThree.Description);
                                string adopterPet = Console.ReadLine().ToLower();
                                if (adopterPet == "mittens")
                                {
                                    Console.WriteLine("Mittens has been adopted.");

                                }
                                else if (adopterPet == "furball")
                                {
                                    Console.WriteLine("Furball has been adopted.");

                                }
                                else if (adopterPet == "sir Pur-a-lot")
                                {
                                    Console.WriteLine("Sir Pur-a-lot has been adopted.");
                                   
                                }
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                break;
                        }
                    } while (userChoice != 5);

                }
                else if (userChoice == 2)
                {
                    do
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Volunteer menu:");
                        Console.WriteLine("To clock in press 1.");
                        Console.WriteLine("To feed the pets press 2.");
                        Console.WriteLine("To give the pets water press 3.");
                        Console.WriteLine("To play with a pet press 4.");
                        Console.WriteLine("To exit and return to the main menu press 5.");
                        userChoice = int.Parse(Console.ReadLine());
                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine(vol.ClockIn());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 2:
                                catOne.Feed();
                                catTwo.Feed();
                                catThree.Feed();
                                Console.WriteLine(vol.FeedPets());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 3:
                                catOne.GiveWater();
                                catTwo.GiveWater();
                                catThree.GiveWater();
                                Console.WriteLine(vol.WaterPets());
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine("Type the name of the pet you want to play with.");
                                Console.WriteLine(catOne.Name);
                                Console.WriteLine(catTwo.Name);
                                Console.WriteLine(catThree.Name);
                                string playPet = Console.ReadLine().ToLower();
                                if (playPet == "mittens")
                                {
                                    Console.WriteLine("You played with Mittens");
                                }
                                else if (playPet == "furball")
                                {
                                    Console.WriteLine("You played with Furball");
                                }
                                else if (playPet == "Sir Pur-a-lot")
                                {
                                    Console.WriteLine("You played with Sir Pur-a-lot");
                                }
                                Console.WriteLine("Press a key to continue.");
                                Console.ReadKey();
                                break;
                        }

                    } while (userChoice != 5);
                }
                else { Console.WriteLine("Goodbye!"); }

            } while (userChoice != 3);
        }
    }
}  

