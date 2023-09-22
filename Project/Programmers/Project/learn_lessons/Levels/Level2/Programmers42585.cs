
// 쇠막대기
// https://programmers.co.kr/learn/courses/30/lessons/42585

// 참조
// https://aig2029.tistory.com/114
// https://jaemin8852.tistory.com/188

public class Programmers42585
{
    public Programmers42585 ()
    {
        new Solution ().solution ("()(((()())(())()))(())");
    }

    //====================================//
    public class Solution
    {
        public int solution (string arrangement)
        {
            var str = arrangement.Replace ("()", "0");
            int stack = 0, count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    stack++;
                }
                else if (str[i] == '0')
                {
                    count += stack;
                }
                else if (str[i] == ')')
                {
                    count++;
                    stack--;
                }
            }
            return count;
        }
    }
    //====================================//
}