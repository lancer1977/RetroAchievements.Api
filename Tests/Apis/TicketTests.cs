using PolyhydraGames.RetroAchievements.Tickets;

namespace PolyhydraGames.RACheevos.Test.Apis
{
    public class TicketTests : BaseTests
    {
        public IRetroAchievementTicketApi Api { get; set; }

        [SetUp]
        public void Setup()
        {
            Api = new RetroAchievementTicketApi(Config, new HttpClient());
        }

        [Test]
        public async Task GetTicketDataById()
        {
            var result = await Api.GetTicketDataById(1);
            Assert.That(result != null);

        }

        [Test]
        public async Task GetTicketData()
        {
            var result = await Api.GetTicketData(1);
            Assert.That(result != null);

        }

        [Test]
        public async Task GetRecentTicketData()
        {
            var result = await Api.GetRecentTicketData(1);
            Assert.That(result != null);

        }

        [Test]
        public async Task GetGameTicketStats()
        {
            var result = await Api.GetGameTicketStats(1);
            Assert.That(result != null);

        }

        [Test]
        public async Task GetDeveloperTicketData()
        {
            var result = await Api.GetDeveloperTicketData("Hexadigital");
            Assert.That(result != null);

        }

        [Test]
        public async Task GetAchievementTicketData()
        {
            var result = await Api.GetAchievementTicketData(1);
            Assert.That(result != null);

        }


    }
}