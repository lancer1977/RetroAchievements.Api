namespace PolyhydraGames.RetroAchievements.Users;
public class ActiveClaim
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
    public string Created { get; set; }
    public string DoneTime { get; set; }
    public string Updated { get; set; }
    public int UserIsJrDev { get; set; }
    public int MinutesLeft { get; set; }
}