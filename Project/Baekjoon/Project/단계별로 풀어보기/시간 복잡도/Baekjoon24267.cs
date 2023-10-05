// 알고리즘 수업 - 알고리즘의 수행 시간 6
// https://www.acmicpc.net/problem/24267

using System;

public class Baekjoon24267
{
    public Baekjoon24267 ()
    {
        /*
        MenOfPassion(A[], n) {
            sum <- 0;
            for i <- 1 to n - 2
                for j <- i + 1 to n - 1
                    for k <- j + 1 to n
                        sum <- sum + A[i] × A[j] × A[k]; # 코드1
            return sum;
        }
         */

        // O(n(n-1)(n-2)/6) -> O(n³-2n²-n2+2n) -> O(n³+3n²+2n) ...-> O(n³)
        long n = int.Parse (Console.ReadLine ());
        Console.WriteLine (n * (n - 1) * (n - 2) / 6);
        Console.WriteLine ("3");
    }
}