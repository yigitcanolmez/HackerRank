 public static int findDigits(int n)
{
    int temp = n;
    int response = 0;

    while (temp > 0)
    {
        int basamak = temp % 10;

        if (basamak != 0 && n % basamak == 0)
        {
            response++;
        }

        temp /= 10;
    }

    return response;
}
