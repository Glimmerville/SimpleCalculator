using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 0;
            string doAgain = "Y";
            Console.WriteLine("This is the Semi-Amazing C# Calculator of Calculating Math Calculations!");
            while (doAgain == "Y" || doAgain == "y")
                {
                Console.WriteLine("Enter a number, and a math function, and an operand.");
                Console.WriteLine("First number:");
                //get a number convert to int
                double firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Math function: (+, -, *, /, %, ^)");
                string mathSym = Console.ReadLine();
                //get a math function which we will define
                Console.WriteLine("Second number:");
                //get the second number and convert to int
                double secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine("OK got it: " + firstNum + " " + mathSym + " " + secondNum);//checking
                switch (mathSym)
                {
                    case "+":
                        answer = firstNum + secondNum;
                        Console.WriteLine("Your answer is " + answer);
                        break;
                    case "-":
                        answer = firstNum - secondNum;
                        Console.WriteLine("Your answer is " + answer);
                        break;
                    case "*":
                        answer = firstNum * secondNum;
                        Console.WriteLine("Your answer is " + answer);
                        break;
                    case "/":
                        answer = firstNum / secondNum;
                        Console.WriteLine("Your answer is " + answer);
                        break;
                    case "^":
                        answer = Math.Pow(firstNum, secondNum);
                        Console.WriteLine("Your answer is " + answer);
                        break;
                    case "%":
                        answer = firstNum % secondNum;
                        Console.WriteLine("Your answer is " + answer);
                        break;
                    default:
                        Console.WriteLine("That is not a valid input");
                        break;
                }
                Console.WriteLine("Do you want to math again?");
                doAgain = Console.ReadLine();
            }
        }
    }
}
