namespace PolyhydraGames.RetroAchievements.Users;
public class GameInfoAndUserProgressResponse 
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int ConsoleID { get; set; }
    public int ForumTopicID { get; set; }
    public object Flags { get; set; }
    public string ImageIcon { get; set; }
    public string ImageTitle { get; set; }
    public string ImageIngame { get; set; }
    public string ImageBoxArt { get; set; }
    public string Publisher { get; set; }
    public string Developer { get; set; }
    public string Genre { get; set; }
    public string Released { get; set; }
    public string ReleasedAtGranularity { get; set; }
    public bool IsFinal { get; set; }
    public string RichPresencePatch { get; set; }
    public object GuideURL { get; set; }
    public string ConsoleName { get; set; }
    public object ParentGameID { get; set; }
    public int NumDistinctPlayers { get; set; }
    public int NumAchievements { get; set; }
    public Dictionary<int,AchievementProgress> Achievements { get; set; }
    public int NumAwardedToUser { get; set; }
    public int NumAwardedToUserHardcore { get; set; }
    public int NumDistinctPlayersCasual { get; set; }
    public int NumDistinctPlayersHardcore { get; set; }
    public string UserCompletion { get; set; }
    public string UserCompletionHardcore { get; set; }
    public string HighestAwardKind { get; set; }
    public DateTime? HighestAwardDate { get; set; }
}