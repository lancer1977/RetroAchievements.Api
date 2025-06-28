namespace PolyhydraGames.RetroAchievements.Leaderboards;
public record GameLeaderboardsResult(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("RankAsc")] bool RankAsc,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Format")] string Format,
    [property: JsonPropertyName("Author")] string Author,
    [property: JsonPropertyName("AuthorULID")] string AuthorULID,
    [property: JsonPropertyName("TopEntry")] TopEntry TopEntry
);
public record LeaderboardEntryResult(
    [property: JsonPropertyName("Rank")] int Rank,
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("Score")] int Score,
    [property: JsonPropertyName("FormattedScore")] string FormattedScore,
    [property: JsonPropertyName("DateSubmitted")] DateTime DateSubmitted
);

public record LeaderboardEntriesResponse(
    [property: JsonPropertyName("Count")] int Count,
    [property: JsonPropertyName("Total")] int Total,
    [property: JsonPropertyName("Results")] IReadOnlyList<LeaderboardEntryResult> Results
);


public record GameLeaderboards(
    [property: JsonPropertyName("Count")] int Count,
    [property: JsonPropertyName("Total")] int Total,
    [property: JsonPropertyName("Results")] List<GameLeaderboardsResult> Results
);

public record TopEntry(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("Score")] string Score,
    [property: JsonPropertyName("FormattedScore")] string FormattedScore
);

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record UserGameLeaderboardsResult(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("RankAsc")] bool RankAsc,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Format")] string Format,
    [property: JsonPropertyName("UserEntry")] UserEntry UserEntry
);

public record UserGameLeaderboardsResponse(
    [property: JsonPropertyName("Count")] int Count,
    [property: JsonPropertyName("Total")] int Total,
    [property: JsonPropertyName("Results")] IReadOnlyList<UserGameLeaderboardsResult> Results
);

public record UserEntry(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("Score")] int Score,
    [property: JsonPropertyName("FormattedScore")] string FormattedScore,
    [property: JsonPropertyName("Rank")] int Rank,
    [property: JsonPropertyName("DateUpdated")] DateTime DateUpdated
);

