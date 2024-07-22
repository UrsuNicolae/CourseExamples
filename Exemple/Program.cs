using Exemple.Genercs;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var productRepository = new ProductRepository();
            productRepository.Add(new Product(1, "Laptop", 1500, ProductCategory.Electronics));
            productRepository.Add(new Product(2, "T-shirt", 20, ProductCategory.Clothing));
            productRepository.Add(new Product(3, "Apple", 2, ProductCategory.Food));

            var product = productRepository.GetProductByCategory(ProductCategory.Electronics);
            Console.WriteLine(product);
            productRepository.Remove(product);
            product = productRepository.GetProductByCategory(ProductCategory.Electronics);
            Console.WriteLine(product);
        }
    }
}
