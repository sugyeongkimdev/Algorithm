// 알고리즘 수업 - 알고리즘의 수행 시간 3
// https://www.acmicpc.net/problem/24264

using System;

public class Baekjoon24264
{
    public Baekjoon24264 ()
    {
        /*
        MenOfPassion(A[], n)
        {
            sum <- 0;
            for i <- 1 to n
                for j <- 1 to n
                    sum <- sum + A[i] × A[j]; # 코드1
            return sum;
        }
         */

        // O(n²) or O(n^2)
        long n = int.Parse (Console.ReadLine ());
        Console.WriteLine (n*n);
        Console.WriteLine ("2");
    }
}