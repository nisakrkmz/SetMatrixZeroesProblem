using SetMatrixZeroes;

public class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[][]
        {
            new int[] { 4, 6, 5 },
            new int[] { 9, 8, 0 },
            new int[] { 2, 4, 1 }
        };
        Solution sol = new Solution();
        sol.SetZeroes(matrix);

        Console.WriteLine("Updatated Matris:");
        for (int i = 0; i < matrix.Length; i++)
        {
            Console.WriteLine(string.Join(" ", matrix[i]));
        }
    }
}