namespace Drawing_Book3
{
    public class DrawingBook3
    {
        public static int PageCount(int n, int p)
        {
            int fromStart = p / 2;

            int totalPages = (n / 2);

            int fromEnd = totalPages - fromStart;

            if (fromEnd < fromStart)
            {
                return fromEnd;
            }
            else
            {
                return fromStart;
            }
        }


    }
}
