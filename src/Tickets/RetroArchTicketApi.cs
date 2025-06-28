using PolyhydraGames.RetroAchievements.Systems;

namespace PolyhydraGames.RetroAchievements.Tickets;

public class RetroAchievementTicketApi : RestServiceBase, IRetroArchTicketApi
{
    private List<GameAndHashResponse> _cache;
    public RetroAchievementTicketApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }
    public Task<IReadOnlyList<GameConsole>> GetConsoleIDs()
    {
        var url = GetBaseUrl();
        return Get<IReadOnlyList<GameConsole>>(url);
    }

    public async Task<IReadOnlyList<GameAndHashResponse>> GetGameList(int systemId, bool gamesWithAchievementsOnly = false, bool returnHashes = false, bool resetCache = false)
    {
        if (_cache != null) return _cache;
        var url = GetBaseUrl().Id(systemId).ParamBool("f", gamesWithAchievementsOnly).ParamBool("h", returnHashes);
        var result = await Get<IReadOnlyList<GameAndHashResponse>>(url);
        if (result != null && result.Any()) ;
        {
            _cache = result.ToList();
        }
        return _cache;
    }

    public Task<TicketData> GetTicketDataById(int id)
    {
        var url = GetBaseUrl("GetTicketData").Id(id);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetTicketData(int id, int count = 10, int offset = 0)
    {
        var url = GetBaseUrl().Id(id);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetRecentTicketData(int id, int count = 10, int offset = 0)
    {
        var url = GetBaseUrl("GetTicketData").Id(id).Count(10).Offset(0);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetGameTicketStats(int id)
    {
        var url = GetBaseUrl("GetTicketData").Id(id);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetDeveloperTicketData(string developerUsername)
    {
        var url = GetBaseUrl("GetTicketData").ParamString("u", developerUsername);
        return Get<TicketData>(url);
    }

    public Task<TicketData> GetAchievementTicketData(int achievementId)
    {
        var url = GetBaseUrl("GetTicketData").Id(achievementId);
        return Get<TicketData>(url);
    }
}