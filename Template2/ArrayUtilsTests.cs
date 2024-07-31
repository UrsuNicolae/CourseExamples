using Exemple.UTs;

namespace Template2
{
    public class ArrayUtilsTests
    {
        [Theory]
        [InlineData(6, new int[]{1, 2, 3})]
        [InlineData(0, new int[] { 1, -1, 0 })]
        [InlineData(1, new int[] { 1, -1, 1 })]
        public void ArrayUtils_Sum_ShouldReturn_Sum_Of_Array_Items(int expectedSum, int[] items)
        {
            // Arrange


            // Act
            int result = ArrayUtils1.Sum(items);

            // Assert
            Assert.Equal(expectedSum, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, -1, 0 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, -1, 1 })]
        public void ArrayUtils_Merge_ShouldReturn_Merge_Of_Two_Arrays(int[] firstArray, int[] secondArray)
        {
            // Arrange


            // Act
            var result = ArrayUtils1.MergeArrays(firstArray, secondArray);

            // Assert
            Assert.True(result.Count() == firstArray.Count() + secondArray.Count());
            Assert.True(result.Contains(firstArray[0]));
            Assert.True(result.Contains(firstArray[1]));
            Assert.True(result.Contains(firstArray[2]));
            Assert.True(result.Contains(secondArray[2]));
        }
    }
}