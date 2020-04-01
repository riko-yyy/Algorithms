using System;
using Algorithms.Structure;

namespace Algorithms
{
    public class InOrderClass
    {
        public InOrderClass()
        {
        }


        /// <summary>
        /// 間順序横断（LDR）で処理実行
        /// </summary>
        /// <param name="root">親ノード</param>
        public void Execute(BinaryTreeNode root)
        {
            if (root.Left != null)
            {
                Execute(root.Left);
            }

            Console.WriteLine(root.Data);

            if (root.Right != null)
            {
                Execute(root.Right);
            }

        }

    }
}
