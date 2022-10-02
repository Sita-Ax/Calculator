using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    public class Calculator
    {
        public void Start()
        {
            MainMenu();
        }
        double num1, num2;

        private void MainMenu()
        {
            bool choice = true;

            do
            {
                Console.Clear();
                Menu();
                int calculatorChoice = Convert.ToInt32(Console.ReadLine());
                double sum = 0;

                switch (calculatorChoice)
                {
                    case 1:
                        {
                            calculatorChoice = 1;
                            num1 = (double)InputNumber();
                            num2 = (double)InputNumber();
                            sum = Calc.Addition(num1, num2);
                            Console.WriteLine(sum + " is the sum of this addition " + num1 + " + " + num2);
                            break;
                        }
                    case 2:
                        {
                            calculatorChoice = 2;
                            num1 = (double)InputNumber();
                            num2 = (double)InputNumber();
                            sum = Calc.Subtraction(num1, num2);
                            Console.WriteLine(sum + " is the sum of this subtraction " + num1 + " - " + num2);
                            break;
                        }
                    case 3:
                        {
                            calculatorChoice = 3;
                            num1 = (double)InputNumber();
                            num2 = (double)InputNumber();
                            sum = Calc.Multiplication(num1, num2);
                            Console.WriteLine(sum + " is the sum of this multiplication " + num1 + " * " + num2);
                            break;
                        }
                    case 4:
                        {
                            calculatorChoice = 4;
                            num1 = (double)InputNumber();
                            num2 = (double)InputNumber();
                            sum = Calc.Division(num1, num2);
                            Console.WriteLine(sum + " is the sum of this division " + num1 + " / " + num2);
                            break;
                        }
                    case 9:
                        {
                            calculatorChoice = 9;
                            Console.WriteLine("Exit this calculator!");
                            choice = false;
                            Console.ReadKey();
                            break;
                        }
                    default:
                        Console.WriteLine("That was not a vaild option!");
                        break;
                }
                Console.ReadKey();
                MainMenu();
            } while (choice);
        }

        private static void Menu()
        {
            Console.WriteLine("-----Calculator Menu------");
            Console.WriteLine("Choice what mathematical operation you want to preform: ");
            Console.WriteLine("1. Addition.");
            Console.WriteLine("2. Subtraction.");
            Console.WriteLine("3. Multiplcation.");
            Console.WriteLine("4. Divide.");
            Console.WriteLine("9. Exit");
        }
        public static double? InputNumber()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                string? input = Console.ReadLine();
                double? number = double.Parse(input);
                return number;
            }
            catch (FormatException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
