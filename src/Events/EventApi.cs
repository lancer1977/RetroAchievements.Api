namespace PolyhydraGames.RetroAchievements.Events;
public class EventApi : RestServiceBase, IRetroAchievementEventApi
{

    public EventApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client)
    {
    }

    public Task<EventResponse?> GetAchievementOfTheWeek()
    {
        var url = GetBaseUrl();
        return Get<EventResponse>(url);
    }
}
