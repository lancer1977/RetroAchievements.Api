namespace PolyhydraGames.RetroAchievements.Events;
public interface IRetroAchievementEventApi
{
    Task<EventResponse> GetAchievementOfTheWeek();
}