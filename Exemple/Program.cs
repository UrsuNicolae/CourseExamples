using Exemple.ClassMembers;
using Exemple.Polimorifism;
using System.Runtime.CompilerServices;

namespace Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intLogger = new GenericLogger<int>();
            intLogger.Log(12);

            var dateTimeLogger = new GenericLogger<DateTime>();
            dateTimeLogger.Log(DateTime.UtcNow);

            var stringLogger = new GenericLogger<string>();
            stringLogger.Log("test");
        }
    }
}
