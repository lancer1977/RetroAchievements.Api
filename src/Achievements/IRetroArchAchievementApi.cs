namespace PolyhydraGames.RetroAchievements.Achievements;
public interface IRetroArchAchievementApi
{
    public Task<AchievementUnlocksResponse?> GetAchievementUnlocks(int achievementId, int count = 50, int offset = 0);
}