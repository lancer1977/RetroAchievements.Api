namespace PolyhydraGames.RetroAchievements.Users;
public class UserProfile 
{
    public string User { get; set; }
    public string ULID { get; set; }
    public string UserPic { get; set; }
    public string MemberSince { get; set; }
    public string RichPresenceMsg { get; set; }
    public int LastGameID { get; set; }
    public int ContribCount { get; set; }
    public int ContribYield { get; set; }
    public int TotalPoints { get; set; }
    public int TotalSoftcorePoints { get; set; }
    public int TotalTruePoints { get; set; }
    public int Permissions { get; set; }
    public int Untracked { get; set; }
    public int ID { get; set; }
    public bool UserWallActive { get; set; }
    public string Motto { get; set; }
}