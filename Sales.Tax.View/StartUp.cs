namespace Sales.Tax.View;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sales.Tax.Calculator.Abstractions;
using Sales.Tax.Products.Abstractions;
using Sales.Tax.Products.Implementation;

public class StartUp : BackgroundService
{
    private readonly ILogger<StartUp> _logger;
    private IProductFactory _bookProductFactory;
    private IProductFactory _foodProductFactory;
    private IProductFactory _otherProductFactory;
    private ISalesTaxContext _salesTaxContext;
    private IProductsDetail _productsDetail;

    public StartUp(ILoggerFactory loggerFactory, ISalesTaxContext salesTaxContext, IProductsDetail productsDetail)
    {
        _logger = loggerFactory.CreateLogger<StartUp>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        _bookProductFactory = new BookProductFactory();
        _foodProductFactory = new FoodProductFactory();
        _otherProductFactory = new OtherProductFactory();
        _salesTaxContext = salesTaxContext;
        _productsDetail = productsDetail;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Starting Sales Tax View...");
        CreateProducts();
        SetSalesTaxType();
        var products = _productsDetail.DisplayProducts();

        Console.WriteLine(products);
    }

    private void CreateProducts()
    {
        _logger.LogInformation("Creating products...");

        // Create a list of products
        var book = _bookProductFactory.CreateProduct("Book", 1, false, 12.49);
        _productsDetail.ProductList.Add(book);

        var food = _foodProductFactory.CreateProduct("Chocolate bar", 1, true, 0.85);
        _productsDetail.ProductList.Add(food);

        var other = _otherProductFactory.CreateProduct("Music CD", 1, false, 14.99);
        _productsDetail.ProductList.Add(other);
    }

    private void SetSalesTaxType()
    {
        _salesTaxContext.SetSalesTaxType(_productsDetail.ProductList);
    }
}