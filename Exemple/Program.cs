using Exemple.ClassMembers;
using Exemple.Encapsulation;
using System.Runtime.CompilerServices;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lib = new Library("MyLibrary");
            lib.AddBook("The Hobbit");
            lib.AddBook("The Hobbit");
            lib.AddBook("The Hobbit");
            lib.Name = "Test library";
            lib.DisplayLibraryInfo();
        }
    }
}
