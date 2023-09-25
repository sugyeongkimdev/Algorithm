// 과제 안 내신 분..?
// https://www.acmicpc.net/problem/5597

using System;
using System.Linq;

public class Baekjoon5597
{
    public Baekjoon5597 ()
    {
        var studentArr  = Enumerable.Range (1, 30).ToArray();
        string str;
        while (string.IsNullOrWhiteSpace ((str = Console.ReadLine ())) == false)
        {
            int num = int.Parse (str);
            studentArr[num - 1] = -1;
        }
        for (int i = 0; i < studentArr.Length; i++)
        {
            if (studentArr[i] != -1)
            {
                Console.WriteLine (studentArr[i]);
            }
        }
    }
}