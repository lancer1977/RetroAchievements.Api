using PolyhydraGames.RetroAchievements.Feeds;

namespace PolyhydraGames.RACheevos.Test.Apis;

public class FeedTests : BaseTests
{
    private IRetroArchFeedApi Api { get; set; }

    public FeedTests()
    {
        Api = new RetroArchFeedApi(Config, new HttpClient());
    }

    [Test]
    public async Task GetRecentGameAwards()
    {
        var result = await Api.GetRecentGameAwards(DateTime.Today - TimeSpan.FromDays(30));
        Assert.That(result != null);
    }

    [Test]
    public async Task GetActiveClaims()
    {
        var result = await Api.GetActiveClaims();
        Assert.That(result != null);
    }

    [Test]
    public async Task GetClaims()
    {
        var result = await Api.GetClaims();
        Assert.That(result != null);
    }

    [Test]
    public async Task GetTopTenUsers()
    {
        var result = await Api.GetTopTenUsers();
        Assert.That(result != null);
    }


}