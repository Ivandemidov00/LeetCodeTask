using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace PascalTriangle_118_Solution;

public class SolutionOne : ISolution<int, IList<IList<int>>>
{
    public IList<IList<int>> Resolve(int parameter)
        => Generate(parameter);
    
    public IList<IList<int>> Generate(int numRows)
    {
        var resultedList = new List<IList<int>>(){new List<int>(){1}};
        for (int i = 1; i < 6; i++)
        {
            resultedList.Add(GetItem(resultedList[i-1]));
        }

        return resultedList;

        IList<int> GetItem(IList<int> beforeItem)
        {
            var item = new List<int> { beforeItem[0] };
            for (int i = 1; i < beforeItem.Count; i++)
            {
                item.Add(beforeItem[i] + beforeItem[i+1]);
            }
            item.Add(beforeItem.Count - 1);
            return item;
        }
    }
    
}