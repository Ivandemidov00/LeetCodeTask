using SolutionHelper;

namespace DetermineIfTwoEventsHaveConflict_2446_Solution;

public class SolutionOne : ISolution<Parameters, bool>
{
    public bool Resolve(Parameters parameters)
        => HaveConflict(parameters.event1, parameters.event2);
    
    // ReSharper disable once MemberCanBePrivate.Global
    public bool HaveConflict(string[] event1, string[] event2)
    {
        var firstFirstTime = event1[0].Split(":");
        var firstSecondTime = event1[1].Split(":");
        var secondFirstTime = event2[0].Split(":");
        var secondSecondTime = event2[1].Split(":");
        return GetTime(firstFirstTime[0]) * 60 + GetTime(firstFirstTime[1]) <=
               GetTime(secondSecondTime[0]) * 60 + GetTime(secondSecondTime[1]) &&
               GetTime(secondFirstTime[0]) * 60 + GetTime(secondFirstTime[1]) <=
               GetTime(firstSecondTime[0]) * 60 + GetTime(firstSecondTime[1]);
    }

    private static int GetTime(string time)
        => time switch
        {
            "01" => 1,
            "02" => 2,
            "03" => 3,
            "04" => 4,
            "05" => 5,
            "06" => 6,
            "07" => 7,
            "08" => 8,
            "09" => 9,
            "10" => 10,
            "11" => 11,
            "12" => 12,
            "13" => 13,
            "14" => 14,
            "15" => 15,
            "16" => 16,
            "17" => 17,
            "18" => 18,
            "19" => 19,
            "20" => 20,
            "21" => 21,
            "22" => 22,
            "23" => 23,
            "24" => 24,
            "25" => 25,
            "26" => 26,
            "27" => 27,
            "28" => 28,
            "29" => 29,
            "30" => 30,
            "31" => 31,
            "32" => 32,
            "33" => 33,
            "34" => 34,
            "35" => 35,
            "36" => 36,
            "37" => 37,
            "38" => 38,
            "39" => 39,
            "40" => 40,
            "41" => 41,
            "42" => 42,
            "43" => 43,
            "44" => 44,
            "45" => 45,
            "46" => 46,
            "47" => 47,
            "48" => 48,
            "49" => 49,
            "50" => 50,
            "51" => 51,
            "52" => 52,
            "53" => 53,
            "54" => 54,
            "55" => 55,
            "56" => 56,
            "57" => 57,
            "58" => 58,
            "59" => 59,
            _ => 0
        };
}