using System;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Console.WriteLine("Addition {0}", addition.DoAddition(5, 10));

            Substraction substraction = new Substraction();
            Console.WriteLine("Substraction:{0}", substraction.DoSubstraction(10, 5));
           

            Multiplication multiplication = new Multiplication();
            Console.WriteLine("Multiplication: {0}",multiplication.DoMultiply(5, 10));

            Division division = new Division();
            Console.WriteLine("Division: {0}", division.DoDivision(5, 10));
        }

       
        public class Substraction
        {
            public int SubstractionOutput = 0;

            public int DoSubstraction(int input1, int input2)
            {
                SubstractionOutput = input1 - input2;
                return SubstractionOutput;
            }
        }

    }
}
