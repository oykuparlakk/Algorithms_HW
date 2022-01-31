using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_Algo_Console
{
    class Program
    {
        static Stack Tower1 = new Stack();
        static Stack Tower2 = new Stack();
        static Stack Tower3 = new Stack();
        static void Main(string[] args)
        {
            Tower1.Push(5);
            Tower1.Push(4);
            Tower1.Push(3);
            Tower1.Push(2);
            Tower1.Push(1);

            Move(5, Tower1, Tower3, Tower2);
            Console.ReadLine();
        }

        private static void Move(int v, Stack tower1, Stack tower3, Stack tower2)
        {
            if (v > 0)
            {
                Move(v - 1, tower1, tower2, tower3);
                MoveDisc(tower1,tower3);
                Move(v - 1, tower2, tower3, tower1);
            }
        }

        private static void MoveDisc(Stack tower1, Stack tower3)
        {
            var temp = tower1.Pop();
            tower3.Push(temp);
            SolveHanoi();
        }

        private static void SolveHanoi()
        {
            Console.Write("Tower1:");
            foreach(var item in Tower1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Tower2:");
            foreach (var item in Tower2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("Tower3:");
            foreach (var item in Tower3)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
