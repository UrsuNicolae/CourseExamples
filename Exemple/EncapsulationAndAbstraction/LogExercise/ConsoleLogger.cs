using Exemple.EncapsulationAndAbstraction.Log;

namespace Exemple.EncapsulationAndAbstraction.LogExercise
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"Error: {message}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"Warning: {message}");
        }
    }
}
