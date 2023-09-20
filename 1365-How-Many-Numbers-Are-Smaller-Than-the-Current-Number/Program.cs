/*
Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it.
That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
Return the answer in an array.
 */

public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        // nuevo arreglo respuesta
        int[] respuesta = new int[nums.Length];
        int longitud = 0;

        foreach (int num in nums)
        {
            int smallers = CountSmallers(num, nums, longitud);
            {
                respuesta[longitud++] = smallers;
            }
        }
        return respuesta;
    }

    public int CountSmallers(int num, int[] arr, int start)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < num)
            {
                count++;
            }
        }

        return count;
    }
}