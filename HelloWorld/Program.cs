using System;

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

            Console.WriteLine(lowwerCaseMessage + myname);
            Console.Read();
        }
    }
}
