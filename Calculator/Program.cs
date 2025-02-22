using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        

        static void Main(string[] args) //Main method runs as soon as the program is executed
        {
            int num1;
            int num2;
            int result = 0;

            string userInput;


            Console.WriteLine("Hello, welcome to the calculator program!");

            Console.Write("Please enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(num1);

            Console.Write("Please enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Enter A for addition, S for subtraction, M for multiplication or D for division");

            userInput= Console.ReadLine().ToUpper();

            if (userInput == "A")
            {
                result = num1+ num2;
            }
            else if (userInput == "S")
            {
                result = num1 - num2;
            }
            else if (userInput == "M")
            {
                result = num1 * num2;
            }
            else if(userInput == "D")
            {
                result = num1 / num2;
            }

            Console.WriteLine($"The result is: {result}");
            Console.Write("Thank you for using the calculator");



            Console.ReadLine();
        }

    
    }
}
