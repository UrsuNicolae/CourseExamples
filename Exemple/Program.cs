using Exemple.Genercs;

namespace Exemple
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            var testArray = new Test[]
            {
                new Test{Value = 1, ValueName = "one"},
                new Test{Value = 2, ValueName = "two"},
                new Test{Value = 3, ValueName = "thre"},
                new Test{Value = 4, ValueName = "four"},
                new Test{Value = 5, ValueName = "one"},
            };

            var item = Findeble.FindItem<Test>(testArray, x => x.ValueName == "one");
            Console.WriteLine(item);
        }
    }
}
