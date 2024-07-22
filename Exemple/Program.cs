using Exemple.Genercs;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var dictionary = new PhoneDictionary();
            dictionary.Add("John", "123456789");
            dictionary.Add("Nick", "123122222");
            dictionary.Add("Tom", "123456789");
            dictionary.Add("John", "123123");


            Console.WriteLine(dictionary);


            dictionary.RemovePhone("Tom", "123456789");
            dictionary.Remove("John");
            Console.WriteLine(dictionary);
        }
    }
}
