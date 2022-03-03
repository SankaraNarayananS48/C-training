class firstpgrm {

    public static int sumofdigits(int value)
    {
        int sum = 0;
        for (; value > 0; value /= 10)
        {
            sum += value % 10;
        }
        return sum;
    }
    public static void Main(String[] args)
    {

        int a, op;
        Console.WriteLine("Enter a number");
        a = int.Parse(Console.ReadLine());
        if (a < 10)
        {
            Console.WriteLine("Single digit number" + " " + a);
        }
        else
        {
            op = sumofdigits(a);
            if (op >= 10)
            {
                /*while(op< 10)
                {
                    op= sumofdigits(a);
                }
                if (op<10) { Console.WriteLine(op.ToString()); }*/
                Console.WriteLine(sumofdigits(op).ToString());
            }
            else
            {
                Console.WriteLine(op.ToString());
            }
        }
    }

    
}