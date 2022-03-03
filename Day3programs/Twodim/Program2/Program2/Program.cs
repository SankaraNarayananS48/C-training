class Program2
{
    static void Sumofelements(int[,] matrix,int row,int column)
    {
        int rowsum = 0, columnsum = 0;
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                rowsum += matrix[i,j];
            }
            Console.WriteLine("The sum of "+i+"th row "+rowsum);
            rowsum = 0;
        }

        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                columnsum += matrix[i, j];
            }
            Console.WriteLine("The sum of " + i + "th column " + columnsum);
            columnsum = 0;
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
        Console.WriteLine("Enter matrix values:");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Sumofelements(matrix,row,column);

    }
}