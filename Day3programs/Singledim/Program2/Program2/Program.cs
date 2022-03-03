class Program2
{
    static int duplicateelements(int[] arr)
    {
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count += 1;
                    break;
                }
            }
        }
        return count;
    }
    static void Main(String[] args)
    {
        Console.WriteLine("Enter no of elements in array:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter array elemnts:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("No of duplicate element in the array is" + " " + duplicateelements(arr));

    }
}