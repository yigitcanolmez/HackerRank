using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    public static class CountingValleys3
    {
        public static int Solve(int steps, string path)
        {
            int degree = 0;
            
            int total = 0;

            foreach (var item in path)
            {
                if (item == 'U')
                {
                    degree++;
                }
                else
                {
                    degree--;
                }


                if (degree == 0 && item == 'U')
                {
                    total++;
                }
            }

            return total;
        }
    }
}
