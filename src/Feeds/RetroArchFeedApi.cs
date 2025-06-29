using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RetroAchievements.Feeds;

public class RetroAchievementFeedApi : RestServiceBase, IRetroAchievementFeedApi
{
    public RetroAchievementFeedApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }

    public Task<RecentGameAwardResponse?> GetRecentGameAwards(DateTime? date = null, int offset = 0, int count = 25, string kinds = null)
    {
        var url = GetBaseUrl().Date(date).Offset(offset).Count(count).Kinds(kinds);
        return Get<RecentGameAwardResponse>(url);
    }

    public Task<IReadOnlyList<ActiveClaim>?> GetClaims()
    {
        var url = GetBaseUrl();
        return Get<IReadOnlyList<ActiveClaim>>(url);
    }

    public Task<IReadOnlyList<RankedUser>?> GetTopTenUsers()
    {
        var url = GetBaseUrl();
        return Get<IReadOnlyList<RankedUser>>(url);
    }

    public Task<IReadOnlyList<ActiveClaim>?> GetActiveClaims()
    {
        var url = GetBaseUrl();
        return Get<IReadOnlyList<ActiveClaim>>(url);
    }
}