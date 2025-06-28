namespace PolyhydraGames.RetroAchievements.Users;


public record GetUserSummaryResponse(
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("ULID")] string ULID,
    [property: JsonPropertyName("MemberSince")] DateTime MemberSince,
    [property: JsonPropertyName("LastActivity")] LastActivity LastActivity,
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
    [property: JsonPropertyName("UserWallActive")] int UserWallActive,
    [property: JsonPropertyName("Motto")] string Motto,
    [property: JsonPropertyName("Rank")] int? Rank,
    [property: JsonPropertyName("RecentlyPlayedCount")] int RecentlyPlayedCount,
    [property: JsonPropertyName("RecentlyPlayed")] IReadOnlyList<RecentlyPlayed> RecentlyPlayed,
    [property: JsonPropertyName("Awarded")] Awarded Awarded,
    [property: JsonPropertyName("RecentAchievements")] RecentAchievements RecentAchievements,
    [property: JsonPropertyName("LastGame")] LastGame LastGame,
    [property: JsonPropertyName("UserPic")] string UserPic,
    [property: JsonPropertyName("TotalRanked")] int TotalRanked,
    [property: JsonPropertyName("Status")] string Status
);

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
public record Award(
    [property: JsonPropertyName("NumPossibleAchievements")] int NumPossibleAchievements,
    [property: JsonPropertyName("PossibleScore")] int PossibleScore,
    [property: JsonPropertyName("NumAchieved")] int NumAchieved,
    [property: JsonPropertyName("ScoreAchieved")] int ScoreAchieved,
    [property: JsonPropertyName("NumAchievedHardcore")] int NumAchievedHardcore,
    [property: JsonPropertyName("ScoreAchievedHardcore")] int ScoreAchievedHardcore
);

 
// This record represents an achievement that has been awarded to a user.
public record AchievementLite(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("GameID")] int GameID,
    [property: JsonPropertyName("GameTitle")] string GameTitle,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("Type")] object Type,
    [property: JsonPropertyName("BadgeName")] string BadgeName,
    [property: JsonPropertyName("IsAwarded")] string IsAwarded,
    [property: JsonPropertyName("DateAwarded")] DateTime DateAwarded,
    [property: JsonPropertyName("HardcoreAchieved")] int HardcoreAchieved
);

public class Awarded : Dictionary<string, Award>;

public record LastActivity(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("timestamp")] object Timestamp,
    [property: JsonPropertyName("lastupdate")] object Lastupdate,
    [property: JsonPropertyName("activitytype")] object Activitytype,
    [property: JsonPropertyName("User")] string User,
    [property: JsonPropertyName("data")] object Data,
    [property: JsonPropertyName("data2")] object Data2
);

public record LastGame(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("ForumTopicID")] int ForumTopicID,
    [property: JsonPropertyName("Flags")] int Flags,
    [property: JsonPropertyName("ImageIcon")] string ImageIcon,
    [property: JsonPropertyName("ImageTitle")] string ImageTitle,
    [property: JsonPropertyName("ImageIngame")] string ImageIngame,
    [property: JsonPropertyName("ImageBoxArt")] string ImageBoxArt,
    [property: JsonPropertyName("Publisher")] string Publisher,
    [property: JsonPropertyName("Developer")] string Developer,
    [property: JsonPropertyName("Genre")] string Genre,
    [property: JsonPropertyName("Released")] string Released,
    [property: JsonPropertyName("ReleasedAtGranularity")] string ReleasedAtGranularity,
    [property: JsonPropertyName("IsFinal")] int IsFinal
);

public class RecentAchievements : Dictionary<string, Dictionary<string, AchievementLite>>;

public record RecentlyPlayed(
    [property: JsonPropertyName("GameID")] int GameID,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("ImageIcon")] string ImageIcon,
    [property: JsonPropertyName("ImageTitle")] string ImageTitle,
    [property: JsonPropertyName("ImageIngame")] string ImageIngame,
    [property: JsonPropertyName("ImageBoxArt")] string ImageBoxArt,
    [property: JsonPropertyName("LastPlayed")] string LastPlayed,
    [property: JsonPropertyName("AchievementsTotal")] int AchievementsTotal
);


