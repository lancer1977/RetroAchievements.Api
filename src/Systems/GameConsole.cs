namespace PolyhydraGames.RetroAchievements.Systems;

public class ConsoleIDsResponse : List<GameConsole>;
public record GameConsole(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Name")] string Name,
    [property: JsonPropertyName("IconURL")] string IconURL,
    [property: JsonPropertyName("Active")] bool Active,
    [property: JsonPropertyName("IsGameSystem")] bool IsGameSystem
);