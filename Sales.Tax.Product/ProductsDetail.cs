namespace Sales.Tax.Products;

using Sales.Tax.Products.Abstractions;
using System.Collections.Generic;
using System.Text;

public class ProductsDetail : IProductsDetail
{
    public IList<Product> ProductList { get; set; } = [];

    private double _totalSalesTax { get; set; }

    private double _totalPrice { get; set; }

    private void setTotalSalesTax()
    {
        _totalSalesTax = ProductList.Select(p => p.SalesTaxAmount).Sum();
    }
    private void setTotalPrice()
    {
        _totalPrice = ProductList.Select(p => p.Price).Sum();
    }
    
    public string DisplayProducts()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Payment Receipt:");
        foreach (var product in ProductList)
        {
            sb.AppendLine($"{product.Quantity} {product.Name}: {product.Price}");
        }

        setTotalSalesTax();
        sb.AppendLine($"Total Sales Taxes: {_totalSalesTax}");

        setTotalPrice();
        sb.AppendLine($"Total Price: {_totalPrice}");

        return sb.ToString();
    }
}
