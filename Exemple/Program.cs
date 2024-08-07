using Exemple.Delegates;

namespace Exemple
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var strings = new List<string>() { "hello", "world", "foo", "bar" };
            StringFilterClass.StringFilter startWith = str => StringFilterClass.StartWithLetter(str, 'h');
            StringFilterClass.StringFilter contains = str => StringFilterClass.ContainsSubString(str, "o");
            StringFilterClass.StringFilter longerThan = str => StringFilterClass.IsLongerThan(str, 3);

            var filterdStrings  = StringFilterClass.FilterStrings(strings, new List<StringFilterClass.StringFilter> { startWith, contains, longerThan});
        }
    }
}
