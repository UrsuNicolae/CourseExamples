using Exemple.Genercs;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var store = new EntityRepository<StoreCustomer, int>();
            store.Create(new StoreCustomer(1, "John"));
            store.Create(new StoreCustomer(2, "Doe"));
            store.Read(1);

            var store2 = new EntityRepository<StoreProduct<char>, char>();
            store2.Create(new StoreProduct<char>('1', "Product 1"));
            store2.Create(new StoreProduct<char>('2', "Product 2"));
            store2.Read('2');
        }
    }
}
