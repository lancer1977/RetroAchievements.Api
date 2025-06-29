using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RetroAchievements.Feeds;

public interface IRetroAchievementFeedApi
{
    Task<RecentGameAwardResponse?> GetRecentGameAwards(DateTime? date = null, int offset = 0, int count = 25, string kinds = null);
    Task<IReadOnlyList<ActiveClaim>?> GetActiveClaims();
    Task<IReadOnlyList<ActiveClaim>?> GetClaims();
    Task<IReadOnlyList<RankedUser>?> GetTopTenUsers();
}

