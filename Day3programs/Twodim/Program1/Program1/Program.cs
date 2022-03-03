class Program1
{
    static void addMatrix(int[,] matrix, int[,] matrix2,int row,int column)
    {
        int[,] matrix3 = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix3[i, j] = matrix[i,j]+matrix2[i,j];
            }
        }

        Console.WriteLine("Printing Resulant Matrix:");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                Console.Write(matrix3[i,j]+" ");
            }
            Console.WriteLine(" ");
        }

    }
    static void Main(String[] args)
    {
        int row, column;
        Console.WriteLine("Enter row size:");
        row = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter column size");
        column = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, column];
        int[,] matrix2 = new int[row, column];
        Console.WriteLine("Enter matrix values:");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter matrix2 values:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }
        addMatrix(matrix, matrix2,row,column);
    }
}