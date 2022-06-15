using NewsBlogAPI.Models;

namespace NewsBlogAPI.Helpers
{
    public interface INewsRepository
    {
        List<NewsPost> getAllPost();
        NewsPost getPostByID(int id);
        NewsPost CreatePost(NewsPost newsPost);
        NewsPost UpdatePost(NewsPost newsPost);
        void DeletePost(int id);
    }
}
