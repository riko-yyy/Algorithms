using System;
using System.Collections;

namespace Algorithms
{
    public class FindSpanClass
    {
        public FindSpanClass()
        {
        }

        /// <summary>
        /// 各スペクトルにおいて、自身より値が大きい直近のスペクトルとの距離を出力
        /// </summary>
        /// <param name="array">スペクトル</param>
        /// <param name="n">スペクトルの要素数</param>
        public void Execute(int[] array, int n)
        {
            int[] span = new int[n];
            Stack stack = new Stack();

            //Scannning
            for (int index = 0; index < n; index++)
            {
                //自身より値が大きなスペクトルの位置をスタックしていく

                //自身がスタックしているスペクトルを超えたらポップ
                //超えなくなるまでポップ
                while (stack.Count != 0)
                {
                    if (array[index] > array[(int)stack.Peek()])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                //距離の算出
                //p=自身より値が大きい直近のスペクトルと位置０との距離
                int p;
                if (stack.Count == 0)
                {
                    p = -1;
                }
                else
                {
                    p = (int)stack.Peek();
                }

                span[index] = index - p;

                stack.Push(index);


            }

            Console.WriteLine(string.Join("", span));


        }
    }
}
