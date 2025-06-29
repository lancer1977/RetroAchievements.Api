

namespace PolyhydraGames.RetroAchievements.Games; public interface IRetroAchievementGameApi
{
    ValueTask<GameResponse> GetGame(int gameID);
    Task<GameExtendedResponse> GetGameExtended(int gameID, bool officialAchievements = false);
    Task<GameHashesResponse> GetGameHashes(int gameId);
    Task<AchievementCountResponse> GetAchievementCount(int gameId);
    Task<AchievementDistributionResponse> GetAchievementDistribution(int gameId, bool allUnlocks = true, bool officialAchievements = true);
    Task<GameRankAndScoreResponse> GetGameRankAndScore(int gameID, bool masters = false);
}