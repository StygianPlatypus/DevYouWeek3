using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            Console.WriteLine("Pick any number from 1 to 12.\r\nTo quit program, type 'quit'.") ;
            string input = Console.ReadLine();

            switch (input)
            {
                case "quit":
                    goto End;                    
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                    goto Months;                                
                default:
                    Console.WriteLine("Please enter a valid input. Number entered must be a whole number between 1 and 12.");
                    goto Start;
                    
            }                

            Months:                      

            switch (input)
            {
                case "1":
                    Console.WriteLine("The first month is January.");
                    break;
                case "2":
                    Console.WriteLine("The second month is February.");
                    break;
                case "3":
                    Console.WriteLine("The third month is March.");
                    break;
                case "4":
                    Console.WriteLine("The fourth month is April.");
                    break;
                case "5":
                    Console.WriteLine("The fifth month is May.");
                    break;
                case "6":
                    Console.WriteLine("The sixth month is June.");
                    break;
                case "7":
                    Console.WriteLine("The seventh month is July.");
                    break;
                case "8":
                    Console.WriteLine("The eigth month is August.");
                    break;
                case "9":
                    Console.WriteLine("The ninth month is September.");
                    break;
                case "10":
                    Console.WriteLine("The tenth month is October.");
                    break;
                case "11":
                    Console.WriteLine("The eleventh month is November.");
                    break;
                case "12":
                    Console.WriteLine("The twelfth month is December.");
                    break;
            }

            goto Start;

        End:

            Console.WriteLine("Thanks for using this program.");

           


            
        }
    }
}
