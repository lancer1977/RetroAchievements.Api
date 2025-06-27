using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RetroAchievements.Games;
public class RetroArchCheevoApi : RestServiceBase, IRetroArchGameApi
{
    public Dictionary<int, GameResponse> GameCache = new();

    public RetroArchCheevoApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client)
    {
    }

    public async ValueTask<GameResponse> GetGame(int gameId)
    {
        if (GameCache.TryGetValue(gameId, out var game))
            return game;
        var url = GetBaseUrl().Id(gameId);
        var result = await Get<GameResponse>(url);
        if (result != null && !string.IsNullOrEmpty(result.Title))
            GameCache[gameId] = result;
        return result;
    }

    public Task<GameExtendedResponse> GetGameExtended(int gameId, bool officialAchievements = true)
    { 
        var url = GetBaseUrl().Id(gameId).OfficialOnly(officialAchievements);
        return Get<GameExtendedResponse>(url);
    }

    public Task<HashResponse> GetGameHashes(int gameId )
    {
        var url = GetBaseUrl().Id(gameId);
        return Get<HashResponse>(url);
    }

    public Task<AchievementCountResponse> GetAchievementCount(int gameId)
    {
        var url = GetBaseUrl().Id(gameId);
        return Get<AchievementCountResponse>(url);
    }

    public Task<AchievementDistributionResponse> GetAchievementDistribution(int gameId, bool hardcoreOnly = true, bool officialAchievements = true)
    { 
        var url = GetBaseUrl().Id(gameId).H(hardcoreOnly).OfficialOnly(officialAchievements);
        return Get<AchievementDistributionResponse>(url);
    }

    public Task<GameRankAndScoreResponse> GetGameRankAndScore(int gameId, bool masters = false)
    {
        var url = GetBaseUrl().GameID(gameId).Masters(masters);
        return Get<GameRankAndScoreResponse>(url);
    }
}
