namespace Exemple.UTs
{
    public interface IFileReader
    {
        string ReadFile(string filePath);
    }


    public class FileProcessor
    {
        private IFileReader _fileReader;


        public FileProcessor(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }


        public int CountLinesInFile(string filePath)
        {
            try
            {
                Console.WriteLine(filePath);
                var fileContent = _fileReader.ReadFile(filePath);
                if (string.IsNullOrEmpty(fileContent))
                {
                    return 0;
                }

                return fileContent.Split('\n').Length;
            }
            catch (FileNotFoundException)
            {
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
