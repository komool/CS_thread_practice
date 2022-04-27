using System;
using System.Threading.Tasks;

namespace CS_Thread
{
    class ParallelDemo
    {
        /*static void Main(string[] args)
        {
            // 동시성 (지금까지 사용하던 for문)
            *//*for (int i = 0; i < 200_000; i++)
                Console.WriteLine(i);*//*

            // 병렬 처리
            Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); });
        }*/
    }
}
