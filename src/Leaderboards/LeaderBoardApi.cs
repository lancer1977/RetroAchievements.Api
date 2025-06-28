namespace PolyhydraGames.RetroAchievements.Leaderboards;

public class LeaderBoardApi : RestServiceBase, IRetroAchievementLeaderboardsApi
{
    public LeaderBoardApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client)
    {
    }

    public Task<GameLeaderboardsResult?> GetGameLeaderboards(int gameId, int count = 100, int offset = 0)
    {
        var url = GetBaseUrl().Id(gameId).Count(count).Offset(offset);
        return Get<GameLeaderboardsResult>(url);
    }
    public Task<LeaderboardEntriesResponse?> GetLeaderboardEntries(string leaderboardId, int count = 100, int offset = 0)
    {
        var url = GetBaseUrl().GameID(leaderboardId).Count(count).Offset(offset);
        return Get<LeaderboardEntriesResponse>(url);
    }
    public Task<UserGameLeaderboardsResponse?> GetUserGameLeaderboards(int gameId, string userName, int count = 200, int offset = 0)
    {
        var url = GetBaseUrl().Id(gameId).User(userName).Count(count).Offset(offset);
        return Get<UserGameLeaderboardsResponse>(url);
    }
}
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
