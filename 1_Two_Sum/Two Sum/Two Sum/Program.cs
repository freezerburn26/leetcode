/*

Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].


19 / 19 test cases passed.
Status: Accepted
Runtime: 749 ms
Submitted: 0 minutes ago


 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace Two_Sum
{

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] correctNums = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length-1)
                {
                    for (int k = i+1; k < nums.Length; k++)
                    {
                        if ((nums[i] + nums[k]) == target)
                        {
                            correctNums[0] = i;
                            correctNums[1] = k;
                            return correctNums;
                        }
                    }
                }
            }
            return correctNums;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution test = new Solution();
            int[] testnums = new int[2] { 2, 3 };
            int[] result = test.TwoSum(testnums, 5);

            Console.WriteLine(String.Join(",", result.Select(p => p.ToString()).ToArray()));
        }
    }
}
