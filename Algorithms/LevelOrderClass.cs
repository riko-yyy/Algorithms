using System;
using System.Collections;
using System.Linq;
using Algorithms.Structure;


namespace Algorithms
{
    public class LevelOrderClass
    {
        public LevelOrderClass()
        {
        }

        /// <summary>
        /// レベル順序横断（深さかつL→R）で処理実行
        /// </summary>
        /// <param name="root">親ノード</param>
        public void Execute(BinaryTreeNode root)
        {
            Queue holder = new Queue();

            holder.Enqueue(root);

            while (holder.Count > 0)
            {
                var tmp = (BinaryTreeNode)holder.Dequeue();

                Console.WriteLine(tmp.Data);

                if (tmp.Left != null)
                {
                    holder.Enqueue(tmp.Left);
                }

                if (tmp.Right != null)
                {
                    holder.Enqueue(tmp.Right);
                }

            }

        }

    }
}
