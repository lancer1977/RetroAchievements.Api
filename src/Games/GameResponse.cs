namespace PolyhydraGames.RetroAchievements.Games
{
    public record GameResponse(
        [property: JsonPropertyName("Title")] string Title,
        [property: JsonPropertyName("GameTitle")] string GameTitle,
        [property: JsonPropertyName("ConsoleID")] int ConsoleID,
        [property: JsonPropertyName("ConsoleName")] string ConsoleName,
        [property: JsonPropertyName("Console")] string Console,
        [property: JsonPropertyName("ForumTopicID")] int ForumTopicID,
        [property: JsonPropertyName("Flags")] int Flags,
        [property: JsonPropertyName("GameIcon")] string GameIcon,
        [property: JsonPropertyName("ImageIcon")] string ImageIcon,
        [property: JsonPropertyName("ImageTitle")] string ImageTitle,
        [property: JsonPropertyName("ImageIngame")] string ImageIngame,
        [property: JsonPropertyName("ImageBoxArt")] string ImageBoxArt,
        [property: JsonPropertyName("Publisher")] string Publisher,
        [property: JsonPropertyName("Developer")] string Developer,
        [property: JsonPropertyName("Genre")] string Genre,
        [property: JsonPropertyName("Released")] DateTime Released,
        [property: JsonPropertyName("ReleasedAtGranularity")] string ReleasedAtGranularity
    );
}
