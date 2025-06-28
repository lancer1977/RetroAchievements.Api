namespace PolyhydraGames.RetroAchievements.Users; 
public record ActiveClaim(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("GameID")] int GameID,
    [property: JsonPropertyName("GameTitle")] string GameTitle,
    [property: JsonPropertyName("GameIcon")] string GameIcon,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("ClaimType")] int ClaimType,
    [property: JsonPropertyName("SetType")] int SetType,
    [property: JsonPropertyName("Status")] int Status,
    [property: JsonPropertyName("Extension")] int Extension,
    [property: JsonPropertyName("Special")] int Special,
    [property: JsonPropertyName("Created")] DateTime Created,
    [property: JsonPropertyName("DoneTime")] DateTime DoneTime,
    [property: JsonPropertyName("Updated")] DateTime Updated,
    [property: JsonPropertyName("UserIsJrDev")] int UserIsJrDev,
    [property: JsonPropertyName("MinutesLeft")] int MinutesLeft
);
 