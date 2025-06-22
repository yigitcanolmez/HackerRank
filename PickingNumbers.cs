public static int pickingNumbers(List<int> a)
    {

        a.Sort();

        int response = 0;
        for (int i = 0; i < a.Count; i++)
        {
            int count = FindSubArrayCount(a.GetRange(i, a.Count - i));
            response = Math.Max(response, count);
        }
        return response;
    }

    private static int FindSubArrayCount(List<int> segment)
    {
        if (segment.Count == 0) return 0;

        int x = segment[0];        
        int y = x + 1;             
        int count = 0;

        foreach (int val in segment)
        {
            if (val == x || val == y)
            {
                count++;
            }
            else if (val > y) 
            {
                break;
            }
        }
        return count;
    }
