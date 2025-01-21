namespace Sales.Tax.View;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sales.Tax.Calculator.Abstractions;
using Sales.Tax.Calculator.Implementations;
using Sales.Tax.Products;
using Sales.Tax.Products.Abstractions;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddSingleton<IHostedService, StartUp>();
                services.AddScoped<ISalesTaxContext, SalesTaxContext>();
                services.AddScoped<IProductsDetail, ProductsDetail>();  
            });

        await builder.RunConsoleAsync();
    }
}
