public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
{
    var response = new List<int>();
    

    var distinctRanked = ranked.Distinct().ToList();
    distinctRanked.Sort((a, b) => b.CompareTo(a)); 
    
    int rankIndex = distinctRanked.Count - 1;
    

    foreach (var score in player)
    {
        while (rankIndex >= 0 && score >= distinctRanked[rankIndex])
        {
            rankIndex--;
        }

        response.Add(rankIndex + 2);
    }

    return response;
}
