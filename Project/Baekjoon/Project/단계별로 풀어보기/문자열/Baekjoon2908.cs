// 상수 
// https://www.acmicpc.net/problem/2908

using System;
using System.Linq;

public class Baekjoon2908
{
    public Baekjoon2908 ()
    {
        string[] arr = Console.ReadLine ().Split ();

        int a = int.Parse (Reverse (arr[0]));
        int b = int.Parse (Reverse (arr[1]));

        Console.WriteLine (a > b ? a : b);

        string Reverse (string numArr)
        {
            var charArr = numArr.ToArray();
            char temp = charArr[0];
            charArr[0] = charArr[2];
            charArr[2] = temp;
            return new string (charArr);
        }
    }
}