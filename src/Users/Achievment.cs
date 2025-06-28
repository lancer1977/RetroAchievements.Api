namespace PolyhydraGames.RetroAchievements.Users
{
    public record Achievment(
        [property: JsonPropertyName("ID")] int ID,
        [property: JsonPropertyName("NumAwarded")] int NumAwarded,
        [property: JsonPropertyName("NumAwardedHardcore")] int NumAwardedHardcore,
        [property: JsonPropertyName("Title")] string Title,
        [property: JsonPropertyName("Description")] string Description,
        [property: JsonPropertyName("Points")] int Points,
        [property: JsonPropertyName("TrueRatio")] int TrueRatio,
        [property: JsonPropertyName("Author")] string Author,
        [property: JsonPropertyName("AuthorULID")] string AuthorULID,
        [property: JsonPropertyName("DateModified")] string DateModified,
        [property: JsonPropertyName("DateCreated")] string DateCreated,
        [property: JsonPropertyName("BadgeName")] string BadgeName,
        [property: JsonPropertyName("DisplayOrder")] int DisplayOrder,
        [property: JsonPropertyName("MemAddr")] string MemAddr,
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("DateEarnedHardcore")] string DateEarnedHardcore,
        [property: JsonPropertyName("DateEarned")] string DateEarned
    );
}