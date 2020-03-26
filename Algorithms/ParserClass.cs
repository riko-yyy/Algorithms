using System;
using System.Collections;

namespace Algorithms
{
    public class ParserClass
    {
        public ParserClass()
        {
        }

        /// <summary>
        /// （）でパース可能か判定
        /// </summary>
        /// <param name="str">文字列</param>
        public void Execute(string str)
        {
           //引数より受け取った文字列に対して、「（」はスタックし、「）」を見つけるとポップする

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
                    //「（」が以前にでていない場合
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
