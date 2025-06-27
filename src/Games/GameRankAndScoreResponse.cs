namespace PolyhydraGames.RetroAchievements.Games;

public class GameRankAndScoreResponse : List<GameRankAndScore>;
public record GameRankAndScore(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("NumAchievements")] int NumAchievements,
    [property: JsonPropertyName("TotalScore")] int TotalScore,
    [property: JsonPropertyName("LastAward")] DateTime LastAward
);

// Assuming GameExtended and GameExtendedAchievementEntity are already defined elsewhere