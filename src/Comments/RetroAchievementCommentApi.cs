namespace PolyhydraGames.RetroAchievements.Comments
{
    public class RetroAchievementCommentApi : RestServiceBase, IRetroAchievementCommentApi
    {
        public RetroAchievementCommentApi(ICheevoAuth authConfig, HttpClient client) : base(authConfig, client) { }

        public Task<CommentsResponse?> GetComments(int id, CommentType type, int count = 100, int offset = 0, bool ascending = true)
        {
            if (type == CommentType.User)
            {
                throw new ArgumentException("Use GetUserComments for CommentType 3", nameof(id));

            }
            var url = GetBaseUrl().Id(id).Type((int)type).Count(count).Offset(offset);
            return Get<CommentsResponse>(url);
        }

        public Task<CommentsResponse?> GetUserComments(string userId, int count = 100, int offset = 0, bool ascending = true)
        { 
            var url = GetBaseUrl("GetComments").Id(userId).Type(3).Count(count).Offset(offset);
            return Get<CommentsResponse>(url);
        }
    }
}
