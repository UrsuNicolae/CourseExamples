namespace Exemple.Polimorifism
{
    public class GenericLogger<T>
    {
        public void Log(T data)
        {
            Console.WriteLine($"[LOG] {data}");
        }

        public void Log(string data)
        {
            Console.WriteLine($"[LOG] string value: {data}");
        }
    }
}
