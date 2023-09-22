
// 두 원 사이의 정수 쌍
// https://school.programmers.co.kr/learn/courses/30/lessons/181187

using System;

public class Programmers181187
{
    public Programmers181187 ()
    {
        new Solution ().solution (0, 2);
    }

    public class Solution
    {
        public long solution (long r1, long r2)
        {
            // 피타고라스 정리
            // x^2 + y^2 = r^2 -> y^2 = r^2 - x^2 -> y = √r^2 - √x^2

            long result = 0;
            long rr1 = r1 * r1;
            long rr2 = r2 * r2;
            for (long x = 1; x <= r2; x++)
            {
                long xx = x * x;
                long y1 = (long)Math.Floor (Math.Sqrt (rr2 - xx));
                long y2 = x >= r1 ? 0 : (long)Math.Ceiling (Math.Sqrt (rr1 - xx));
                result += y1 - y2 + 1;
            }
            return result * 4;
        }
    }
}