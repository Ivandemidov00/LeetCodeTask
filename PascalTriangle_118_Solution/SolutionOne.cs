using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace PascalTriangle_118_Solution;

public class SolutionOne : ISolution<int, IList<IList<int>>>
{
    public IList<IList<int>> Resolve(int parameters)
        => Generate(parameters);
    
    public IList<IList<int>> Generate(int numRows)
    {
        var items = new List<IList<int>> { new List<int> { 1 } };

        while (items.Count != numRows)
        {
            var item = GetItem(items[^1]);
            items.Add(item);
        }

        return items;

        IList<int> GetItem(IList<int> beforeItem)
        {
            var item = new List<int> { 1 };
            for (int i = 0; i <= beforeItem.Count-2; i++)
            {
                item.Add(beforeItem[i] + beforeItem[i+1]);
            }
            item.Add(1);
            return item;
        }
    }
    
}