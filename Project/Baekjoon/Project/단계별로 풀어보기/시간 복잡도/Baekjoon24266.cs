// 알고리즘 수업 - 알고리즘의 수행 시간 5
// https://www.acmicpc.net/problem/24266

using System;

public class Baekjoon24266
{
    public Baekjoon24266 ()
    {
        /*
        MenOfPassion(A[], n)
        {
            sum <- 0;
            for i <- 1 to n
                for j <- 1 to n
                    for k <- 1 to n
                        sum <- sum + A[i] × A[j] × A[k]; # 코드1
            return sum;
        }
         */

        // O(n³)
        long n = int.Parse (Console.ReadLine ());
        Console.WriteLine (n*n*n);
        Console.WriteLine ("3");
    }
}