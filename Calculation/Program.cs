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
    }
}
