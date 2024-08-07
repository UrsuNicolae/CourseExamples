namespace Exemple.Delegates
{
    public class StringFilterClass
    {
        public delegate bool StringFilter(string str);

        public static bool StartWithLetter(string srt, char letter)
        {
            return srt.StartsWith(letter);
            //return srt[0] == letter;
        }

        public static bool ContainsSubString(string srt, string subString)
        {
            return srt.Contains(subString);
        }

        public static bool IsLongerThan(string srt, int length)
        {
            return srt.Length > length;
        }

        public static List<string> FilterStrings(List<string> strings, StringFilter filter)
        {
            var result = new List<string>();
            foreach (var s in strings)
            {
                if (filter(s))
                {
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<string> FilterStrings(List<string> strings, List<StringFilter> filters)
        {
            var result = strings;
            foreach (var s in strings)
            {
                foreach (var filter in filters)
                {
                    if (!filter(s))
                    {
                        result.Remove(s);
                    }
                }
            }
            return result;
        }
    }
}
