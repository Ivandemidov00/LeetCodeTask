using SolutionHelper;
// ReSharper disable MemberCanBePrivate.Global

namespace IntegerToRoman_12_Solution;

public class SolutionOne : ISolution<int,string>
{
    public string Resolve(int parameter)
        => IntToRoman(parameter);

    public string IntToRoman(int num)
        => num switch
        {
            >= 1000 => "M" + IntToRoman(num - 1000),
            >= 500 => num >= 900 ? ("CM" + IntToRoman(num - 900)) : ("D" + IntToRoman(num - 500)),
            >= 100 => num >= 400 ? ("CD" + IntToRoman(num - 400)) : ("C" + IntToRoman(num - 100)),
            >= 50 => num >= 90 ? ("XC" + IntToRoman(num - 90)) : ("L" + IntToRoman(num - 50)),
            >= 10 => num >= 40 ? ("XL" + IntToRoman(num - 40)) : ("X" + IntToRoman(num - 10)),
            >= 5 => num == 9 ? "IX" : "V" + IntToRoman(num - 5),
            > 0 => num == 4 ? "IV" : "I" + IntToRoman(num - 1),
            _ => ""
        };
}