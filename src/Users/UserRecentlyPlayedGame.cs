namespace PolyhydraGames.RetroAchievements.Users;

public class UserRecentlyPlayedGame
{
    [JsonPropertyName("GameID")]
    public int GameID { get; set; }

    [JsonPropertyName("ConsoleID")]
    public int ConsoleID { get; set; }

    [JsonPropertyName("ConsoleName")]
    public string ConsoleName { get; set; }

    [JsonPropertyName("Title")]
    public string Title { get; set; }

    [JsonPropertyName("ImageIcon")]
    public string ImageIcon { get; set; }

    [JsonPropertyName("ImageTitle")]
    public string ImageTitle { get; set; }

    [JsonPropertyName("ImageIngame")]
    public string ImageIngame { get; set; }

    [JsonPropertyName("ImageBoxArt")]
    public string ImageBoxArt { get; set; }

    [JsonPropertyName("LastPlayed")]
    public string LastPlayed { get; set; }

    [JsonPropertyName("AchievementsTotal")]
    public int AchievementsTotal { get; set; }

    [JsonPropertyName("NumPossibleAchievements")]
    public int NumPossibleAchievements { get; set; }

    [JsonPropertyName("PossibleScore")]
    public int PossibleScore { get; set; }

    [JsonPropertyName("NumAchieved")]
    public int NumAchieved { get; set; }

    [JsonPropertyName("ScoreAchieved")]
    public int ScoreAchieved { get; set; }

    [JsonPropertyName("NumAchievedHardcore")]
    public int NumAchievedHardcore { get; set; }

    [JsonPropertyName("ScoreAchievedHardcore")]
    public int ScoreAchievedHardcore { get; set; }
}
