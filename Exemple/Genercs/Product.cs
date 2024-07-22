namespace Exemple.Genercs
{
    public enum ProductCategory
    {
        Electronics,
        Clothing,
        Food
    }

    public class Product
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public  decimal Price { get; private set; }

        public ProductCategory Category { get; private set; }

        public Product(int id, string name, decimal price, ProductCategory category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Price: " + Price + " Category: " + Category;
        }
    }

    public abstract class Repository<T>
    {
        internal List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public abstract T? GetProductByCategory(ProductCategory category);
    }


    public class ProductRepository: Repository<Product>
    {
        public override Product? GetProductByCategory(ProductCategory category)
        {
            return _items.FirstOrDefault(p => p.Category == category);
        }
    }
}
