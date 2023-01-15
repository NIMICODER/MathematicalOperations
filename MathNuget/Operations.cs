using System;

namespace MathNuget
{
    public class Operations
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Division(int num1, int num2)
        {
            return (num1 / num2);
        }

        public int Multiplication(int num1, int num2)
        {
            return (num1 * num2);
        }
        //Complex Operations
        public double RaiseToPower(double num, int power)
        {
            return Math.Pow(num, power);
        }

        public double Square(double num)
        {
            return Math.Pow(num, 2);
        }


        public double Hypotenuse(double num1, double num2)
        {
            return Math.Sqrt(Math.Pow(num1, 2) + Math.Pow(num2, 2));
        }




    }
}
