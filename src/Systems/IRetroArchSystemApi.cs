namespace PolyhydraGames.RetroAchievements.Systems;
public interface IRetroArchSystemApi
{
    ValueTask<List<GameConsole>> GetConsoleIDs();
    ValueTask<List<GameAndHash>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false);
}