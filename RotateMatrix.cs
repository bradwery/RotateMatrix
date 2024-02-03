public static class MatrixExtensions
{
    public static void Print(this int[][] matrix, string title, Action<string> write)
    {
        write($"\r\n{title}\r\n");
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix.Length; j++)
                write(matrix[i][j].ToString().PadLeft(3));
        
            write("\r\n");
        }
    }

    public static void Rotate(this int[][] matrix)
    {
        for(int i = 0; i < matrix.Length / 2; i++)
        {
            for(int j = i; j < matrix.Length - 1 - i; j++)
            {
                //Get current values
                int left = matrix[matrix.Length - 1 - j][i];
                int right = matrix[j][matrix.Length - 1 - i];
                int top = matrix[i][j];
                int bottom = matrix[matrix.Length - 1 - i][matrix.Length - 1 - j];
                
                //Swap Values
                //Move bottom value to the left
                matrix[matrix.Length - 1 - j][i] = bottom;
                //Move right value to the bottom
                matrix[matrix.Length - 1 - i][matrix.Length - 1 - j] = right;
                //Move top value to the right
                matrix[j][matrix.Length - 1 - i] = top;
                //Move left value to the top
                matrix[i][j] = left;
            }
        }
    }
}
