using PolyhydraGames.Core.Models;
using System.Diagnostics;
using System.Text;
using PolyhydraGames.RetroAchievements.Users;

namespace PolyhydraGames.RACheevos.Test.Apis;

public class UserTests : BaseTests
{
    private IRetroArchUserApi Api { get; set; }

    public UserTests()
    {
        Api = new RetroArchUserApi(Config, new HttpClient());
    }

    [Test]
    public async Task GetUserProfile()
    {
        var result = await Api.GetUserProfile(TestUser);
        WriteLine(result.ToJson());
        Assert.That(result.User == TestUser);
    }

    [Test]
    public async Task GetUserRecentAchievements()
    {
        var result = await Api.GetUserRecentAchievements(TestUser, 100011);
        WriteLine(result.ToJson());
        Assert.That(result.Any());
    }



    [Test]
    public async Task GetAchievementsEarnedBetween()
    {
        var now = DateTime.Now;
        var start = now - TimeSpan.FromDays(30);
        var end = now;

        var result = await Api.GetAchievementsEarnedBetween(TestUser, start, end);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetAchievementsEarnedOnDay()
    {
        var day = new DateTime(2025,5,31);
        var result = await Api.GetAchievementsEarnedOnDay(TestUser, day);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetGameInfoAndUserProgress()
    {
        var result = await Api.GetGameInfoAndUserProgress(TestUser, TestGameId);
        Assert.That(result.Achievements.Any());
    }
    [Test]
    public async Task GetUserCompletionProgress()
    {
        var result = await Api.GetUserCompletionProgress(TestUser);
        Assert.That(result.Total > 0);
    }
    [Test]
    public async Task GetUserAwards()
    {
        var result = await Api.GetUserAwards(TestUser);
        Assert.That(result.TotalAwardsCount > 0);
    }
    [Test]
    public async Task GetUserClaims()
    {
        var result = await Api.GetUserClaims(TestUser);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetUserGameRankAndScore()
    {
        var result = await Api.GetUserGameRankAndScore(TestUser, TestGameId);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetUserPoints()
    {
        var result = await Api.GetUserPoints(TestUser);
        Assert.That(result.SoftcorePoints > 0);
    }

    [Test]
    public async Task GetUserProgress()
    {
        IReadOnlyList<int> achievementIds = new List<int> { 1, 2, 3 };
        var result = await Api.GetUserProgress(TestUser, achievementIds);
        Assert.That(result.Any());
    }
    [Test]
    public async Task GetUserRecentlyPlayedGames()
    {
        var resultEnum = await Api.GetUserRecentlyPlayedGames(TestUser, 30);
        var result = resultEnum.ToList();
        var count = result.Count;
        //WriteLine(result.ToJson());
        for (var x = 1; x <= count; x++)
        {
            WriteLine(GetRecentGameHtml(x, result[x - 1]));
            //   WriteLine(GameMarkdownCell(x, result[x]));
        }
        Assert.That(result.Any());
    }

    public static string GetRecentGameHtml(int count, RecentGame item)
    {
        // Define variables
        var index = count;
        var imageSrc1 = item.ImageIcon;
        var date = item.LastPlayed;
        var imageSrc2 = item.ImageBoxArt;
        var gameName = item.Title;
        var gameUrl = $"https://retroachievements.org/game/{item.GameID}";

        // Create a StringBuilder to construct the HTML
        var html = new StringBuilder();

        // Append the HTML structure
        html.Append("<tr>\n");
        html.Append("    <td>").Append(index).Append("</td>\n");
        html.Append("    <td><a href=\"").Append(gameUrl).Append("\">").Append(gameName).Append("</a></td>\n");
        html.Append("    <td><img height=\"120\" src=\"https://media.retroachievements.org/").Append(imageSrc1).Append("\"></td>\n");
        html.Append("    <td>").Append(date).Append("</td>\n");
        html.Append("    <td><img height=\"120\" src=\"https://media.retroachievements.org/").Append(imageSrc2).Append("\"></td>\n");

        html.Append("</tr>\n");
        return html.ToString();
    }


    private string GameMarkdownCell(int count, RecentGame item)
    {
        var builder = new StringBuilder();

        builder.Append("| " + count + "|");
        //WriteLine(item.ToJson());
        var image = "<img height=\"120\" src=\"https://media.retroachievements.org" + item.ImageIcon + "\"> |";
        builder.Append(image);
        var lastPlayed = item.LastPlayed + " | ";
        builder.Append(lastPlayed);

        var link = "<a href=\"https://retroachievements.org/game/" + item.GameID + "\" >" + item.Title + "</a> |";
        var boximage = "<img height=\"120\" src=\"https://media.retroachievements.org" + item.ImageBoxArt + "\"> |";
        builder.Append(boximage);
        builder.Append(link);
        return builder.ToString();
    }

    [Test]
    public async Task GetUserSummary()
    {
        var result = await Api.GetUserSummary(TestUser);
        WriteLine(result.ToJson());
        Assert.That(result.LastGameID > 0);
    }

    [Test]
    public async Task GetUserCompletedGames()
    {
        var result = await Api.GetUserCompletedGames(TestUser);
        WriteLine(result.ToJson());
        WriteLine("Count" + result.Count());
        WriteLine(string.Join(",",result));
        Assert.That(result.Any());
    }
}
