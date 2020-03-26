using System;
namespace Algorithms
{
    public class KStringClass
    {
        /// <summary>
        /// 結果保持配列
        /// </summary>
        int[] str;

        /// <summary>
        /// 結果保持配列の初期化
        /// </summary>
        /// <param name="n">桁数</param>
        public KStringClass(int n)
        {
            str = new int[n];
        }

        /// <summary>
        /// n桁の数において、各桁の数値「0~k-1」を用いた組み合わせの総当たり
        /// </summary>
        /// <param name="n">桁数</param>
        /// <param name="k">利用する数値</param>
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
