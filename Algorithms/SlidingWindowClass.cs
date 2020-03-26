using System;
using System.Collections;
using System.Linq;

namespace Algorithms
{
    public class SlidingWindowClass
    {
        public SlidingWindowClass()
        {
        }

        /// <summary>
        /// 走査対象配列をウィンドウで走査し、各インデックスの最大値を出力
        /// </summary>
        /// <param name="array">走査対象配列</param>
        /// <param name="windowSize">ウィンドウサイズ</param>
        public void Execute(int[] array, int windowSize)
        {
            
            Queue window = new Queue();
            Queue holder = new Queue(array);

            //Initialize
            //Add a dummy component for first scanning
            window.Enqueue(0);
            for (int index = 0; index < windowSize - 1; index++)
            {
                window.Enqueue(holder.Dequeue());
            }

            //Scanning
            for (int index = 0; index < array.Length - windowSize + 1; index++)
            {
                window.Dequeue();
                window.Enqueue(holder.Dequeue());

                Console.WriteLine(window.ToArray().ToList().Max());
            }


        }

    }
}
