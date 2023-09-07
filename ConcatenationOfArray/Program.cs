using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

public class Solution
{
    /*
     * Given an integer array nums of length n, you want to create an array ans of 
     * length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

        Specifically, ans is the concatenation of two nums arrays.

        Return the array ans.
     */

    // main
    public static void Main(string[] args)
    {
        GetConcatenation(new int[] { 1,2,3});
    }

    public static void GetConcatenation(int[] nums)
    {
        int[] ans = new int[2*nums.Length];
        for (int i = 0; i < nums.Length; i++) 
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }

        for (int i = 0; i < ans.Length; i++)
        {
            Console.WriteLine(ans[i]);
        }

        
    }
}