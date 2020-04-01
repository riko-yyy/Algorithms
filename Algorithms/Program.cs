using System;
using System.Collections;
using System.Linq;
using Algorithms.Structure;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=================================================");
            Console.WriteLine("1)Tower of Hanoi");
            Console.WriteLine("-------------------------------------------------");
            TowerOfHanoiClass exe1 = new TowerOfHanoiClass();
            exe1.Execute(4, 'A', 'B', 'C');
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("2)Binary");
            Console.WriteLine("-------------------------------------------------");
            BinaryClass exe2 = new BinaryClass(4);
            exe2.Execute(4);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("3)KString");
            Console.WriteLine("-------------------------------------------------");
            KStringClass exe3 = new KStringClass(4);
            exe3.Execute(4, 5);
            Console.WriteLine("=================================================");


            Console.WriteLine("=================================================");
            Console.WriteLine("4)Parser");
            Console.WriteLine("-------------------------------------------------");
            ParserClass exe4 = new ParserClass();
            exe4.Execute("()()()()(((())))");
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("5)FindSpan");
            Console.WriteLine("-------------------------------------------------");
            FindSpanClass exe5 = new FindSpanClass();
            exe5.Execute(new int[] { 6, 3, 4, 5, 2 }, 5);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("6)SlideWindow");
            Console.WriteLine("-------------------------------------------------");
            SlidingWindowClass exe6 = new SlidingWindowClass();
            exe6.Execute(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("7)PreOrder");
            Console.WriteLine("-------------------------------------------------");
            PreOrderClass exe7 = new PreOrderClass();
            BinaryTreeNode root = new BinaryTreeNode(1, new BinaryTreeNode(2, new BinaryTreeNode(4, null, null), new BinaryTreeNode(5, null, null)), new BinaryTreeNode(3, null, null));
            exe7.Execute(root);
            Console.WriteLine("=================================================");

            Console.WriteLine("=================================================");
            Console.WriteLine("8)InOrder");
            Console.WriteLine("-------------------------------------------------");
            InOrderClass exe8 = new InOrderClass();
            BinaryTreeNode root2 = new BinaryTreeNode(1, new BinaryTreeNode(2, new BinaryTreeNode(4, null, null), new BinaryTreeNode(5, null, null)), new BinaryTreeNode(3, null, null));
            exe8.Execute(root);
            Console.WriteLine("=================================================");


        }
    }
}
