namespace PolyhydraGames.RetroAchievements.Users;
public class UserCompletionProgressResponse
{
    public int Count { get; set; }
    public int Total { get; set; }
    public List<GameCompletion> Results { get; set; }
}