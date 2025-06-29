using PolyhydraGames.Extensions;
using PolyhydraGames.RetroAchievements.Games;

namespace PolyhydraGames.RACheevos.Test.Apis;

public class GameTests : BaseTests
{

    public IRetroAchievementGameApi Api { get; set; }



    public GameTests()
    {
        Api = new RetroAchievementCheevoApi(Config, new HttpClient());
    }

    [TestCase(TestGameId)]
    public async Task GetGame(int gameID)
    {
        var result = await Api.GetGame(gameID);
        Assert.That(result != null);
    }

    [TestCase(TestGameId, true)]
    public async Task GetGameExtended(int gameID, bool officialAchievements = false)
    {
        var result = await Api.GetGameExtended(gameID, officialAchievements);
        Assert.That(result != null);
    }
    [TestCase(TestGameId)]
    public async Task GetGameHashes(int gameID)
    {
        var result = await Api.GetGameHashes(gameID);
        Assert.That(result.Results.Any());
    }


    [TestCase(TestGameId)]
    public async Task GetAchievementCount(int gameId)
    {
        var result = await Api.GetAchievementCount(gameId);
        Assert.That(result.AchievementIDs.Any());
    }
    [TestCase(TestGameId, true, true)]
    public async Task GetAchievementDistribution(int gameId, bool allUnlocks = true, bool officialAchievements = true)
    {
        var result = await Api.GetAchievementDistribution(gameId, allUnlocks, officialAchievements);
        Assert.That(result.Any());
    }
    [TestCase(TestGameId, true)]
    public async Task GetGameRankAndScore(int gameID, bool masters = false)
    {
        var result = await Api.GetGameRankAndScore(gameID, masters);
        Assert.That(result.Any());
    }
}