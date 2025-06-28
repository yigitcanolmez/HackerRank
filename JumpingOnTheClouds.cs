static int jumpingOnClouds(int[] c, int k)
{
    int energy = 100;
    int loop = 0;
    int n = c.Length;

    while (true)
    {
        loop = (loop + k) % n;

        energy -= c[loop] == 1 ? 3 : 1;

        if (loop == 0)
            break;
    }

    return energy;
}
