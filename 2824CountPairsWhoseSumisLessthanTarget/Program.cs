public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {

        int conteo = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = 0; j < nums.Count; j++)
            {
                if (0 <= i && i < j && j < nums.Count && nums[i] + nums[j] < target)
                {
                    conteo++;
                }
            }
        }
        return conteo;
    }
}