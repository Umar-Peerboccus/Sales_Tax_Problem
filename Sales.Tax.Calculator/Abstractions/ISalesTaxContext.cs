namespace Sales.Tax.Calculator.Abstractions;

public interface ISalesTaxContext
{
    public IList<Products.Abstractions.Product> SetSalesTaxType(IList<Products.Abstractions.Product> productsList);
}