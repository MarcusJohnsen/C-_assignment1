using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_part1
{
    class Pet
    {
        //defining all the variables used for the object
        private string name;
        private int age;
        private bool female;

        public void start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from MyPet class");
            Console.WriteLine();

            readingPetData();
            writingPetData();
        }

        private void readingPetData()
        {
            petName();
            petAge();
            petGender();
        }

        private void writingPetData()
        {
            //making it look as wanted in the assignment
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            if (female)
            {
                Console.WriteLine(name + " is a good girl");
            }
            else
            {
                Console.WriteLine(name + " is a good boy");
            }

            //making it look as wanted in the assignment
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        private void petName()
        {
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();
        }
        private void petAge()
        {
            Console.WriteLine("What is " + name + "'s age?");
            string ageValue = Console.ReadLine();
            //parsing the input result to an int to fit the variable datatype
            age = int.Parse(ageValue);
            // Missing: error handling for invalid input
        }
        private void petGender()
        {
            Console.WriteLine("Is your pet a female (y/n)?");
            string genderResult = Console.ReadLine();
            //trimming user result and making it lower case
            genderResult = genderResult.Trim().ToLower();
            //only getting the first index for result
            char result = genderResult[0];
            //setting bool value depending on user answer - true if user answers "y", else false
            if (result == 'y')
                female = true;
            else
                female = false;
        }
    }
}