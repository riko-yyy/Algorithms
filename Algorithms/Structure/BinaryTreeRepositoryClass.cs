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


    }
}
