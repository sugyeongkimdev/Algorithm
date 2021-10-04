
// 가장 큰 수
// https://programmers.co.kr/learn/courses/30/lessons/42839
// https://jar100.tistory.com/16

using System.Collections.Generic;
using System.Linq;

public class Solution42839
{
    public Solution42839()
    {
        new Solution().solution("011");
    }

    //====================================//
    public class Solution
    {
        public int solution(string numbers)
        {
            List<int> primeList = new List<int>();
            List<int> permutationList = new List<int>();

            int MAX = 10000000;
            int value = 0;

            var list = new bool[MAX + 1];

            // 에라토스테네스의 채(소수구하기)
            for (int i = 2; i <= MAX; i++)
            {
                if (list[i] == false)
                {
                    primeList.Add(i);
                    for (int j = 0; j <= MAX; j += i)
                    {
                        list[j] = true;
                    }
                }
            }

            // 순열
            var charlist = numbers.ToArray();
            for (int i = 1; i <= charlist.Length; i++)
            {
                permutationList.AddRange(perm(charlist, 0, i));
            }
            permutationList = permutationList.Distinct().ToList();

            foreach (var item in permutationList)
            {
                if (primeList.Contains(item))
                {
                    value++;
                }
            }

            return value;
        }

        public List<int> perm(char[] arr, int depth, int k)
        {
            List<int> permutationList = new List<int>();
            if (depth == k)
            {
                // 한번 depth 가 k로 도달하면 사이클이 돌았음. 출력함.
                permutationList.Add(print(arr, k));
                return permutationList;
            }
            else
            {
                for (int i = depth; i < arr.Length; i++)
                {
                    swap(arr, i, depth);
                    permutationList.AddRange(perm(arr, depth + 1, k));
                    swap(arr, i, depth);
                }
            }
            return permutationList;
        }

        public void swap(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public int print(char[] arr, int k)
        {
            string str = "";
            for (int i = 0; i < k; i++)
            {
                str += arr[i];
            }
            return int.Parse(str);
        }
    }
    //====================================//
}