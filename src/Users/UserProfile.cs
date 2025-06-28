public record UserProfile(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("UserPic")] string UserPic,
    [property: JsonPropertyName("MemberSince")] DateTime MemberSince,
    [property: JsonPropertyName("RichPresenceMsg")] string RichPresenceMsg,
    [property: JsonPropertyName("LastGameID")] int LastGameID,
    [property: JsonPropertyName("ContribCount")] int ContribCount,
    [property: JsonPropertyName("ContribYield")] int ContribYield,
    [property: JsonPropertyName("TotalPoints")] int TotalPoints,
    [property: JsonPropertyName("TotalSoftcorePoints")] int TotalSoftcorePoints,
    [property: JsonPropertyName("TotalTruePoints")] int TotalTruePoints,
    [property: JsonPropertyName("Permissions")] int Permissions,
    [property: JsonPropertyName("Untracked")] int Untracked,
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("UserWallActive")] bool UserWallActive,
    [property: JsonPropertyName("Motto")] string Motto
);
