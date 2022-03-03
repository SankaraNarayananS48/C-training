class Program5
{
    static void addelement(int[] arr)
    {
        Console.WriteLine("Enter a integer to insert in the list");
        int element = int.Parse(Console.ReadLine());
        int iter = 0,flag =0;
        int[] sortedarray = new int[arr.Length+1];
        for (int i = 0; i < arr.Length; i++)
        {
           
                if (element<arr[i] && flag==0)
                {
                   sortedarray[iter] = element;
                   iter++;
                   flag = 1;
                }
                sortedarray[iter] = arr[i];
                iter++;
                
                
        }
        Console.WriteLine("Printing Sorted List after inserting a new element");
        for (int i = 0; i < sortedarray.Length; i++)
        {
            Console.WriteLine(sortedarray[i]);
        }
    }
    static void Main(String[] args)
    {
        
        Console.WriteLine("Enter no of elements in array:");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter array elemnts:");
        for (int i = 0; i < size; i++)
        {
            arr[i]=(int.Parse(Console.ReadLine()));
        }
        addelement(arr);

    }
}