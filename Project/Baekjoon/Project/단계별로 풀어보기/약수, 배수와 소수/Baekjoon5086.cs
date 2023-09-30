// 배수와 약수
// https://www.acmicpc.net/problem/5086

using System;

public class Baekjoon5086
{
    public Baekjoon5086 ()
    {
        string str;
        while (string.IsNullOrEmpty (str = Console.ReadLine ()) == false)
        {
            var arr = str.Split ();
            int a = int.Parse (arr[0]);
            int b = int.Parse (arr[1]);
            if (a != 0 && b != 0)
            {
                Console.WriteLine (b % a == 0 ? "factor" : a % b == 0 ? "multiple" : "neither");
            }
        }
    }
}