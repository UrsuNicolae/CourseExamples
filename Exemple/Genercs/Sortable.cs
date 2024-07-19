namespace Exemple.Genercs
{
    internal class Sortable
    {
        public static void SortArray<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

    public class Test : IComparable<Test>
    {
        public int Value { get; set; }

        public string ValueName { get; set; }

        public int CompareTo(Test other)
        {
            if (Value > other.Value)
            {
                return 1;
            }
            else if (Value < other.Value)
            {
                return -1;
            }
            return 0;
        }
    }
}
