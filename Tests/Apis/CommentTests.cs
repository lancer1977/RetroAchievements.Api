using System.Diagnostics;
using PolyhydraGames.RetroAchievements.Comments;
using PolyhydraGames.RetroAchievements.Events;
using Console = System.Console;

namespace PolyhydraGames.RACheevos.Test.Apis;
[TestFixture]
public class CommentTests : BaseTests
{
    public IRetroAchievementCommentApi Api { get; set; }

    [SetUp]
    public void Setup()
    {
        Api = new RetroAchievementCommentApi(Config, new HttpClient());
    }

    [Test]
    public async Task GetComments()
    {
        var result = await Api.GetComments(TestGameId,CommentType.Game);
        
        Assert.That(result.Count > 0);
    }
    
    [Test]
    public async Task GetUserComments()
    {
        var result = await Api.GetUserComments(TestUserNekro);
        Trace.WriteLine($"Count:{result.Count}");
        foreach (var item in result.Results)
        {
            Console.WriteLine($"Comment:{item.CommentText}");
        }
        Assert.That(result.Count > 0);
    }
}