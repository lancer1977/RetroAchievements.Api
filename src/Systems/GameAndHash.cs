namespace PolyhydraGames.RetroAchievements.Systems;

public class GameAndHash
{
    public List<string> Hashes { get; set; }
    public string Title { get; set; }
    public int ID { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public string ImageIcon { get; set; }
    public int NumAchievements { get; set; }
    public int NumLeaderboards { get; set; }
    public int Points { get; set; }
    public DateTime DateModified { get; set; }
    public int? ForumTopicID { get; set; }
}