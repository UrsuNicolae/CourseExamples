using Exemple.EncapsulationAndAbstraction.Log;

namespace Exemple.EncapsulationAndAbstraction.LogExercise
{
    public class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        public void LogError(string message)
        {
            WriteToFile("Error: " + message);
        }

        public void LogInformation(string message)
        {
            WriteToFile("Info: " + message);
        }

        public void LogWarning(string message)
        {
            WriteToFile("Warning: " + message);
        }

        private void WriteToFile(string message)
        {
            using(StreamWriter sw = new StreamWriter(_filePath, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}
