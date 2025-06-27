using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RetroAchievements.Feeds;

public interface IRetroArchFeedApi
{
    Task<RecentGameAwardResponse?> GetRecentGameAwards(DateTime? date = null, int offset = 0, int count = 25, string kinds = null);
    Task<IEnumerable<ActiveClaim>?> GetActiveClaims();
    Task<IEnumerable<ActiveClaim>?> GetClaims();
    Task<IEnumerable<RankedUser>?> GetTopTenUsers();
}

