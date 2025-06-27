namespace PolyhydraGames.RetroAchievements.Users;
public class UserClaim
{
    public int ID { get; set; }
    public string User { get; set; }
    public int GameID { get; set; }
    public string GameTitle { get; set; }
    public string GameIcon { get; set; }
    public int ConsoleID { get; set; }
    public string ConsoleName { get; set; }
    public int ClaimType { get; set; }
    public int SetType { get; set; }
    public int Status { get; set; }
    public int Extension { get; set; }
    public int Special { get; set; }
    public DateTime Created { get; set; }
    public DateTime DoneTime { get; set; }
    public DateTime Updated { get; set; }
    public int UserIsJrDev { get; set; }
    public int MinutesLeft { get; set; }
}