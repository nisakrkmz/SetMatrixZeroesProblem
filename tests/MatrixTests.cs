using SetMatrixZeroes;

namespace tests
{
    public class MatrixTests
    {
        // 1. Hiç sıfır yoksa 
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

        // 2. Tüm matris sıfırsa
        [Fact]
        public void SetZeroes_AllZeroes_ShouldRemainUnchanged()
        {
            int[][] matrix = new int[][]
            {
                new int[] {0, 0, 0},
                new int[] {0, 0, 0},
                new int[] {0, 0, 0}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0},
                new int[] {0, 0, 0},
                new int[] {0, 0, 0}
            };

            var solution = new Solution();
            solution.SetZeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                Assert.Equal(expected[i], matrix[i]);
            }
        }

        // 3. Tek satır veya tek sütundan oluşuyorsa
        [Fact]
        public void SetZeroes_SingleRowWithZero_ShouldZeroEntireRow()
        {
            int[][] matrix = new int[][]
            {
                new int[] {1, 0, 3}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0}
            };

            var solution = new Solution();
            solution.SetZeroes(matrix);
            Assert.Equal(expected[0], matrix[0]);
        }

        [Fact]
        public void SetZeroes_SingleColumnWithZero_ShouldZeroEntireColumn()
        {
            int[][] matrix = new int[][]
            {
                new int[] {1},
                new int[] {0},
                new int[] {3}
            };

            int[][] expected = new int[][]
            {
                new int[] {0},
                new int[] {0},
                new int[] {0}
            };

            var solution = new Solution();
            solution.SetZeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                Assert.Equal(expected[i], matrix[i]);
            }
        }

        // İlk satır veya sütunda 0 varsa
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
                new int[] {0, 0, 0},
                new int[] {0, 5, 6},
                new int[] {0, 8, 9}
            };

            var solution = new Solution();
            solution.SetZeroes(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                Assert.Equal(expected[i], matrix[i]);
            }
        }
    }
}
