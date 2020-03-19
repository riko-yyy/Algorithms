using System;
using System.Text;

namespace Algorithms
{
    public class TowerOfHanoiClass
    {
        public TowerOfHanoiClass()
        {
        }

        public void Execute(int n, char fromPeg, char toPeg, char auxPeg)
        {
            //末端（Top）
            if (n == 1)
            {
                StringBuilder stb = new StringBuilder();
                stb.Append("Move disk 1 from peg ");
                stb.Append(fromPeg);
                stb.Append(" to peg ");
                stb.Append(toPeg);

                Console.WriteLine(stb);
                return;
            }

            //Sourceのn-1番目の円盤をAからBへ
            Execute(n - 1, fromPeg, auxPeg, toPeg);

            //残りをAからCへ
            StringBuilder stb1 = new StringBuilder();
            stb1.Append("Move disk ");
            stb1.Append(n);
            stb1.Append(" from peg ");
            stb1.Append(fromPeg);
            stb1.Append(" to peg ");
            stb1.Append(toPeg);
            Console.WriteLine(stb1);

            //Sourceのn-1番目の円盤をBからCへ
            Execute(n - 1, auxPeg, toPeg, fromPeg);



        }


    }
}
