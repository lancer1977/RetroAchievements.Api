namespace PolyhydraGames.RetroAchievements.Users;

public record GameInfoAndUserProgressResponse(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ForumTopicID")] int ForumTopicID,
    [property: JsonPropertyName("Flags")] object Flags,
    [property: JsonPropertyName("ImageIcon")] string ImageIcon,
    [property: JsonPropertyName("ImageTitle")] string ImageTitle,
    [property: JsonPropertyName("ImageIngame")] string ImageIngame,
    [property: JsonPropertyName("ImageBoxArt")] string ImageBoxArt,
    [property: JsonPropertyName("Publisher")] string Publisher,
    [property: JsonPropertyName("Developer")]
    string Developer,
    [property: JsonPropertyName("Genre")] string Genre,
    [property: JsonPropertyName("Released")]
    string Released,
    [property: JsonPropertyName("ReleasedAtGranularity")]
    string ReleasedAtGranularity,
    [property: JsonPropertyName("IsFinal")]
    bool IsFinal,
    [property: JsonPropertyName("RichPresencePatch")]
    string RichPresencePatch,
    [property: JsonPropertyName("GuideURL")]
    object GuideURL,
    [property: JsonPropertyName("ConsoleName")]
    string ConsoleName,
    [property: JsonPropertyName("ParentGameID")]
    object ParentGameID,
    [property: JsonPropertyName("NumDistinctPlayers")]
    int NumDistinctPlayers,
    [property: JsonPropertyName("NumAchievements")]
    int NumAchievements,
    [property: JsonPropertyName("Achievements")]
    Dictionary<string, Achievment> Achievements,
    [property: JsonPropertyName("NumAwardedToUser")]
    int NumAwardedToUser,
    [property: JsonPropertyName("NumAwardedToUserHardcore")]
    int NumAwardedToUserHardcore,
    [property: JsonPropertyName("NumDistinctPlayersCasual")]
    int NumDistinctPlayersCasual,
    [property: JsonPropertyName("NumDistinctPlayersHardcore")]
    int NumDistinctPlayersHardcore,
    [property: JsonPropertyName("UserCompletion")]
    string UserCompletion,
    [property: JsonPropertyName("UserCompletionHardcore")]
    string UserCompletionHardcore,
    [property: JsonPropertyName("HighestAwardKind")]
    string HighestAwardKind,
    [property: JsonPropertyName("HighestAwardDate")]
    DateTime HighestAwardDate
);