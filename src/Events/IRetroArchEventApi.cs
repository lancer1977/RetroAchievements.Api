namespace PolyhydraGames.RetroAchievements.Events;
public interface IRetroArchEventApi
{
    Task<EventResponse> GetAchievementOfTheWeek();
}