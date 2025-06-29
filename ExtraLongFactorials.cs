public static void extraLongFactorials(int n)
    {
        BigInteger result = 1;

        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
