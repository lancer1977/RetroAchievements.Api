namespace PolyhydraGames.RetroAchievements.Users;

public record UserDetails(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("UserRank")] int UserRank,
    [property: JsonPropertyName("TotalScore")] int TotalScore,
    [property: JsonPropertyName("LastAward")] DateTime LastAward
);
