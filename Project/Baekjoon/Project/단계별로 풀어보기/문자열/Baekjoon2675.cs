// 문자열 반복
// https://www.acmicpc.net/problem/2675

using System;

public class Baekjoon2675
{
    public Baekjoon2675 ()
    {
        int count = int.Parse (Console.ReadLine ());
        for (int i = 0; i < count; i++)
        {
            string[] arr = Console.ReadLine ().Split ();
            int repeat = int.Parse (arr[0]);
            string str = arr[1];
            for (int j = 0; j < str.Length; j++)
            {
                for (int k = 0; k < repeat; k++)
                {
                    Console.Write (str[j]);
                }
            }
            Console.WriteLine ();
        }
    }
}