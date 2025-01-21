namespace Sales.Tax.Calculator.Implementations;
using Sales.Tax.Calculator.Abstractions;

public class ImportedSalesTax : SalesTax
{
    public override double CalculateSalesTax(double price)
    {
        var salesTax =  0.05 * price;
        return RoundOff(salesTax);
    }
}
