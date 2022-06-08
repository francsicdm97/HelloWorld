using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            //Declare variables
            string myname = "Francis";
            string message = "My name is ";
            
            //convert message to upper case
            string capsMessage = message.ToUpper();
            //convert message to lower case
            string lowwerCaseMessage = message.ToLower();

            //change console foreground color to blue
            Console.ForegroundColor = ConsoleColor.Yellow;
            //change background color of console
            Console.BackgroundColor = ConsoleColor.Blue;
            //console.Clear();
            

            //write to console the message in lower case followed by my name
            Console.WriteLine(lowwerCaseMessage + myname);

            //take value from console line
            string consoleInput = Console.ReadLine().ToString();

            //convert console input to upper
            string capsConsoleInput = consoleInput.ToUpper();

            //print result in console
            Console.WriteLine("Output {0}", capsConsoleInput);
            Console.ReadKey();

           
        }
    }
}
