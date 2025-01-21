using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sales.Tax.Calculator.Abstractions;

public abstract class SalesTax
{
    public double RoundOff(double salesTax)
    {
        return Math.Ceiling(salesTax / 0.05) * 0.05;
    }
    public abstract double CalculateSalesTax(double price);

}
