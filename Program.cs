using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("Enter number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What operation would you like to perform? (+, -, /, *)");
                string operation = Console.ReadLine();
                Console.WriteLine("Enter nummber:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine(result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine(result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Sorry, I don't know that input");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Would you like to try another operation? (yes/no)");
                value = Console.ReadLine();



            }
            while (value == "yes");

            if (value == "no")
            {
                Console.WriteLine("Goodbye!");
            }
 

        }
    }
}
