using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_part2
{
    class FunkoPop
    {
        //defining all the variables used for the object
        private double height;
        private double width;
        private string character;
        private DateTime purchaseDate;
        private int price;
        private bool isExclusive;

        public void start()
        {
            Console.WriteLine("Welcome to the Funkopop database!");
            Console.WriteLine("Please, describe your Funkopop:");
            Console.WriteLine();

            readingFunkoData();
            writingFunkoData();
        }

        private void readingFunkoData()
        {
            funkoHeight();
            funkoWidth();
            funkoCharacter();
            funkoDate();
            funkoPrice();
            funkoExclusive();
        }

        private void writingFunkoData()
        {
            Console.WriteLine();
            Console.WriteLine("Your Funko has been succesfully added to the database with the following info:");
            Console.WriteLine();

            Console.WriteLine("Height: " + height + " cm");
            Console.WriteLine("Width: " + width + " cm");
            Console.WriteLine("Character: " + character);
            //as DateTime includes HH/MM/SS I use a ToString to only show the date.
            Console.WriteLine("Date purchased: " + purchaseDate.ToString("yyyy/MM/dd"));
            Console.WriteLine("Original price: " + price + " EUR");
            if (isExclusive)
            {
                Console.WriteLine("Your Funko is very unique!");
            }
            else
            {
                Console.WriteLine("Your Funko is really basic!");
            }
        }

        private void funkoHeight()
        {
            Console.WriteLine("Enter the height of your Funkopop (in centimeter): ");
            string heightResult = Console.ReadLine();
            //parsing the input result to a double to fit the variable datatype
            height = double.Parse(heightResult);
        }

        private void funkoWidth()
        {
            Console.WriteLine("Enter the width of your Funkopop (in centimeter): ");
            string widthResult = Console.ReadLine();
            //parsing the input result to a double to fit the variable datatype
            width = double.Parse(widthResult);
        }

        private void funkoCharacter()
        {
            Console.WriteLine("Let us know what character your Funko depicts: ");
            character = Console.ReadLine();
        }

        private void funkoDate()
        {
            Console.WriteLine("The year you bought your Funko (YYYY): ");
            //converting input result to 32-bit integer to make the input a date
            var yearResult = Convert.ToInt32(Console.ReadLine());
            //if (yearResult.ToString().Length != 4)
            Console.WriteLine("The month you bought your Funko (MM): ");
            var monthResult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The day you bought your Funko (DD): ");
            var dayResult = Convert.ToInt32(Console.ReadLine());

            //inserting the input results in a DateTime
            DateTime resultDateTime = new DateTime(yearResult, monthResult, dayResult, 0, 0, 0, 0);
            //putting our DateTime variable equal to the newly created DateTime and using the .Date method to just get the date.
            purchaseDate = resultDateTime.Date;
        }

        private void funkoPrice()
        {
            Console.WriteLine("The original price of your Funko (in EUR): ");
            string priceResult = Console.ReadLine();
            //parsing the input result to an int to fit the variable datatype
            price = int.Parse(priceResult);
        }

        private void funkoExclusive()
        {
            Console.WriteLine("Is your Funko exclusive? (y/n) ");
            string exclusiveResult = Console.ReadLine();
            //trimming user result and making it lower case
            exclusiveResult = exclusiveResult.Trim().ToLower();
            //only getting the first index for result
            char result = exclusiveResult[0];
            //setting bool value depending on user answer - true if user answers "y", else false
            if (result == 'y')
            {
                isExclusive = true;
            }
            else
            {
                isExclusive = false;
            }
        }
    }
}
