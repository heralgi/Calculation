using System;
public class Division {
    
    public double DoDivision(double num1, double num2) {
        if (num2 == 0) {
            return double.NaN; // Return NaN to indicate an undefined result
        } else {
            double result = num1 / num2;
            return result;
        }
    }
}
