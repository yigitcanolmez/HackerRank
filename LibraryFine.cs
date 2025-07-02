
    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        if (y1 > y2)
            return 10000;
        else if (y1 == y2 && m1 > m2)
            return (m1 - m2) * 500;
        else if (y1 == y2 && m1 == m2 && d1 > d2)
            return (d1 - d2) * 15;
        else
            return 0;
    }
