namespace TwoSum_1_Solution;

public class SolutionTwo
{
    public int[] TwoSum(int[] nums, int target)
    {
        return CheckCountArray(nums, target);

        int[] CheckCountArray(int[] nums, int target)
        {
            return nums.Length == 2 ? new[] { 0, 1 } : FindPosition(nums, target);
        }

        int[] FindPosition(int[] nums, int target)
        {
            Dictionary<int, ushort>? response = new(nums.Length);
            for (ushort i = 0; i < nums.Length; i++)
            {
                if (response.TryGetValue(target - nums[i], out ushort j))
                {
                    return new int[] { i, j };
                }

                response[nums[i]] = i;
            }

            return null;
        }
    }
}