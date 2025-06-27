namespace PolyhydraGames.RetroAchievements.Users
{
    public class GameHash
    {
        public string MD5 { get; set; }
        public string Name { get; set; }
        public List<string> Labels { get; set; }
        public string? PatchUrl { get; set; }
    }
}