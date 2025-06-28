namespace PolyhydraGames.RetroAchievements.Comments;
public interface IRetroAchievementCommentApi
{
    Task<CommentsResponse?> GetComments(int id, CommentType type, int count = 100, int offset = 0, bool ascending = true);

    Task<CommentsResponse?> GetUserComments(string userId, int count = 100, int offset = 0, bool ascending = true);
}