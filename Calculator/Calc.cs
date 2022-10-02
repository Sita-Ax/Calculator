using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator
{
    public class Calc
    {
       
        public Calc() { }

        public static double Addition(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }

        public double Addition(double[] numArray)
        {
            double sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }
            return sum;
        }

        public static double Subtraction(double num1, double num2)
        {
            double sum = num1 - num2;
            return sum;
        }

        public double Subtraction(double[] numArray)
        {
            double sum = numArray[0];
            for (int i = 1; i < numArray.Length; i++)
            {
                sum -= numArray[i];
            }
            return sum;
        }

        public static double Multiplication(double num1, double num2)
        {
            double sum = num1 * num2;
            return sum;
        }

        //Method that gets input from InputNumbers and call method Multi in th class Calculator and returns the result.
        public double Multiplication(double[] number)
        {
            double sum = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                sum *= number[i];
            }
            return sum;
        }

        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not possible.");
            }
            return num1 / num2;
        }

        //Method that gets input from InputNumbers and call method Div in th class Calculator and returns the result.
        // It handles exeptions that can be thrown in the Calculator class.
        public double Division(double[] number)
        {
            try
            {
                double sum = number[0];
                for (int i = 0; i < number.Length; i++)
                {

                    sum = sum / number[i];
                }
            }
            catch (DivideByZeroException)
            {
                return 0.0f;
            }
            return number[0];
        }
        public static double[] InputNumber(string number1, string number2)
        {
            double num1, num2;
            if (string.IsNullOrEmpty(number1))
            {
                return new double[0];
            }
            if (string.IsNullOrEmpty(number2))
            {
                return new double[0];
            }
            num1 = Convert.ToDouble(number1);
            num2 = Convert.ToDouble(number2);

            return new double[] { num1, num2 };
        }

      
    }
}
