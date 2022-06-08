using System;

namespace HelloWorld
{
    internal class Program
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            string myname = "Francis";
            string message = "My name is ";

            string capsMessage = message.ToUpper();

            string  lowwerCaseMessage = message.ToLower();

            Console.WriteLine(lowwerCaseMessage + myname);
            Console.Read();
        }
    }
}
