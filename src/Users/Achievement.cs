namespace PolyhydraGames.RetroAchievements.Users;
public class Achievement
{
    public DateTime Date { get; set; }
    [JsonConverter(typeof(FlexibleBoolConverter))]
    public bool HardcoreMode { get; set; }
    public int AchievementID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string BadgeName { get; set; }
    public int Points { get; set; }
    //public int TrueRatio { get; set; }
    public object Type { get; set; }
    public string Author { get; set; }
    public string AuthorULID { get; set; }
    public string GameTitle { get; set; }
    public string GameIcon { get; set; }
    public int GameID { get; set; }
    public int CumulScore { get; set; }
    public string ConsoleName { get; set; }
    public string BadgeURL { get; set; }
    public string GameURL { get; set; }
}