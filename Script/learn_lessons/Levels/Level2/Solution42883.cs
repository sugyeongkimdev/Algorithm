
// 큰 수 만들기
// https://programmers.co.kr/learn/courses/30/lessons/42883

using System.Text;

public class Solution42883
{
    public Solution42883()
    {
        new Solution().solution("1231234", 3);
    }

    //====================================//
    public class Solution
    {
        public string solution(string number, int k)
        {
            int idx = 0;
            char max;
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < number.Length - k; i++)
            {
                max = '0';
                for (int j = idx; j <= k + i; j++)
                {
                    if (max < number[j])
                    {
                        max = number[j];
                        idx = j + 1;
                    }
                }
                str.Append(max);
            }
            return str.ToString();
        }
    }
    //====================================//
}