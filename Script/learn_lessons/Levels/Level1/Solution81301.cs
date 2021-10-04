
// 숫자 문자열과 영단어
// https://programmers.co.kr/learn/courses/30/lessons/81301

public class Solution81301
{
    public Solution81301()
    {
        new Solution().solution("one4seveneight");
        //new Solution().solution("23four5six7");
        //new Solution().solution("2three45sixseven");
        //new Solution().solution("123");
    }

    //====================================//
    public class Solution
    {
        private string[] NumStrArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        public int solution(string s)
        {
            for (int i = 0; i < NumStrArr.Length; i++)
            {
                s = s.Replace(NumStrArr[i], i.ToString());
            }
            return int.Parse(s);
        }
    }
    //====================================//
}


