using TestWork.DTOs;
using TestWork.Models;

namespace TestWork.Extensions;

public static class ProductExtensions
{
    public static void Update(this Product product, ProductDto productDto)
    {
        product.Title = productDto.Title;
        product.Description = productDto.Description;
        product.Price = productDto.Price.GetValueOrDefault();
        product.Stock = productDto.Stock.GetValueOrDefault();
    } 
}