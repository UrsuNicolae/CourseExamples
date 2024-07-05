namespace Exemple.ClassAndObject
{
    public class Counter
    {
        private static int _count = 0;
        public Counter()
        {
            _count++;
        }

        public void DisplayCount()
        {
            Console.WriteLine($"Count is: {_count}");
        }
    }
}
