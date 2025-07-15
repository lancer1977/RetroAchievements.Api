using PolyhydraGames.RetroAchievements.Systems;

namespace PolyhydraGames.RACheevos.Test.Apis;

public class SystemTests : BaseTests
{
    public IRetroAchievementSystemApi Api { get; set; }

    [SetUp]
    public void Setup()
    {
        Api = new RetroAchievementSystemApi(Config, new HttpClient());
    }

    [Test]
    public async Task GetConsoleIDs()
    {
        var result = await Api.GetConsoleIDs();
        foreach (var system in result)
        {
            WriteLine($"{system.ID}: {system.Name}");
        }
        Assert.That(result.Any());

    }

    //[Ignore("This test consumes a lot of bandwidth from RA and should be used sparingly.")]
    [TestCase(1)]
    public async Task GetGameList(int systemId)
    {
        var result = await Api.GetGameList(systemId);
        Assert.That(result != null);

    }
}