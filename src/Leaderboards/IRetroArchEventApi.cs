 

namespace PolyhydraGames.RetroAchievements.Leaderboards;
public interface IRetroAchievementLeaderboardsApi
{
    Task<GameLeaderboardsResult?> GetGameLeaderboards(int gameId, int count = 100, int offset = 0);
    Task<LeaderboardEntriesResponse?> GetLeaderboardEntries(string leaderboardId, int count = 100, int offset = 0);
    Task<UserGameLeaderboardsResponse?> GetUserGameLeaderboards(int gameId, string userName, int count = 200, int offset = 0);
}
