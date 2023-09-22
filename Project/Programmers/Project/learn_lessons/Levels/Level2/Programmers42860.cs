
// 조이스틱
// https://programmers.co.kr/learn/courses/30/lessons/42860

using System;

public class Programmers42860
{
    public Programmers42860 ()
    {
        new Solution ().solution ("ZAAAAZ");
    }

    //====================================//
    public class Solution
    {
        public int solution (string name)
        {
            int[] arr = Array.ConvertAll (name.ToCharArray (), x => x - 65);
            int move1 = -1, move2 = -1;

            // Direction
            int r = 0, rh = 0, l = 0, lh = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    r++;
                    rh++;
                }
                else
                {
                    rh = 0;
                }

                if (arr[arr.Length - i] == 0)
                {
                    l++;
                    lh++;
                }
                else
                {
                    lh = 0;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 13)
                {
                    move1 += arr[i];
                }
                else if (arr[i] != 0)
                {
                    move1 += 26 - arr[i];
                }
                move1++;
            }
            move1 -= rh;

            for (int i = arr.Length - 1; i > -1; i--)
            {
                if (arr[i] < 13)
                {
                    move2 += arr[i];
                }
                else if (arr[i] != 0)
                {
                    move2 += 26 - arr[i];
                }
                move2++;
            }
            move2 -= lh;

            return Math.Min (move1, move2);
            ;
        }
    }
    //====================================//
}