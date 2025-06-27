using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RetroAchievements.Feeds;

public class RetroArchFeedApi : RestServiceBase, IRetroArchFeedApi
{
    public RetroArchFeedApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }

    public Task<RecentGameAwardResponse?> GetRecentGameAwards(DateTime? date = null, int offset = 0, int count = 25, string kinds = null)
    {
        var url = GetBaseUrl().Date(date).Offset(offset).Count(count).Kinds(kinds);
        return Get<RecentGameAwardResponse>(url);
    }

    public Task<IEnumerable<ActiveClaim>?> GetClaims()
    {
        var url = GetBaseUrl();
        return Get<IEnumerable<ActiveClaim>>(url);
    }

    public Task<IEnumerable<RankedUser>?> GetTopTenUsers()
    {
        var url = GetBaseUrl();
        return Get<IEnumerable<RankedUser>>(url);
    }

    public Task<IEnumerable<ActiveClaim>?> GetActiveClaims()
    {
        var url = GetBaseUrl();
        return Get<IEnumerable<ActiveClaim>>(url);
    }
}