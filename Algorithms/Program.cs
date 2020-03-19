using System;
using System.Collections;

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
            exe3.Execute(4,5);
            Console.WriteLine("=================================================");


            Console.WriteLine("=================================================");
            Console.WriteLine("4)Parser");
            Console.WriteLine("-------------------------------------------------");
            ParserClass exe4 = new ParserClass();
            exe4.Execute("()()()()(((())))");
            Console.WriteLine("=================================================");


       


            
            

        }
    }
}
