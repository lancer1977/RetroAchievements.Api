namespace PolyhydraGames.RetroAchievements.Feeds;

public class GameAward
{
    public string User { get; set; }
    public string AwardKind { get; set; }
    public DateTime AwardDate { get; set; }
    public int GameID { get; set; }
    public string GameTitle { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
}