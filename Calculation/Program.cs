using System;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            addition.DoAddition(5, 10);

            Substraction substraction = new Substraction();
            substraction.DoSubstraction(10, 5);
           

            Multiplication multiplication = new Multiplication();
            multiplication.DoMultiplication(5, 10);

            Division division = new Division();
            division.DoDivision(5, 10);
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
