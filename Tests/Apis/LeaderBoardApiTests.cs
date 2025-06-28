using System.Diagnostics;
using PolyhydraGames.RetroAchievements.Leaderboards;

namespace PolyhydraGames.RACheevos.Test.Apis
{
    [TestFixture]
    public class LeaderBoardApiTests : BaseTests
    {
        private LeaderBoardApi _api;

        [SetUp]
        public void Setup()
        {
            _api = new LeaderBoardApi(Config, new HttpClient()); 
        }

        [Test]
        public async Task GetGameLeaderboards()
        {
            var result = await _api.GetGameLeaderboards(TestGameId);
            Trace.WriteLine($"Count:{result.Title}"); 
            Assert.That(!string.IsNullOrEmpty(result.Title));
        }

        [Test]
        public async Task GetLeaderboardEntries()
        {
            var result = await _api.GetLeaderboardEntries("4");
            Trace.WriteLine($"Count:{result.Count}");
 
            Assert.That(result.Count > 0);
        }

        [Test]
        public async Task GetUserGameLeaderboards()
        {
            var result = await _api.GetUserGameLeaderboards(TestGameId, TestUserNekro);
  
            Assert.That(result.Count > 0);
        }
    }
}
