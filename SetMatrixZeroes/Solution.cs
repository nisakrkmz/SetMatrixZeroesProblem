namespace SetMatrixZeroes
{
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            bool firstRowZero = false;
            bool firstColZero = false;

            // 1. İlk satırda sıfır var mı?
            for (int j = 0; j < n; j++)
            {
                if (matrix[0][j] == 0)
                {
                    firstRowZero = true;
                    break;
                }
            }

            // 2. İlk sütunda sıfır var mı?
            for (int i = 0; i < m; i++)
            {
                if (matrix[i][0] == 0)
                {
                    firstColZero = true;
                    break;
                }
            }

            // 3. Diğer hücreler için işaretleme yap
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            // 4. İşaretlere göre sıfırla
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // 5. İlk satırı sıfırla gerekiyorsa
            if (firstRowZero)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            // 6. İlk sütunu sıfırla gerekiyorsa
            if (firstColZero)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }
}
