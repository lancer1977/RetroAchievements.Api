using PolyhydraGames.RetroAchievements;

namespace PolyhydraGames.RACheevos.Test;

public class ExtensionTests
{
    [Test]
    public void ValidateEpoch()
    {
        var epoch = DateTime.Now.ToEpoch();
        Assert.That(epoch > 0);

    }
}
