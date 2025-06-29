
namespace PolyhydraGames.RetroAchievements.Systems;

public class RetroAchievementSystemApi : RestServiceBase, IRetroAchievementSystemApi
{
    private static Dictionary<int, GameAndHashResponse> _cache = new Dictionary<int, GameAndHashResponse>();
    public static ConsoleIDsResponse? ConsolesCache { get; private set; }
    public RetroAchievementSystemApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }
    public async ValueTask<ConsoleIDsResponse> GetConsoleIDs()
    {
        if (ConsolesCache != null && ConsolesCache.Any()) return ConsolesCache;
        var url = GetBaseUrl();
        var results = await Get<ConsoleIDsResponse>(url);
        if (results != null && results.Any())
        {
            ConsolesCache = results;
        }

        return ConsolesCache ?? [];
    }

    public async ValueTask<GameAndHashResponse> GetGameList(int systemId, bool withAchievementsOnly = false, bool returnHashes = false, bool resetCache = false)
    {
        if (resetCache) _cache.Remove(systemId);
        if (_cache.TryGetValue(systemId, out var list)) return list;
        var url = GetBaseUrl().Id(systemId).F(withAchievementsOnly).H(returnHashes);
        var result = await Get<GameAndHashResponse>(url);
        if (result != null && result.Any())
        {
            _cache[systemId] = result;
        }
        return _cache[systemId];
    }
}