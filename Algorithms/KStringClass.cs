using System;
namespace Algorithms
{
    public class KStringClass
    {
        int[] str;

        public KStringClass(int n)
        {
            str = new int[n];
        }

        public void Execute(int n, int k)
        {
            if (n < 1)
            {
                Console.WriteLine(string.Join("", str));
            }
            else
            {
                for (int index = 0; index < k; index++)
                {
                    str[n - 1] = index;
                    Execute(n - 1, k);

                }



            }

        }

    }
}
