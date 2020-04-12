using System;
namespace Algorithms
{
    public class GcdClass
    {
        public GcdClass()
        {
        }

        /// <summary>
        /// 最大公約数を返す
        /// </summary>
        /// <param name="a">整数1</param>
        /// <param name="b">整数2</param>
        /// <returns>最大公約数</returns>
        public static int Gcd(int a, int b)
        {
            if (a < b)
                // 引数を入替えて自分を呼び出す
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
