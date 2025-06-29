

namespace PolyhydraGames.RetroAchievements.Users;
// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);

public interface IRetroAchievementUserApi
{
    Task<IReadOnlyList<RecentGame>?> GetUserWantToPlayList(string userName, int count = 50, int offset = 0);
    Task<UserProfile> GetUserProfile(string userName);
    Task<IReadOnlyList<Achievement>> GetUserRecentAchievements(string userName, int minutes = 60);

    //https://retroachievements.org/API/API_GetAchievementsEarnedBetween.php?u=Jamiras&f=1641054603&t=1641659403
    Task<IReadOnlyList<Achievement>?> GetAchievementsEarnedBetween(string userName, DateTime start, DateTime end);

    //https://retroachievements.org/API/API_GetAchievementsEarnedOnDay.php?u=MaxMilyin&d=2022-10-14
    Task<IReadOnlyList<Achievement>?> GetAchievementsEarnedOnDay(string userName, DateTime day);

    //https://retroachievements.org/API/API_GetGameInfoAndUserProgress.php?g=14402&u=MaxMilyin
    Task<GameInfoAndUserProgressResponse?> GetGameInfoAndUserProgress( string userName, int gameId, bool metadata = false);
    //https://retroachievements.org/API/API_GetUserCompletionProgress.php?u=MaxMilyin  &c=100&o=0
    Task<UserCompletionProgressResponse?> GetUserCompletionProgress(string userName, int count = 100, int offset = 0);

    //https://retroachievements.org/API/API_GetUserAwards.php?u=MaxMilyin 
    Task<UserAwardsResponse?> GetUserAwards(string userName);

    //https://retroachievements.org/API/API_GetUserClaims.php?u=Jamiras
    Task<IReadOnlyList<UserClaim>?> GetUserClaims(string userName);

    //https://retroachievements.org/API/API_GetUserGameRankAndScore.php?g=14402&u=WCopeland
    Task<IReadOnlyList<UserDetails>?> GetUserGameRankAndScore(string userName, int gameId);

    //https://retroachievements.org/API/API_GetUserPoints.php?u=Hexadigital
    Task<UserPoints?> GetUserPoints(string userName);

    //https://retroachievements.org/API/API_GetUserProgress.php?u=MaxMilyin&i=1,2,3
    Task<Dictionary<int, GameProgress>?> GetUserProgress(string userName, IReadOnlyList<int> achievementIds);
    //https://retroachievements.org/API/API_GetUserRecentlyPlayedGames.php?u=MaxMilyin
    Task<IReadOnlyList<RecentGame>?> GetUserRecentlyPlayedGames(string userName, int count = 50);
    //https://retroachievements.org/API/API_GetUserSummary.php?u=xelnia&g=1&a=2
    //Task<GameInfoAndUserProgressResponse> GetGameInfoAndUserProgress(string gameID, string userName);

    Task<UserSummaryResponse?> GetUserSummary(string userName, int gameCount = 0, int achievementCount = 10);
    //https://retroachievements.org/API/API_GetUserCompletedGames.php?u=MaxMilyin
    Task<IReadOnlyList<GameCompletion>?> GetUserCompletedGames(string userName);
    //Task<IReadOnlyList<UserRecentlyPlayedGame>> GetUserRecentlyPlayedGames(string userName);

    //https://retroachievements.org/API/API_GetUsersIFollow.php y c 500 o m
    Task<IReadOnlyList<UserProfile>?> GetUsersIFollow( int count = 100, int offset = 0);

    //https://retroachievements.org/API/API_GetUsersFollowingMe.php

    Task<IReadOnlyList<UserProfile>?> GetUsersFollowingMe( int count = 100, int offset = 0);


}
