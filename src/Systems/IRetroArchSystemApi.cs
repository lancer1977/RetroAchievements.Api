namespace PolyhydraGames.RetroAchievements.Systems;
public interface IRetroAchievementSystemApi
{
    ValueTask<ConsoleIDsResponse> GetConsoleIDs();
    ValueTask<GameAndHashResponse> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false);
}