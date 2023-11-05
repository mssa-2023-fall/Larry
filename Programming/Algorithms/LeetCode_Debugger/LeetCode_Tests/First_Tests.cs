namespace LeetCode_Tests
{
    public class MergeSortedArrayTests
    {
        [Fact]
        public void Merge_WithNonDecreasingOrder_ReturnsMergedArray()
        {
            //Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            //Act
            MergeSortedArray.Merge(nums1, m, nums2, n);

            //Assert
            Assert.Equal(expected, nums1);

        }
        [Fact]
        public void Merge_WithNonDecreasingOrder_DoesNotReturnMergedArray2()
        {
            //Arrange
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 0 };
            //Act
            MergeSortedArray.Merge(nums1, m, nums2, n);
            //Assert
            Assert.NotEqual(expected, nums1);
        }

    }
}
       /* [Fact]
        public void
            {
            }
        //Arrange
        //Act
        //Assert*/