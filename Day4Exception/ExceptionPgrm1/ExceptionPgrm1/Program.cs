
class ExceptionPgrm
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter size of array:");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        int value;
        Console.WriteLine("Enter the array values:");
        for (int i = 0; i < arr.Length; i++)
        {
            try
            {
                value = int.Parse(Console.ReadLine());
                
            }
            catch 
            { 
                Console.WriteLine("Please Enter a valid Input:");
                value = int.Parse(Console.ReadLine());
            }
            arr[i] = value;
        }
        Console.WriteLine("Printing array values:");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
    }
}