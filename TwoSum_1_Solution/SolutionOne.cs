public class SolutionOne
{
    public int[] TwoSum(int[] nums, int target)
    {
        var response = new [] {0,1};
        var length = nums.Length;
        if (length == 2)
            return response;
        for (var i = 0; i < length - 1; i++)
        {
            if(nums[i] == 0)
                for (var j = i + 1; j < length; j++)
                {
                    if(nums[j] != target) continue;
                    response[0] = i;
                    response[1] = j;
                    return response;
                        
                }

            if (nums[i] > 0)
            {

                for (var j = i + 1; j < length; j++)
                {
                    if (nums[j] > target)
                    {
                    }
                    else
                    {
                        if (nums[i] + nums[j] != target) continue;
                        response[0] = i;
                        response[1] = j;
                        return response;
                    }
                }
            }
            else
            {
                for (var j = i + 1; j < length; j++)
                {
                    
                    if (nums[i] + nums[j] != target) continue;
                    response[0] = i;
                    response[1] = j;
                    return response;
                    
                }
            }
        }

        return response;
    }
}