class secondpgrm
{
    static void Main(String[] args)
    {
        int a = 0, b = 1, ip, c;
        Console.WriteLine("Enter a number");
        ip = int.Parse(Console.ReadLine());
        if (ip == 1)
        {
            Console.WriteLine(a);
        }
        else if (ip >= 2)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);

            if (ip > 2)
            {
                for (int i = 2; i < ip; i++)
                {
                    c = a + b;
                    Console.WriteLine(c);
                    a = b;
                    b = c;
                }
            }
        }
    }
}