using System;
namespace Algorithms.Structure
{
    public class BinaryTreeNode
    {
        /// <summary>
        /// 親ノード
        /// </summary>
        public int Data { get; }
        /// <summary>
        /// 左の子ノード
        /// </summary>
        public BinaryTreeNode Left { get; }
        /// <summary>
        /// 右の子ノード
        /// </summary>
        public BinaryTreeNode Right { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="data">親ノード</param>
        /// <param name="left">左の子ノード</param>
        /// <param name="right">右の子ノード</param>
        public BinaryTreeNode(int data, BinaryTreeNode left, BinaryTreeNode right)
        {
            Data = data;
            Left = left;
            Right = right;
        }



    }
}
