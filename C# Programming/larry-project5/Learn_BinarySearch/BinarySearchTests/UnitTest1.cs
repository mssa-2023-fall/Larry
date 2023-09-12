using Learn_BinarySearch;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTest
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearch_FoundElement_ReturnsCorrectIndex()
        {

            // Arrange
            int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 12;

            // Act
            int result = Searching.BinarySearch(sortedArray, target);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void BinarySearch_ElementNotFound_ReturnsMinusOne()
        {
            // Arrange
            int[] sortedArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 15;

            // Act
            int result = Searching.BinarySearch(sortedArray, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_EmptyArray_ReturnsMinusOne()
        {
            // Arrange
            int[] sortedArray = new int[] { };
            int target = 5;

            // Act
            int result = Searching.BinarySearch(sortedArray, target);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BinarySearch_FirstElement_ReturnsZero()
        {
            // Arrange
            int[] sortedArray = { 2, 4, 6, 8, 10 };
            int target = 2;

            // Act
            int result = Searching.BinarySearch(sortedArray, target);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}