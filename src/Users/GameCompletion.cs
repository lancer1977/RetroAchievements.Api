namespace PolyhydraGames.RetroAchievements.Users;
public class GameCompletion
{
    public int GameID { get; set; }
    public string Title { get; set; }
    public string ImageIcon { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public int MaxPossible { get; set; }
    public int NumAwarded { get; set; }
    public int NumAwardedHardcore { get; set; }
    public DateTime? MostRecentAwardedDate { get; set; }
    public DateTime? HighestAwardDate { get; set; }
    public string HighestAwardKind { get; set; }
 
}