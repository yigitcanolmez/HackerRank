public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
    int n = a.Count;
    var result = new List<int>();

    k = k % n;

    var rotated = new List<int>(new int[n]);
    for (int i = 0; i < n; i++)
    {
        int newIndex = (i + k) % n;
        rotated[newIndex] = a[i];
    }

    foreach (int query in queries)
    {
        result.Add(rotated[query]);
    }

    return result;
}
