using System.Data.Common;

namespace Exemple.ClassAndObject
{
    public class Inverntory
    {
        private List<Product> products;

        public Inverntory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public Product this[int index]
        {
            get
            {
                if(index >= 0  && index <  products.Count)
                {
                    return products[index];
                }else
                {
                    throw new IndexOutOfRangeException();
                }
                
            }
        }

    }

    public class Product
    {
        private string nume;
        private double greutate;

        public Product() { }

        public Product(string nume, double greutate)
        {
            this.nume = nume;
            this.greutate = greutate;
        }

        public string GetProductName()
        {
            return nume;
        }
    }
}
