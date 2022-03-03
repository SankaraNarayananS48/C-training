class thirdpgrm
{
    static void checkPrime(int n)
    {
        int flag = 0;
        for (int i = 2; i < n/2; i++)
        {
            if (n % i == 0)
            {
                flag = 1;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine(n);
        }
    }
    
    static void Main(String[] args)
    {
        int start,end;
        Console.WriteLine("Enter a Starting number");
        start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Ending number");
        end = int.Parse(Console.ReadLine());
        for (int i=start;i<=end;i++)
        {
            checkPrime(i);
        }
    }
}