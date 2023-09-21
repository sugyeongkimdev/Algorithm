
// 문자열 다루기 기본
// https://programmers.co.kr/learn/courses/30/lessons/12918

public class Solution12918
{
    public Solution12918()
    {
        new Solution().solution("a234");
    }

    //====================================//
    public class Solution
    {
        public bool solution(string s)
        {
            return s.Length == 4 || s.Length == 6 ?
                int.TryParse(s, out int result) :
                false;
        }
    }
    //====================================//
}