namespace PolyhydraGames.RetroAchievements.Users
{
    public record RecentGame(
        [property: JsonPropertyName("GameID")] int GameID,
        [property: JsonPropertyName("ConsoleID")] int ConsoleID,
        [property: JsonPropertyName("ConsoleName")] string ConsoleName,
        [property: JsonPropertyName("Title")] string Title,
        [property: JsonPropertyName("ImageIcon")] string ImageIcon,
        [property: JsonPropertyName("ImageTitle")] string ImageTitle,
        [property: JsonPropertyName("ImageIngame")] string ImageIngame,
        [property: JsonPropertyName("ImageBoxArt")] string ImageBoxArt,
        [property: JsonPropertyName("LastPlayed")] string LastPlayed,
        [property: JsonPropertyName("AchievementsTotal")] int AchievementsTotal,
        [property: JsonPropertyName("NumPossibleAchievements")] int NumPossibleAchievements,
        [property: JsonPropertyName("PossibleScore")] int PossibleScore,
        [property: JsonPropertyName("NumAchieved")] int NumAchieved,
        [property: JsonPropertyName("ScoreAchieved")] int ScoreAchieved,
        [property: JsonPropertyName("NumAchievedHardcore")] int NumAchievedHardcore,
        [property: JsonPropertyName("ScoreAchievedHardcore")] int ScoreAchievedHardcore
    );
}