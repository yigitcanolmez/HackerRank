    public static int squares(int a, int b)
    {
        var maxSqrt = Math.Floor(Math.Sqrt(b));
        var minSqrt = Math.Ceiling(Math.Sqrt(a)); 
        
        return (int)(maxSqrt - minSqrt + 1);
    }
