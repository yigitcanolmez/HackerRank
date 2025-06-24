public static int saveThePrisoner(int n, int m, int s)
{
     int result = (s + m - 1) % n;
     return result == 0 ? n : result;
}
