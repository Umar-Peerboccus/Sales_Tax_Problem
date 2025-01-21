namespace Sales.Tax.Calculator.Implementations;

using Sales.Tax.Calculator.Abstractions;
using Sales.Tax.Products.Abstractions;
using System.Collections.Generic;

public class SalesTaxContext : ISalesTaxContext
{
    private SalesTax? _salesTax;
    private double NO_SALES_TAX = 0.00;

    public IList<Product> SetSalesTaxType(IList<Product> productsList)
    {
        foreach (var product in productsList)
        {
            switch (product.ProductType)
            {
                case Products.Model.ProductKind.Others:
                    _salesTax = product.IsImported ? new BasicImportedSalesTax() : new BasicSalesTax();
                    break;

                default:
                    _salesTax = product.IsImported ? new ImportedSalesTax() : null;
                    break;
            }
                
            var salesTaxAmount = _salesTax is not null ? _salesTax.CalculateSalesTax(product.Price) : NO_SALES_TAX;
            product.SalesTaxAmount = salesTaxAmount;
            product.Price += salesTaxAmount;
        }

        return productsList;
    }
}