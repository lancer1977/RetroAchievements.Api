
namespace PolyhydraGames.RetroAchievements.Games;
public record Achievement(
    [property: JsonPropertyName("ID")] int ID,
    [property: JsonPropertyName("NumAwarded")] int NumAwarded,
    [property: JsonPropertyName("NumAwardedHardcore")] int NumAwardedHardcore,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("Description")] string Description,
    [property: JsonPropertyName("Points")] int Points,
    [property: JsonPropertyName("TrueRatio")] int TrueRatio,
    [property: JsonPropertyName("Author")] string Author,
    [property: JsonPropertyName("AuthorULID")] string AuthorULID,
    [property: JsonPropertyName("DateModified")] DateTime DateModified,
    [property: JsonPropertyName("DateCreated")] DateTime DateCreated,
    [property: JsonPropertyName("BadgeName")] string BadgeName,
    [property: JsonPropertyName("DisplayOrder")] int DisplayOrder,
    [property: JsonPropertyName("MemAddr")] string MemAddr,
    [property: JsonPropertyName("type")] string Type
);

 
public record GameExtendedResponse(
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
    [property: JsonPropertyName("Developer")] string Developer,
    [property: JsonPropertyName("Genre")] string Genre,
    [property: JsonPropertyName("Released")] string Released,
    [property: JsonPropertyName("ReleasedAtGranularity")] string ReleasedAtGranularity,
    [property: JsonPropertyName("IsFinal")] bool IsFinal,
    [property: JsonPropertyName("RichPresencePatch")] string RichPresencePatch,
    [property: JsonPropertyName("GuideURL")] string GuideURL,
    [property: JsonPropertyName("Updated")] DateTime Updated,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("ParentGameID")] object ParentGameID,
    [property: JsonPropertyName("NumDistinctPlayers")] int NumDistinctPlayers,
    [property: JsonPropertyName("NumAchievements")] int NumAchievements,
    [property: JsonPropertyName("Achievements")] Dictionary<int,Achievement> Achievements,
    [property: JsonPropertyName("Claims")] IReadOnlyList<object> Claims,
    [property: JsonPropertyName("NumDistinctPlayersCasual")] int NumDistinctPlayersCasual,
    [property: JsonPropertyName("NumDistinctPlayersHardcore")] int NumDistinctPlayersHardcore
);

