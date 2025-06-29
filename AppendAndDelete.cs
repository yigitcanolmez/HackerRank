public static string appendAndDelete(string s, string t, int k)
{
    int commonLength = 0;

    for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
    {
        if (s[i] == t[i])
            commonLength++;
        else
            break;
    }

    int totalOps = (s.Length - commonLength) + (t.Length - commonLength);

    if (totalOps > k)
    {
        return "No";
    }
    else if ((k - totalOps) % 2 == 0 || (s.Length + t.Length) <= k)
    {
        return "Yes";
    }
    else
    {
        return "No";
    }
}
