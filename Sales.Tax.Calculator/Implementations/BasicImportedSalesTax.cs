using Sales.Tax.Calculator.Abstractions;

namespace Sales.Tax.Calculator.Implementations;

public class BasicImportedSalesTax : SalesTax
{
    public override double CalculateSalesTax(double price)
    {
        var salesTax = 0.15 * price;
        return RoundOff(salesTax);
    }
}
