namespace PolyhydraGames.RetroAchievements;

public static class Media
{
    public const string BaseUrl  = "https://media.retroachievements.org";
    public static string BadgeUrl(int badgeId, bool locked = false)
    {
        var lockText = locked ? "_lock" : "";
        return $"{BaseUrl}/Badge/{badgeId}{lockText}.png";
    }
    public static string IconUrl(int id, bool locked = false)
    {
        var lockText = locked ? "_lock" : "";
        return $"{BaseUrl}/Icon/{id}{lockText}.png";
    }
}