

namespace PolyhydraGames.RetroAchievements;

public interface ICheevoAuth
{
    public bool Authorized { get; }
    public string ApiKey { get; }
    public string UserName { get; }

}