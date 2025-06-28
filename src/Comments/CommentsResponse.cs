namespace PolyhydraGames.RetroAchievements.Comments;

public record CommentsResponse(
    [property: JsonPropertyName("Count")] int Count,
    [property: JsonPropertyName("Total")] int Total,
    [property: JsonPropertyName("Results")] IReadOnlyList<Comment> Results
);

public record Comment(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("Submitted")] DateTime Submitted,
    [property: JsonPropertyName("CommentText")] string CommentText
);