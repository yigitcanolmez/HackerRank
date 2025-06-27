public static List<int> PermutationEquation(List<int> p)
{
    var response = new List<int>();

    for (int i = 1; i <= p.Count; i++)
    {
        int firstIndex = p.IndexOf(i) + 1;
        int secondIndex = p.IndexOf(firstIndex) + 1;
        response.Add(secondIndex);
    }

    return response;
}
