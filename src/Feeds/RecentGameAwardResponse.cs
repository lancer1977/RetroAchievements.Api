namespace PolyhydraGames.RetroAchievements.Feeds;

public record RecentGameAwardResponse(
    int Count,
    int Total,
    IReadOnlyList<GameAward> Results);