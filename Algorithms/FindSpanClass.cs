using System;
using System.Collections;

namespace Algorithms
{
    public class FindSpanClass
    {
        public FindSpanClass()
        {
        }


        public void Execute(int[] array, int n)
        {
            int[] span = new int[n];
            Stack stack = new Stack();

            int p = 0;
            for (int index = 0; index < n; index++)
            {
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
