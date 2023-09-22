
// 음양 더하기
// https://programmers.co.kr/learn/courses/30/lessons/76501

using System.Linq;

public class Programmers76501
{
    public Programmers76501 ()
    {
        new Solution ().solution (new[] { 4, 7, 12 }, new[] { true, false, true });
        //new Solution().solution(new[] { 1, 2, 3 }, new[] { false, false, true });
    }

    //====================================//
    public class Solution
    {
        public int solution (int[] absolutes, bool[] signs)
        {
            // 부호에 따라 숫자 선택 후 총 합 계산
            int answer = absolutes
                .Zip (signs, (num, sign) => new { num, sign })
                .Select (tuple => tuple.sign ? tuple.num : -tuple.num)
                .Sum ();
            return answer;
        }
    }
    //====================================//
}