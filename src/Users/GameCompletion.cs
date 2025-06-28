namespace PolyhydraGames.RetroAchievements.Users;
public record GameCompletion(
    [property: JsonPropertyName("GameID")] int GameID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("ImageIcon")] string ImageIcon,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("MaxPossible")] int MaxPossible,
    [property: JsonPropertyName("NumAwarded")] int NumAwarded,
    [property: JsonPropertyName("PctWon")] string PctWon,
    [property: JsonPropertyName("HardcoreMode")] string HardcoreMode
);