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



        public void Execute(int[] array, int windowSize)
        {
            Queue window = new Queue();
            Queue holder = new Queue(array);
            window.Enqueue(0);
            for (int index = 0; index < windowSize - 1; index++)
            {
                window.Enqueue(holder.Dequeue());
            }


            for (int index = 0; index < array.Length - windowSize + 1; index++)
            {
                window.Dequeue();
                window.Enqueue(holder.Dequeue());

                Console.WriteLine(window.ToArray().ToList().Max());
            }


        }

    }
}
