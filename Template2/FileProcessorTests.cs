namespace Template2
{
    public class FileProcessorTests
    {
        [Fact]
        public void FileProcessorShouldReturnNumberOfLinesInFile()
        {
            // Arrange
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadFile("file.txt")).Returns("line1\nline2\nline3");
            var fileProcessor = new FileProcessor(fileReader.Object);

            // Act
            var numberOfLines = fileProcessor.CountLinesInFile("file.txt");

            // Assert
            Assert.Equal(3, numberOfLines);
        }

        [Fact]
        public void FileProcessorShouldReturnZeroWhenFileIsEmpty()
        {
            // Arrange
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadFile("file.txt")).Returns("");
            var fileProcessor = new FileProcessor(fileReader.Object);

            // Act
            var numberOfLines = fileProcessor.CountLinesInFile("file.txt");

            // Assert
            Assert.Equal(0, numberOfLines);
        }

        [Fact]
        public void FileProcessorShouldReturnZeroWhenFileDoesNotExist()
        {
            // Arrange
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadFile("file.txt")).Throws(new FileNotFoundException());
            var fileProcessor = new FileProcessor(fileReader.Object);

            // Act
            var numberOfLines = fileProcessor.CountLinesInFile("file.txt");

            // Assert
            Assert.Equal(0, numberOfLines);
        }

        [Fact]
        public void FileProcessorShouldReturnZeroWhenFileReaderThrowsException()
        {
            // Arrange
            var fileReader = new Mock<IFileReader>();
            fileReader.Setup(x => x.ReadFile("file.txt")).Throws(new Exception());
            var fileProcessor = new FileProcessor(fileReader.Object);

            // Act
            var numberOfLines = fileProcessor.CountLinesInFile("file.txt");

            // Assert
            Assert.Equal(0, numberOfLines);
        }
    }
}
