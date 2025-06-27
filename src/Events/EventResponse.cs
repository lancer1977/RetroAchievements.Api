namespace PolyhydraGames.RetroAchievements.Events; 
public record EventResponse(
    [property: JsonPropertyName("Achievement")] Achievement Achievement,
    [property: JsonPropertyName("Console")] Console Console,
    [property: JsonPropertyName("ForumTopic")] ForumTopic ForumTopic,
    [property: JsonPropertyName("Game")] Game Game,
    [property: JsonPropertyName("StartAt")] DateTime StartAt,
    [property: JsonPropertyName("TotalPlayers")] int TotalPlayers,
    [property: JsonPropertyName("Unlocks")] IReadOnlyList<Unlock> Unlocks,
    [property: JsonPropertyName("UnlocksCount")] int UnlocksCount,
    [property: JsonPropertyName("UnlocksHardcoreCount")] int UnlocksHardcoreCount
); 
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record Achievement(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("TrueRatio")] int TrueRatio,
    [property: JsonPropertyName("Type")] object Type,
    [property: JsonPropertyName("Author")] string Author,
    [property: JsonPropertyName("AuthorULID")] string AuthorULID,
    [property: JsonPropertyName("DateCreated")] string DateCreated,
    [property: JsonPropertyName("DateModified")] string DateModified
);

public record Console(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title
);

public record ForumTopic(
    [property: JsonPropertyName("ID")] int ID
);

public record Game(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title
);



public record Unlock(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("RAPoints")] int RAPoints,
    [property: JsonPropertyName("RASoftcorePoints")] int RASoftcorePoints,
    [property: JsonPropertyName("DateAwarded")] DateTime DateAwarded,
    [property: JsonPropertyName("HardcoreMode")] int HardcoreMode
);

