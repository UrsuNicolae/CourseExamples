using Exemple.Delegates;

namespace Exemple
{
    internal class Program
    {
        public static bool StartWithLetter(string srt, char letter)
        {
            return srt.StartsWith(letter);
            //return srt[0] == letter;
        }

        static void Main(string[] args)
        {
            Predicate<string> startWith = x => x.Length > 3;
            Func<string, bool> startWithFunc = x => x.Length > 3;
            var test ="gello";

            var strings = new List<string>() { "hello", "world", "foo", "bar" };
            var strings1 = strings.RemoveAll(x =>
            {
                var result = x.Length > 3;
                if (result)
                {
                    Console.WriteLine(x);
                }
                return result;
            });
            /*StringFilterClass.StringFilter startWith = str => StringFilterClass.StartWithLetter(str, 'h');
            StringFilterClass.StringFilter contains = str => StringFilterClass.ContainsSubString(str, "o");
            StringFilterClass.StringFilter longerThan = str => StringFilterClass.IsLongerThan(str, 3);

            var filterdStrings  = StringFilterClass.FilterStrings(strings, new List<StringFilterClass.StringFilter> { startWith, contains, longerThan});*/
        }
    }
}
