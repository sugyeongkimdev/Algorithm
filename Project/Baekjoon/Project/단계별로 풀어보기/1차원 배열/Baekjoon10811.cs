// 바구니 뒤집기
// https://www.acmicpc.net/problem/10811

using System;
using System.Linq;

public class Baekjoon10811
{
    public Baekjoon10811 ()
    {
        var first = Console.ReadLine ().Split ();
        int size = int.Parse (first[0]);
        int count = int.Parse (first[1]);
        int[] arr = Enumerable.Range (1, size).ToArray ();

        for (int i = 0; i < count; i++)
        {
            var line = Console.ReadLine ().Split ();
            int start = int.Parse (line[0]);
            int end = int.Parse (line[1]);
            Reverse (start - 1, end - 1);
        }

        Console.WriteLine (string.Join (" ", arr));

        void Reverse (int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
    }
}