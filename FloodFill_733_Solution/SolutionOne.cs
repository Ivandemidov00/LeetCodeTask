using SolutionHelper;

namespace FloodFill_733_Solution;

public class SolutionOne : ISolution<Parameter, int[][]>
{
    private static readonly ValueTuple<sbyte, sbyte> First = (0, -1);
    private static readonly ValueTuple<sbyte, sbyte> Second = (1, 0);
    private static readonly ValueTuple<sbyte, sbyte> Three = (0, 1);
    private static readonly ValueTuple<sbyte, sbyte> Four = (-1, 0);

    public int[][] Resolve(Parameter parameters)
    {
        return FloodFill(parameters.Image, parameters.Sc, parameters.Sc, parameters.Color);

        int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (color == image[sr][sc])
            {
                return image;
            }

            int testingColor = image[sr][sc];
            Queue<ValueTuple<int, int>> queue = new();
            queue.Enqueue((sr, sc));
            while (queue.Any())
            {
                (int, int) item = queue.Dequeue();
                if (item.Item1 < 0 || item.Item2 < 0 || item.Item1 >= image.Length
                    || item.Item2 >= image[0].Length || image[item.Item1][item.Item2] != testingColor)
                {
                    continue;
                }

                image[item.Item1][item.Item2] = color;
                queue.Enqueue((First.Item1 + item.Item1, First.Item2 + item.Item2));
                queue.Enqueue((Second.Item1 + item.Item1, Second.Item2 + item.Item2));
                queue.Enqueue((Three.Item1 + item.Item1, Three.Item2 + item.Item2));
                queue.Enqueue((Four.Item1 + item.Item1, Four.Item2 + item.Item2));
            }

            return image;
        }
    }
}