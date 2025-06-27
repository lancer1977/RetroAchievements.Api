namespace PolyhydraGames.RetroAchievements.Users;
public class VisibleUserAward
{
    public DateTime AwardedAt { get; set; }
    public string AwardType { get; set; }
    public int AwardData { get; set; }
    public int AwardDataExtra { get; set; }
    public int DisplayOrder { get; set; }
    public string Title { get; set; }
    public int? ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public int? Flags { get; set; }
    public string ImageIcon { get; set; }
}