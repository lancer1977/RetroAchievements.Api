namespace PolyhydraGames.RetroAchievements.Systems;

public class GameAndHashResponse : List<GameAndHash> { };

public record GameAndHash(
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("ImageIcon")] string ImageIcon,
    [property: JsonPropertyName("NumAchievements")] int NumAchievements,
    [property: JsonPropertyName("NumLeaderboards")] int NumLeaderboards,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("DateModified")] DateTime DateModified,
    [property: JsonPropertyName("ForumTopicID")] int ForumTopicID,
    [property: JsonPropertyName("Hashes")] IReadOnlyList<string> Hashes
);