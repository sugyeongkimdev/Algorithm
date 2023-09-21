
// 가운데 글자 가져오기
// https://programmers.co.kr/learn/courses/30/lessons/12901

public class Solution12903
{
    public Solution12903()
    {
        new Solution().solution("abcde");
        //new Solution().solution("qwer");
    }

    //====================================//
    public class Solution
    {
        public string solution(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }
            else if (s.Length % 2 == 0)
            {
                return s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString();
            }
            else
            {
                return s[s.Length / 2].ToString();
            }
        }
    }
    //====================================//
}


