namespace PolyhydraGames.RetroAchievements.Tickets;
public interface IRetroArchTicketApi
{
    Task<TicketData> GetTicketDataById(int id);
    Task<TicketData> GetTicketData(int id, int count = 10, int offset = 0);
    Task<TicketData> GetRecentTicketData(int id, int count = 10, int offset = 0);
    Task<TicketData> GetGameTicketStats(int id); //g=gamdid f for unofficial achievements, d for 1 metadata
    Task<TicketData> GetDeveloperTicketData(string developerUsername); //u=Hexadigital dev username
    Task<TicketData> GetAchievementTicketData(int achievementId); //a=9

}