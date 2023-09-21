
// 콜라츠 추측
// https://programmers.co.kr/learn/courses/30/lessons/12943

public class Solution12943
{
    public Solution12943()
    {
        new Solution().solution(626331);
    }

    //====================================//
    public class Solution
    {
        public int solution(int num)
        {
            long val = num;
            for (int i = 0; i < 500; i++)
            {
                if (val == 1)
                {
                    return i;
                }
                val = val % 2 == 0 ? val / 2 : val * 3 + 1;
            }
            return -1;
        }
    }
    //====================================//
}