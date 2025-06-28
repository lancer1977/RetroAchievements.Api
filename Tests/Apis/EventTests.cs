using System.Diagnostics;
using PolyhydraGames.RetroAchievements.Events;

namespace PolyhydraGames.RACheevos.Test.Apis;

public class EventTests : BaseTests
{
    public IRetroArchEventApi Api { get; set; }
    [SetUp]
    public void Setup()
    {
        Api = new EventApi(Config, new HttpClient());
    }

    [Test]
    public async Task GetAchievementUnlocks()
    {
        var result = await Api.GetAchievementOfTheWeek();
        WriteLine($"Event was:{result.Game.Title}");
        Assert.That(result != null);
    }
}