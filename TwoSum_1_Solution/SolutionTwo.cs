namespace TwoSum_1_Solution;

public class SolutionTwo
{
    public int[] TwoSum(int[] nums, int target)
    {
        return CheckCountArray(nums, target);

        int[] CheckCountArray(int[] nums, int target)
            => nums.Length == 2 ? new[] { 0, 1 } : FindPosition(nums, target);
                
        int [] FindPosition(int[] nums, int target)
        {
            var response = new Dictionary<int, ushort>(nums.Length);
            for (ushort i = 0; i < nums.Length; i++)
            {
                if (response.TryGetValue(target - nums[i], out var j))
                {
                    return new int[] { i, j };
                }
                response[nums[i]] = i;
            }

            return null;
        }
    }
    
}