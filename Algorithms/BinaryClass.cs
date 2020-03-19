using System;
namespace Algorithms
{
    public class BinaryClass
    {
        int[] a;

        public BinaryClass(int n)
        {
            a = new int[n];

        }

        public void Execute(int n)
        {
            if (n < 1)
            {
                Console.WriteLine(string.Join("", a));
            }
            else
            {
                a[n - 1] = 0;
                Execute(n - 1);
                a[n - 1] = 1;
                Execute(n - 1);
                a[n - 1] = 2;
                Execute(n - 1);
            }


        }

    }
}
