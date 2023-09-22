
// 행렬의 덧셈
// https://programmers.co.kr/learn/courses/30/lessons/12948

public class Programmers12950
{
    public Programmers12950 ()
    {
        new Solution ().solution (new[,] { { 1, 2 }, { 1, 2 } }, new[,] { { 3, 4 }, { 5, 6 } });
    }

    //====================================//
    public class Solution
    {
        public int[,] solution (int[,] arr1, int[,] arr2)
        {
            var arr = new int[arr1.GetLength (0), arr1.GetLength (1)];
            for (int i = 0; i < arr1.GetLength (0); i++)
            {
                for (int j = 0; j < arr1.GetLength (1); j++)
                {
                    arr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return arr;
        }
    }
    //====================================//
}