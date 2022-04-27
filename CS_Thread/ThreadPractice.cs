using System;
using System.Diagnostics;
using System.Threading;

namespace CS_Thread
{
    class ThreadPractice
    {
        private static void Ide()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[3] IDE : Visual Studio");
        }

        private static void Sql()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[2] DBMS : SQL Server");
        }

        private static void Win()
        {
            Thread.Sleep(3000);
            Console.WriteLine("[1] OS : Windows Server");
        }

        /*static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(Win);
            ThreadStart ts2 = new ThreadStart(Sql);

            Thread t1 = new Thread(ts1);
            var t2 = new Thread(ts2);
            var t3 = new Thread(new ThreadStart(Ide))
            {
                Priority = ThreadPriority.Highest // 우선순위 높게 설정
            };

            t1.Start();
            t2.Start();
            t3.Start();

            //Process.Start("IExplore.exe"); // 익스플로러 실행 (윈도우 11 X)
            Process.Start("Notepad.exe"); // 메모장 실행
        }*/
    }
}

/* 스레드 동기화
 * 여러 스레드를 동시에 실행할 때 한 스레드가 메소드를 실행하는 동안 다른 스레드도 같은 메소드를 실행하려 해서 오류 발생을 방지하기 위해 스레드 잠금
 * lock (this) {}
 * 
 * 병렬 프로그래밍
 * TPL이란 이름의 라이브러리 제공
 * Parallel 클래스의 For() 또는 ForEach() 같은 메소드를 사용하면 병렬로 컴퓨터 자원을 최대한 사용하여 빠르게 작업을 처리
 */