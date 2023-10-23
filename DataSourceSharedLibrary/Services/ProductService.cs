using DataSourceSharedLibrary.Models;
namespace DataSourceSharedLibrary.Services
{
    public static class ProductService
    {
        public static List<Product> Products { get; set; } = new();

        public static void AddProduct(Product model)
        {
            Products.Add(model);
        }

        public static void UpdateProduct(Product model)
        {
            var product = Products.FirstOrDefault(_ => _.Id == model.Id);
            product.Name = model.Name;
            product.Description = model.Description;
            product.Quantity = model.Quantity;
        }

        public static void DeleteProduct(int id)
        {
            Products.Remove(Products.FirstOrDefault(_ => _.Id == id)!);
        }
    }
}
