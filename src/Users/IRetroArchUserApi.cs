

namespace PolyhydraGames.RetroAchievements.Users;
// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
public record RecentGame(
    [property: JsonPropertyName("GameID")] int GameID,
    [property: JsonPropertyName("ConsoleID")] int ConsoleID,
    [property: JsonPropertyName("ConsoleName")] string ConsoleName,
    [property: JsonPropertyName("Title")] string Title,
    [property: JsonPropertyName("ImageIcon")] string ImageIcon,
    [property: JsonPropertyName("ImageTitle")] string ImageTitle,
    [property: JsonPropertyName("ImageIngame")] string ImageIngame,
    [property: JsonPropertyName("ImageBoxArt")] string ImageBoxArt,
    [property: JsonPropertyName("LastPlayed")] string LastPlayed,
    [property: JsonPropertyName("AchievementsTotal")] int AchievementsTotal,
    [property: JsonPropertyName("NumPossibleAchievements")] int NumPossibleAchievements,
    [property: JsonPropertyName("PossibleScore")] int PossibleScore,
    [property: JsonPropertyName("NumAchieved")] int NumAchieved,
    [property: JsonPropertyName("ScoreAchieved")] int ScoreAchieved,
    [property: JsonPropertyName("NumAchievedHardcore")] int NumAchievedHardcore,
    [property: JsonPropertyName("ScoreAchievedHardcore")] int ScoreAchievedHardcore
);

public interface IRetroArchUserApi
{
    Task<List<RecentGame>?> GetUserWantToPlayList(string userName, int count = 50, int offset = 0);
    Task<UserProfile> GetUserProfile(string userName);
    Task<IEnumerable<Achievement>> GetUserRecentAchievements(string userName, int minutes = 60);

    //https://retroachievements.org/API/API_GetAchievementsEarnedBetween.php?u=Jamiras&f=1641054603&t=1641659403
    Task<IEnumerable<Achievement>?> GetAchievementsEarnedBetween(string userName, DateTime start, DateTime end);

    //https://retroachievements.org/API/API_GetAchievementsEarnedOnDay.php?u=MaxMilyin&d=2022-10-14
    Task<IEnumerable<Achievement>?> GetAchievementsEarnedOnDay(string userName, DateTime day);

    //https://retroachievements.org/API/API_GetGameInfoAndUserProgress.php?g=14402&u=MaxMilyin
    Task<GameInfoAndUserProgressResponse?> GetGameInfoAndUserProgress( string userName, int gameId, bool metadata = false);
    //https://retroachievements.org/API/API_GetUserCompletionProgress.php?u=MaxMilyin  &c=100&o=0
    Task<UserCompletionProgressResponse?> GetUserCompletionProgress(string userName, int count = 100, int offset = 0);

    //https://retroachievements.org/API/API_GetUserAwards.php?u=MaxMilyin 
    Task<UserAwardsResponse?> GetUserAwards(string userName);

    //https://retroachievements.org/API/API_GetUserClaims.php?u=Jamiras
    Task<IEnumerable<UserClaim>?> GetUserClaims(string userName);

    //https://retroachievements.org/API/API_GetUserGameRankAndScore.php?g=14402&u=WCopeland
    Task<IEnumerable<UserDetails>?> GetUserGameRankAndScore(string userName, int gameId);

    //https://retroachievements.org/API/API_GetUserPoints.php?u=Hexadigital
    Task<UserPoints?> GetUserPoints(string userName);

    //https://retroachievements.org/API/API_GetUserProgress.php?u=MaxMilyin&i=1,2,3
    Task<Dictionary<int, GameProgress>?> GetUserProgress(string userName, IEnumerable<int> achievementIds);
    //https://retroachievements.org/API/API_GetUserRecentlyPlayedGames.php?u=MaxMilyin
    Task<IEnumerable<RecentGame>?> GetUserRecentlyPlayedGames(string userName, int count = 50);
    //https://retroachievements.org/API/API_GetUserSummary.php?u=xelnia&g=1&a=2
    //Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(string gameID, string userName);

    Task<GetUserSummaryResponse?> GetUserSummary(string userName, int gameCount = 0, int achievementCount = 10);
    //https://retroachievements.org/API/API_GetUserCompletedGames.php?u=MaxMilyin
    Task<IEnumerable<GameCompletion>?> GetUserCompletedGames(string userName);
    //Task<IEnumerable<UserRecentlyPlayedGame>> GetUserRecentlyPlayedGames(string userName);

    //https://retroachievements.org/API/API_GetUsersIFollow.php y c 500 o m
    Task<IEnumerable<UserProfile>?> GetUsersIFollow( int count = 100, int offset = 0);

    //https://retroachievements.org/API/API_GetUsersFollowingMe.php

    Task<IEnumerable<UserProfile>?> GetUsersFollowingMe( int count = 100, int offset = 0);


}
