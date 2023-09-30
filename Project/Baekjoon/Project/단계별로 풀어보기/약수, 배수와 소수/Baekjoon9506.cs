// 약수들의 합
// https://www.acmicpc.net/problem/9506

using System;
using System.Collections.Generic;
using System.Linq;

public class Baekjoon9506
{
    public Baekjoon9506 ()
    {
        while (int.TryParse (Console.ReadLine (), out int num))
        {
            if (num <= 0)
            {
                continue;
            }
            var arr = DivisorArr (num);
            int sum = arr.Sum ();
            if (num == sum)
            {
                Console.WriteLine ($"{num} = {string.Join (" + ", arr)}");
            }
            else
            {
                Console.WriteLine ($"{num} is NOT perfect.");
            }
        }
        // 약수모음 반환
        List<int> DivisorArr (int n)
        {
            List<int> list = new List<int> ();
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    list.Add (i);
                }
            }
            return list;
        }
    }
}