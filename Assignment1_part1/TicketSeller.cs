using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_part1
{
    class TicketSeller
    {
        //defining all the variables used for the object
        private string name;
        private double price = 100.00;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public void start()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children always get a 75% discount!");
            Console.WriteLine();

            readingBuyerData();
            writingBuyerData();
        }

        private void readingBuyerData()
        {
            buyerName();
            amountOfAdults();
            amountOfChildren();
            paymentAmount();
        }

        private void writingBuyerData()
        {
            //making it look as wanted in the assignment
            Console.WriteLine();
            Console.WriteLine(" +++ Your receipt +++");
            Console.WriteLine(" +++ Amount to pay = " + amountToPay);
            Console.WriteLine();

            Console.WriteLine(" +++ Thank you " + name + " and please come back! +++");
        }


        private void buyerName()
        {
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
        }

        private void amountOfAdults()
        {
            Console.WriteLine("Number of adults:");
            string numOfAdultsValue = Console.ReadLine();
            //parsing the input result to an int to fit the variable datatype
            numOfAdults = int.Parse(numOfAdultsValue);
        }

        private void amountOfChildren()
        {
            Console.WriteLine("Number of children:");
            string numOfChildrenValue = Console.ReadLine();
            //parsing the input result to an int to fit the variable datatype
            numOfChildren = int.Parse(numOfChildrenValue);
        }

        private void paymentAmount()
        {
            //doing math for ticket price. We know the set price for adults and that children pay only 25% of that
            amountToPay = (numOfAdults * price) + (numOfChildren * (price * 0.25));
        }
    }
}
