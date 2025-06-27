namespace PolyhydraGames.RetroAchievements.Users;

public class UserAwardsResponse
{
    public int TotalAwardsCount { get; set; }
    public int HiddenAwardsCount { get; set; }
    public int MasteryAwardsCount { get; set; }
    public int CompletionAwardsCount { get; set; }
    public int BeatenHardcoreAwardsCount { get; set; }
    public int BeatenSoftcoreAwardsCount { get; set; }
    public int EventAwardsCount { get; set; }
    public int SiteAwardsCount { get; set; }
    public List<VisibleUserAward> VisibleUserAwards { get; set; }
}