namespace PolyhydraGames.RetroAchievements.Users;

public record Achievement(
    [property:JsonPropertyName("Date")] DateTime Date,
    [property: JsonPropertyName("HardcoreMode")] int HardcoreMode,
    [property: JsonPropertyName("AchievementID")] int AchievementID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("BadgeName")] string BadgeName,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("TrueRatio")] int TrueRatio,
    [property: JsonPropertyName("Type")] object Type,
    [property: JsonPropertyName("Author")] string Author,
    [property: JsonPropertyName("AuthorULID")] string AuthorULID,
    [property: JsonPropertyName("GameTitle")] string GameTitle,
    [property: JsonPropertyName("GameIcon")] string GameIcon,
    [property: JsonPropertyName("GameID")] int GameID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("BadgeURL")] string BadgeURL,
    [property: JsonPropertyName("GameURL")] string GameURL);