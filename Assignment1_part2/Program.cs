using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining console look
            PrepareConsolesLook();

            //instantiating FunkoPop object and running start method
            FunkoPop funko = new FunkoPop();
            funko.start();
        }

        //defining the console look
        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "FUNKOPOP DATABASE";
        }
    }
}