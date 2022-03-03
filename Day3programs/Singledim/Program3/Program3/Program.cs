class Program3
{
    static void sortascending(int[] mergedarray1)
    {
        int temp = 0;
        for(int i = 0; i < mergedarray1.Length; i++)
        {
            for(int j = i+1; j < mergedarray1.Length; j++)
            {
                if(mergedarray1[j] < mergedarray1[i])
                {
                    temp = mergedarray1[i];
                    mergedarray1[i] = mergedarray1[j];
                    mergedarray1[j] = temp;
                }
            }
        }
        Console.WriteLine("Merged Sorted Array");
        for(int i = 0; i < mergedarray1.Length; i++)
        {
            Console.WriteLine(mergedarray1[i]);
        }
    }
    static void mergeArray(int[] arr1,int[] arr2)
    {
        int size = arr1.Length+arr1.Length;
        int[] mergedarray = new int[size];
        int iter = 0;
        for(int i = 0; i < arr1.Length; i++)
        {
            mergedarray[iter] = arr1[i];
            iter += 1;
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            mergedarray[iter] = arr2[i];
            iter += 1;
        }
        sortascending(mergedarray);
    }
    static void Main(String[] args)
    {
        Console.WriteLine("Enter no of elements in array:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        int[] arr1 = new int[size];
        Console.WriteLine("Enter array 1 elemnts:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter array 2 elemnts:");
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        mergeArray(arr,arr1);
    }
}