using System;
using System.Collections.Generic;
using System.Text;

namespace class_exercise
{
    public static class Calculator
    {
        public static double result;

        //Test
        public static double Addition(double number1, double number2)
        {
            double tempResult = number1 + number2;

            return tempResult;
        }
        
        //Test2
        public static double Addition(double number)
        {
            result += number;
            return result;
        }

        public static double Subtraction(double number1, double number2)
        {
            double tempResult = number1 - number2;

            return tempResult;
        }

        public static double Subtraction(double number)
        {
            result -= number;
            return result;
        }

        public static double Multiplication(double number1, double number2)
        {
            double tempResult = number1 * number2;

            return tempResult;
        }

        public static double Multiplication(double number)
        {
            result *= number;
            return result;
        }

        public static double Division(double number1, double number2)
        {
            double tempResult = number1 / number2;

            return tempResult;
        }

        public static double Division(double number)
        {
            result /= number;
            return result;
        }
    }
}
