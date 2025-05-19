using SetMatrixZeroes;

namespace tests
{
    public class MatrixTests
    {
        [Fact]
        public void SetZeroes_OneZeroInMiddle_ShouldZeroCorrectRowAndColumn()
        {
            int[][] matrix = new int[][]
            {
            new int[] { 1, 1, 1 },
            new int[] { 1, 0, 1 },
            new int[] { 1, 1, 1 }
            };

            int[][] expected = new int[][]
            {
            new int[] { 1, 0, 1 },
            new int[] { 0, 0, 0 },
            new int[] { 1, 0, 1 }
            };
            var solution = new Solution();
            solution.SetZeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                Assert.Equal(expected[i], matrix[i]);
            }
        }
        [Fact]
        public void SetZeroes_AllZeroes_ShouldRemainUnchanged()
        {
            int[][] matrix = new int[][]
            {
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 }
            };

            int[][] expected = new int[][]
            {
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 }
            };
            var solution = new Solution();
            solution.SetZeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                Assert.Equal(expected[i], matrix[i]);
            }
        }
        [Fact]
        public void SetZeroes_NoZeroes_ShouldRemainSame()
        {
            int[][] matrix = new int[][]
            {
            new int[] {1, 2},
            new int[] {3, 4}
            };

            int[][] expected = new int[][]
            {
            new int[] {1, 2},
            new int[] {3, 4}
            };
            var solution = new Solution();
            solution.SetZeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                Assert.Equal(expected[i], matrix[i]);
            }
        }
        [Fact]
        public void SetZeroes_ZeroInFirstRow_ShouldHandleCorrectly()
        {
            int[][] matrix = new int[][]
            {
            new int[] {0, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
            };

            int[][] expected = new int[][]
            {
            new int[] { 0, 0, 0 },
            new int[] { 0, 4, 5 },
            new int[] { 0, 7, 8 }
            };
        }
    }
}