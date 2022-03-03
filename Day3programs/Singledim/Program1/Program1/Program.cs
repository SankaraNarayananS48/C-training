class Program1
{
    static int minimumelement(int[] arr)
    {
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < min)
                min = arr[i];
        }
        return min;

    }

    static int maximumelement(int[] arr)
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;

    }
    static void Main(String[] args)
    {
        Console.WriteLine("Enter no of elements in array:");
        int size = int.Parse( Console.ReadLine() );
        int[] arr = new int[size];
        Console.WriteLine("Enter array elemnts:");
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse( Console.ReadLine() );
        }
        Console.WriteLine("Minimum element in the array is"+" "+minimumelement(arr));
        Console.WriteLine("Maximum element in the array is" + " " + maximumelement(arr));
    }
}