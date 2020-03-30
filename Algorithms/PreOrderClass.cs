using System;
using Algorithms.Structure;

namespace Algorithms
{
    public class PreOrderClass
    {
        public PreOrderClass()
        {
        }

        /// <summary>
        /// 前順序横断（DLR）で処理実行
        /// </summary>
        /// <param name="root">親ノード</param>
        public void Execute(BinaryTreeNode root)
        {
            Console.WriteLine(root.Data);

            if (root.Left != null )
            {                
                Execute(root.Left);
            }

            if (root.Right != null)
            {
                Execute(root.Right);
            }

        }
    }
}
