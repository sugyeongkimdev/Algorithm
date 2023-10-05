// 알고리즘 수업 - 알고리즘의 수행 시간 4
// https://www.acmicpc.net/problem/24265

using System;

public class Baekjoon24265
{
    public Baekjoon24265 ()
    {
        /*
        MenOfPassion(A[], n)
        {
            sum <- 0;
            for i <- 1 to n - 1
                for j <- i + 1 to n
                    sum <- sum + A[i] × A[j]; # 코드1
            return sum;
        }
         */
        // i 1, j 0 = 0
        // i 2, j 1 = 1
        // i 3, j 1, 2 = 3
        // i 4, j 1, 2, 3 = 6
        // i 5, j 1, 2, 3, 4 = 10
        // i 6, j 1, 2, 3, 4, 5 = 15
        // i 7, j 1, 2, 3, 4, 5, 6 = 21

        // 등차수열의 합  (n+1)n/2 -> (100+1)100/2 = 5050
        // n-1이므로      (n-1)n/2 -> (7-1)7/2 = 21

        // O(n(n-1)) -> O(n²-n), 최고차항의 차수는 2이다.
        long n = int.Parse (Console.ReadLine ());
        Console.WriteLine ((n - 1) * n / 2);
        Console.WriteLine ("2");
    }
}