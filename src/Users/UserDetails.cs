namespace PolyhydraGames.RetroAchievements.Users;
public class UserDetails
{
    public string User { get; set; }
    public string ULID { get; set; }
    public int UserRank { get; set; }
    public int TotalScore { get; set; }
    public DateTime LastAward { get; set; }
}