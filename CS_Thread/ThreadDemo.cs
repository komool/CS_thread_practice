using System;
using System.Threading;

namespace CS_Thread
{
    class ThreadDemo
    {
        static void Other()
        {
            Console.WriteLine("[?] 다른 작업자 일 실행");
            Thread.Sleep(1000); // 1000분의 1초 => 1초 지연(대기)
            Console.WriteLine("[?] 다른 작업자 일 종료");
        }

        /*static void Main()
        {
            Console.WriteLine("[1] 메인 작업자 일 실행");

            // Thread 클래스와 ThreadStart 대리자로 새로운 스레드 생성
            var other = new Thread(new ThreadStart(Other));
            other.Start();

            Console.WriteLine("[2] 메인 작업자 일 종료");
        }*/
    }
}

/* 출력 결과
 * [1] 메인 작업자 일 실행
 * [2] 메인 작업자 일 종료
 * [?] 다른 작업자 일 실행
 * [?] 다른 작업자 일 종료
 * 
 * other 스레드의 Start 메소드를 호출할 때 새로운 스레드를 생성하고 실행하는 순간 시간이 필요하기에 메인 작업자 스레드가 먼저 실행
 */