using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace UniquePaths_62_Solution;

public class SolutionOne : ISolution<Parameters, int>
{
    public int Resolve(Parameters parameter)
        => UniquePaths(parameter.m, parameter.n);
    
    public int UniquePaths(int m, int n)
    {
        Dictionary<Cell, int> pathInPositions = new ();
        return GoToZero(m, n, pathInPositions);
    }

    public readonly struct Cell : IEquatable<Cell>
    {
        private readonly int _col;
        private readonly int _row;
        public Cell(int col, int row)
        {
            _col = col;
            _row = row;
        }

        public bool Equals(Cell other)
            => _col == other._col && _row == other._row || _col == other._row && _row == other._col;

        public override bool Equals(object? obj)
        {
            return obj is Cell other && Equals(other);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + _col.GetHashCode();
            hash = hash * 23 + _row.GetHashCode();
            return hash;
        }

        public static bool operator ==(Cell left, Cell right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Cell left, Cell right)
        {
            return !(left == right);
        }
    }
    private static int GoToZero(int m, int n, IDictionary<Cell, int> pathInPositions)
    {
        while (true)
        {
            switch (m, n)
            {
                case (1, 1):
                    return 1;
                case (1, > 1) :
                    {
                        pathInPositions[new Cell(m,n)] = 1; 
                        n -= 1;
                        continue;
                    }
                case (> 1, 1):
                    {
                        pathInPositions[new Cell(m,n)] = 1;
                        m -= 1;
                        continue;
                    }
                default:
                    {
                        if (pathInPositions.ContainsKey(new Cell(m,n)))
                            return pathInPositions[new Cell(m,n)];
                        var copyN = n;
                        var copyM = m;
                        var sumPath = GoToZero(m, --n, pathInPositions) + GoToZero(--m, copyN, pathInPositions);
                        pathInPositions[new Cell(copyM,copyN)] = sumPath; 
                        return sumPath;
                    }
            }
        }
    }

    private static int Go(int m, int n)
    {
        
        switch(m, n)
        {
            case (-1, -1): return 1;
            case (-1, < -1):
                {
                    return Go(m, n + 1);
                }
            case (< -1, -1):
                {
                    return Go(m+1, n);
                }
            default:
                {
                    var copyN = n;
                    var r = Go(m, ++n);
                    var h = Go(++m, copyN);
                    return r + h;
                }
        }
    }
}