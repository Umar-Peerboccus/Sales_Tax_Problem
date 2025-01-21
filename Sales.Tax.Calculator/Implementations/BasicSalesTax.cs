using Sales.Tax.Calculator.Abstractions;

namespace Sales.Tax.Calculator.Implementations;

public class BasicSalesTax : SalesTax
{
    public override double CalculateSalesTax(double price)
    {
        var salesTax = 0.1 * price;
        return RoundOff(salesTax);
    }
}
