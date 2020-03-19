using System;
using System.Collections;

namespace Algorithms
{
    public class ParserClass
    {



        public ParserClass()
        {
        }

        public void Execute(string str)
        {
            bool able = false;
            bool isRoundUp = false;


            Stack stack = new Stack();

            foreach (var chara in str.ToCharArray())
            {
                if (chara == '(')
                {
                    stack.Push(chara);
                }
                else if (chara == ')')
                {
                    if (stack.Count == 0)
                    {
                        isRoundUp = true;
                        break;
                    }

                    stack.Pop();


                }



            }


            if (stack.Count == 0 && !isRoundUp)
            {
                able = true;
            }


            Console.WriteLine(able);
        }

    }
}
