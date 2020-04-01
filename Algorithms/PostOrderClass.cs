using System;
using Algorithms.Structure;

namespace Algorithms
{
    public class PostOrderClass
    {
        public PostOrderClass()
        {
        }

        /// <summary>
        /// 後順序横断（LRD）で処理実行
        /// </summary>
        /// <param name="root">親ノード</param>
        public void Execute(BinaryTreeNode root)
        {
            if (root.Left != null)
            {
                Execute(root.Left);
            }

            if (root.Right != null)
            {
                Execute(root.Right);
            }

            Console.WriteLine(root.Data);

        }
    }
}
