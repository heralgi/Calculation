public class Division {
    
    public void DoDivision(double num1, double num2) {
        if (num2 == 0) {
            System.out.println("Error: Cannot divide by zero.");
        } else {
            double result = num1 / num2;
            System.out.println("Result: " + result);
        }
    }
}
