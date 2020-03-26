using System;
namespace Algorithms
{
    public class BinaryClass
    {
        /// <summary>
        /// 結果保持配列
        /// </summary>
        int[] a;

        /// <summary>
        /// 結果保持配列の初期化
        /// </summary>
        /// <param name="n">桁数</param>
        public BinaryClass(int n)
        {
            a = new int[n];

        }

        /// <summary>
        /// n桁の数において、各桁の数値「0,1,2」を用いた組み合わせの総当たり
        /// </summary>
        /// <param name="n">桁数</param>
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
