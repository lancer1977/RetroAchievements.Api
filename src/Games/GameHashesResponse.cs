using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RetroAchievements.Games;
public class GameHashesResponse
{
    public List<GameHash> Results { get; set; }
}

public record GameHash(
    [property: JsonPropertyName("MD5")] string MD5,
    [property: JsonPropertyName("Name")] string Name,
    [property: JsonPropertyName("Labels")] IReadOnlyList<string> Labels,
    [property: JsonPropertyName("PatchUrl")] string PatchUrl
);