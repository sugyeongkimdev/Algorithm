// 세탁소 사장 동혁
// https://www.acmicpc.net/problem/2720

using System;

public class Baekjoon2720
{
    public Baekjoon2720 ()
    {
        int[] moneyArr = { 25, 10, 5, 1 };
        int[] remainArr = { 0, 0, 0, 0 };
        int c = int.Parse (Console.ReadLine ());
        for (int i = 0; i < c; i++)
        {
            int money = int.Parse (Console.ReadLine ());

            for (int j = 0; j < moneyArr.Length; j++)
            {
                remainArr[j] = money / moneyArr[j];
                money %= moneyArr[j];

            }
            Console.WriteLine (string.Join(" ", remainArr));
        }
    }
}