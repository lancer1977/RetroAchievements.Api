namespace PolyhydraGames.RetroAchievements.Systems;
public interface IRetroArchSystemApi
{
    ValueTask<ConsoleIDsResponse> GetConsoleIDs();
    ValueTask<GameAndHashResponse> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false);
}