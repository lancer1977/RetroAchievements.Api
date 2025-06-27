namespace PolyhydraGames.RetroAchievements.Achievements;
 
public record Achievement(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("TrueRatio")] int TrueRatio,
    [property: JsonPropertyName("Author")] string Author,
    [property: JsonPropertyName("AuthorULID")] string AuthorULID,
    [property: JsonPropertyName("DateCreated")] string DateCreated,
    [property: JsonPropertyName("DateModified")] string DateModified,
    [property: JsonPropertyName("Type")] string Type
);

public record Console(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title
);

public record Game(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title
);

public record AchievementUnlocksResponse(
    [property: JsonPropertyName("Achievement")] Achievement Achievement,
    [property: JsonPropertyName("Console")] Console Console,
    [property: JsonPropertyName("Game")] Game Game,
    [property: JsonPropertyName("UnlocksCount")] int UnlocksCount,
    [property: JsonPropertyName("UnlocksHardcoreCount")] int UnlocksHardcoreCount,
    [property: JsonPropertyName("TotalPlayers")] int TotalPlayers,
    [property: JsonPropertyName("Unlocks")] IReadOnlyList<Unlock> Unlocks
);

public record Unlock(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("RAPoints")] int RAPoints,
    [property: JsonPropertyName("RASoftcorePoints")] int RASoftcorePoints,
    [property: JsonPropertyName("DateAwarded")] DateTime DateAwarded,
    [property: JsonPropertyName("HardcoreMode")] int HardcoreMode
);
 