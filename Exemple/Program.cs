using Exemple.Genercs;

namespace Exemple
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            var array = new Test[]
            {
                new Test { Value = 3, ValueName = "Three" },
                new Test { Value = 1, ValueName = "One" },
                new Test { Value = 2, ValueName = "Two" }
            };

            Sortable.SortArray(array);

            foreach (var item in array)
            {
                Console.WriteLine($"{item.Value} - {item.ValueName}");
            }
        }
    }
}
