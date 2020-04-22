using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Structure;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursuve

            Console.WriteLine("=================================================");
            Console.WriteLine("1-1)Tower of Hanoi");
            Console.WriteLine("-------------------------------------------------");
            TowerOfHanoiClass exe1 = new TowerOfHanoiClass();
            exe1.Execute(4, 'A', 'B', 'C');
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("1-2)Binary");
            Console.WriteLine("-------------------------------------------------");
            BinaryClass exe2 = new BinaryClass(4);
            exe2.Execute(4);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("1-3)KString");
            Console.WriteLine("-------------------------------------------------");
            KStringClass exe3 = new KStringClass(4);
            exe3.Execute(4, 5);
            Console.WriteLine("=================================================");


            //Stack

            Console.WriteLine("=================================================");
            Console.WriteLine("2-1)Parser");
            Console.WriteLine("-------------------------------------------------");
            ParserClass exe4 = new ParserClass();
            exe4.Execute("()()()()(((())))");
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("2-2)FindSpan");
            Console.WriteLine("-------------------------------------------------");
            FindSpanClass exe5 = new FindSpanClass();
            exe5.Execute(new int[] { 6, 3, 4, 5, 2 }, 5);
            Console.WriteLine("=================================================");


            //Queue

            Console.WriteLine("=================================================");
            Console.WriteLine("3-1)SlideWindow");
            Console.WriteLine("-------------------------------------------------");
            SlidingWindowClass exe6 = new SlidingWindowClass();
            exe6.Execute(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            Console.WriteLine("=================================================");


            //Binary Tree

            BinaryTreeNode root = new BinaryTreeNode(1, new BinaryTreeNode(2, new BinaryTreeNode(4, null, null), new BinaryTreeNode(5, null, null)), new BinaryTreeNode(3, null, null));
            Console.WriteLine("=================================================");
            Console.WriteLine("4-1-1)PreOrder");
            Console.WriteLine("-------------------------------------------------");
            PreOrderClass exe7 = new PreOrderClass();
            exe7.Execute(root);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-1-2)InOrder");
            Console.WriteLine("-------------------------------------------------");
            InOrderClass exe8 = new InOrderClass();
            exe8.Execute(root);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-1-3)PostOrder");
            Console.WriteLine("-------------------------------------------------");
            PostOrderClass exe9 = new PostOrderClass();
            exe9.Execute(root);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-1-4)LevelOrder");
            Console.WriteLine("-------------------------------------------------");
            LevelOrderClass exe10 = new LevelOrderClass();
            exe10.Execute(root);
            Console.WriteLine("=================================================");


            //Binary Tree App

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-1)FindMax");
            Console.WriteLine("-------------------------------------------------");
            BinaryTreeRepositoryClass repo = new BinaryTreeRepositoryClass();
            Console.WriteLine(repo.FindMax(root));
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-2)Contains");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(repo.Contains(root, 4));
            Console.WriteLine(repo.Contains(root, 10));
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-3)Add");
            Console.WriteLine("-------------------------------------------------");
            LevelOrderClass exe11 = new LevelOrderClass();
            exe11.Execute(root);
            Console.WriteLine("-------------------------------------------------");
            repo.Add(root, 6);
            exe11.Execute(root);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-4)Size");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(repo.Count(root));
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-5)Delete");
            Console.WriteLine("-------------------------------------------------");
            repo.DeleteBinaryTree(root);
            LevelOrderClass exe12 = new LevelOrderClass();
            exe12.Execute(root);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-6)Height");
            Console.WriteLine("-------------------------------------------------");
            root = new BinaryTreeNode(1, new BinaryTreeNode(2, null, null), null);
            Console.WriteLine(repo.Height(root));
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-7)CountLeaf");
            Console.WriteLine("-------------------------------------------------");
            root = new BinaryTreeNode(1, new BinaryTreeNode(2, new BinaryTreeNode(4, null, null), new BinaryTreeNode(5, null, null)), new BinaryTreeNode(3, null, null));
            Console.WriteLine(repo.CountLeaf(root));
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("4-2-8)Route");
            Console.WriteLine("-------------------------------------------------");
            root = new BinaryTreeNode(1, new BinaryTreeNode(2, new BinaryTreeNode(4, null, null), new BinaryTreeNode(5, null, null)), new BinaryTreeNode(3, null, null));
            int[] path = new int[3];
            repo.Route(root, path, 0);
            Console.WriteLine();
            Console.WriteLine("=================================================");

        }
    }
}
