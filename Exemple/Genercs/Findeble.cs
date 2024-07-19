

namespace Exemple.Genercs
{
    internal class Findeble
    {
        public static T FindItem<T>(T[] array, Func<T, bool> predicat)
        {
            return array.FirstOrDefault(item => predicat(item));
        }
    }
}
