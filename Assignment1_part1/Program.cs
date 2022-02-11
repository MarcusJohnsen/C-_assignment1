using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining console look
            PrepareConsolesLook();

            //instantiating Pet object and running start method
            Pet pet = new Pet();
            pet.start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            //instantiating TicketSeller class and running start method
            TicketSeller ticketseller = new TicketSeller();
            ticketseller.start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            //instantiating Album class and running start method
            Album album = new Album();
            album.start();
        }

        //defining the console look
        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }
    }
}