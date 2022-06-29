using System;

namespace Calculator_Project
{
    class Program
    {

        //Note: Going to use decimal as the data type

        static void Main(string[] args)
        {
            Console.WriteLine("This console app is a simple Calculator that takes two numbers and does addition, subtraction, multiplication, or division.");
            Console.WriteLine();
        
           byte run = 1;
           while(run == 1)
            {         
                Console.WriteLine("Enter 1 for Addition, 2 for Subtraction, 3 for Multiplication, or 4 for Division; then press the ENTER key.");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the first number");
                decimal userInput1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Input the second number");
                decimal userInput2 = Convert.ToDecimal(Console.ReadLine());

                CalculatorOption(userChoice, userInput1, userInput2);

                Console.WriteLine("If you want to run the Calculator again press 1 then hit the ENTER key");
                run = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
            }            
        }

        //Addtion = userchoice 1
        static decimal Addition(decimal number1, decimal number2)
        {
            decimal result = number1 + number2;
            return result;
        }

        //Subtraction = userchoice 2
        static decimal Subtraction(decimal number1, decimal number2)
        {
            decimal result = number1 - number2;
            return result;
        }

        //Multiplication = userchoice 3
        static decimal Multiplicaiton(decimal number1, decimal number2)
        {
            decimal result = number1 * number2;
            return result;
        }

        //Addtion = userchoice 4
        static decimal Division(decimal number1, decimal number2)
        {
            decimal result = number1 / number2;
            return result;
        }

        //Runs through the 4 modes of the calculator and outputs the result
        static void CalculatorOption(int userChoice, decimal userInput1, decimal userInput2)
        {
            if (userChoice == 1)
            {
                Console.WriteLine();
                Console.WriteLine(userInput1 + " + " + userInput2 + " = " + Addition(userInput1, userInput2));
            }
            else if (userChoice == 2)
            {
                Console.WriteLine();
                Console.WriteLine(userInput1 + " - " + userInput2 + " = " + Subtraction(userInput1, userInput2));
            }
            else if (userChoice == 3)
            {
                Console.WriteLine();
                Console.WriteLine(userInput1 + " * " + userInput2 + " = " + Multiplicaiton(userInput1, userInput2));
            }
            else if (userChoice == 4)
            {
                Console.WriteLine();
                Console.WriteLine(userInput1 + " / " + userInput2 + " = " + Division(userInput1, userInput2));
            }
        }
    }
    
}

