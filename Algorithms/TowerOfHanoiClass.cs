using System;
using System.Text;

namespace Algorithms
{
    public class TowerOfHanoiClass
    {
        public TowerOfHanoiClass()
        {
        }

        /// <summary>
        /// ハノイの塔の各円盤の移動プロセスを出力
        /// </summary>
        /// <param name="n">円盤の枚数</param>
        /// <param name="fromPeg">始点</param>
        /// <param name="toPeg">終点</param>
        /// <param name="auxPeg">経由点</param>
        public void Execute(int n, char fromPeg, char toPeg, char auxPeg)
        {
            //n枚の円盤を始点から終点に運ぶ問題をn-1、n-2・・・1枚の問題へと再帰問題へと展開

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
