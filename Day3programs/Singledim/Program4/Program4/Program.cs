class Program4
{
    static void separateArray(int[] arr)
    {
        /*int[] odd = new int[arr.Length];
        int[] even = new int[arr.Length];*/
        List<int> oddlist = new List<int>();
        List<int> evenlist = new List<int>();
        int iterodd = 0,itereven = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i]%2 == 0)
            {
                evenlist.Add(arr[i]);
            }
            else
            {
                oddlist.Add(arr[i]);
            }
        }
        Console.WriteLine("Printing odd elements");
        for(int i = 0; i < oddlist.Count; i++)
        {
            Console.WriteLine(oddlist[i]);
        }
        Console.WriteLine("Printing even elements");
        for (int i = 0; i < evenlist.Count; i++)
        {
            Console.WriteLine(evenlist[i]);
        }
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
        separateArray(arr);
    }
}