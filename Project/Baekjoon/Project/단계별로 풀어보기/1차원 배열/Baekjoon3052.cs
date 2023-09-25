// 나머지
// https://www.acmicpc.net/problem/3052

using System;
using System.Linq;

public class Baekjoon3052
{
    public Baekjoon3052 ()
    {
        int NUM = 42;
        var arr = Enumerable.Repeat (0, NUM).ToArray ();
        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse (Console.ReadLine ());
            arr[num % NUM] += 1;
        }
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                result++;
            }
        }
        Console.WriteLine (result); 
    }
}