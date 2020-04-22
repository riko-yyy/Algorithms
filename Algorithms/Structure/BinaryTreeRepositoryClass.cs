using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Structure
{
    public class BinaryTreeRepositoryClass
    {
        public BinaryTreeRepositoryClass()
        {
        }

        /// <summary>
        /// DLRで２分木を横断し、要素の最大値を取得する
        /// </summary>
        /// <param name="root">２分木</param>
        /// <returns>最大値</returns>
        public int? FindMax(BinaryTreeNode root)
        {
            int? max = null;
            List<int?> holder = new List<int?>();
            if (root != null)
            {
                holder.Add(root.Data);

                if (root.Left != null)
                {
                    holder.Add(FindMax(root.Left));
                }

                if (root.Right != null)
                {
                    holder.Add(FindMax(root.Right));
                }

                max = holder.Max();

            }
            return max;
        }

        /// <summary>
        /// レベル順序で探索し、要素の有無を返却する
        /// </summary>
        /// <param name="root">２分木</param>
        /// <returns></returns>
        public bool Contains(BinaryTreeNode root, int item)
        {

            Queue holder = new Queue();
            holder.Enqueue(root);

            while (holder.Count > 0)
            {
                var tmp = (BinaryTreeNode)holder.Dequeue();

                if (tmp.Data == item)
                {
                    return true;
                }

                if (tmp.Left != null)
                {
                    holder.Enqueue(tmp.Left);
                }

                if (tmp.Right != null)
                {
                    holder.Enqueue(tmp.Right);
                }

            }

            return false;
        }

        /// <summary>
        /// レベル順序で、要素を追加
        /// </summary>
        /// <param name="root">２分木</param>
        /// <param name="item">追加要素</param>
        public void Add(BinaryTreeNode root, int item)
        {
            Queue holder = new Queue();
            holder.Enqueue(root);

            while (holder.Count > 0)
            {
                var tmp = (BinaryTreeNode)holder.Dequeue();

                if (tmp.Left != null)
                {
                    holder.Enqueue(tmp.Left);
                }
                else
                {
                    tmp.Left = new BinaryTreeNode(item, null, null);
                    return;
                }

                if (tmp.Right != null)
                {
                    holder.Enqueue(tmp.Right);
                }
                else
                {
                    tmp.Right = new BinaryTreeNode(item, null, null);
                    return;
                }

            }
        }

        /// <summary>
        /// 2分木のサイズを取得
        /// </summary>
        /// <param name="root">2分木</param>
        /// <returns></returns>
        public int Count(BinaryTreeNode root)
        {
            int res = 0;
            if (root == null)
            {

            }
            else
            {
                res = 1 + Count(root.Left) + Count(root.Right);

            }
            return res;
        }

        /// <summary>
        /// 2分木の葉の数を取得
        /// </summary>
        /// <param name="root">2分木</param>
        /// <returns></returns>
        public int CountLeaf(BinaryTreeNode root)
        {
            int res = 0;
            if (root == null)
            {

            }
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    res += 1;
                }
                else
                {
                    res = CountLeaf(root.Left) + CountLeaf(root.Right);
                }

            }
            return res;
        }

        /// <summary>
        /// 2分木の高さを取得
        /// </summary>
        /// <param name="root">2分木</param>
        /// <returns></returns>
        public int Height(BinaryTreeNode root)
        {
            int res = 0;
            if (root == null)
            {

            }
            else
            {
                res = 1 + Math.Max(Height(root.Left), Height(root.Right));
            }
            return res;
        }

        /// <summary>
        /// 後順序横断（LRD）で処理実行
        /// </summary>
        /// <param name="root">親ノード</param>
        public void DeleteBinaryTree(BinaryTreeNode root)
        {
            if (root.Left != null)
            {
                DeleteBinaryTree(root.Left);
            }

            if (root.Right != null)
            {
                DeleteBinaryTree(root.Right);
            }

            root.Data = null;

        }

        /// <summary>
        /// 根から葉までの履歴出力
        /// </summary>
        /// <param name="root">親ノード</param>
        /// <param name="route">ルート履歴保持</param>
        /// <param name="depth">深さ</param>
        public void Route(BinaryTreeNode root, int[] route, int depth)
        {
            if (root.Data == null)
            {
                return;
            }

            route[depth] = (int)root.Data;
            depth++;

            if (root.Left == null && root.Right == null)
            {
                Console.WriteLine(string.Join("-", route));
            }
            else
            {
                if (root.Left != null)
                {
                    Route(root.Left, route, depth);
                }

                if (root.Right != null)
                {
                    Route(root.Right, route, depth);
                }
            }


        }

    }
}
