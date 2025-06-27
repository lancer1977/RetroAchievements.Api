
namespace PolyhydraGames.RetroAchievements.Systems;

public class RetroArchSystemApi : RestServiceBase, IRetroArchSystemApi
{
    private static Dictionary<int, List<GameAndHash>> _cache = new Dictionary<int, List<GameAndHash>>();
    public static List<GameConsole>? ConsolesCache { get; private set; }
    public RetroArchSystemApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }
    public async ValueTask<List<GameConsole>> GetConsoleIDs()
    {
        if (ConsolesCache != null && ConsolesCache.Any()) return ConsolesCache;
        var url = GetBaseUrl();
        var results = await Get<List<GameConsole>>(url);
        if (results != null && results.Any())
        {
            ConsolesCache = results;
        }

        return ConsolesCache ?? [];
    }

    public async ValueTask<List<GameAndHash>> GetGameList(int systemId, bool withAchievementsOnly = false, bool returnHashes = false, bool resetCache = false)
    {
        if (resetCache) _cache.Remove(systemId);
        if (_cache.TryGetValue(systemId, out var list)) return list;
        var url = GetBaseUrl().Id(systemId).F(withAchievementsOnly).H(returnHashes);
        var result = await Get<List<GameAndHash>>(url);
        if (result != null && result.Any())
        {
            _cache[systemId] = result.ToList();
        }
        return _cache[systemId];
    }
}