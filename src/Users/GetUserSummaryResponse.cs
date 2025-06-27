namespace PolyhydraGames.RetroAchievements.Users;


public class GetUserSummaryResponse
{
    public string User { get; set; }
    public string MemberSince { get; set; }
    public LastActivity LastActivity { get; set; }
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
    [JsonConverter(typeof(FlexibleBoolConverter))]
    public bool UserWallActive { get; set; }
    public string Motto { get; set; }
    public int? Rank { get; set; }
    public int RecentlyPlayedCount { get; set; }
    public List<object> RecentlyPlayed { get; set; }
    public string UserPic { get; set; }
    public int TotalRanked { get; set; }
    public Dictionary<string, RecentlyAwardedAchievementEntity>? Awarded { get; set; }

    Dictionary<string, Dictionary<string, ExtendedRecentAchievement>>? RecentAchievements { get; set; }
    public string Status { get; set; }
}