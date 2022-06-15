using Microsoft.EntityFrameworkCore;
using NewsBlogAPI.Data;
using NewsBlogAPI.Models;

namespace NewsBlogAPI.Helpers
{
    public class NewsRepository : INewsRepository
    {
        private readonly DataContext _context;

        public NewsRepository(DataContext context)
        {
            _context = context;
        }

        public NewsPost CreatePost(NewsPost newsPost)
        {
           _context.newsPosts.Add(newsPost);
            newsPost.Id = _context.SaveChanges();
            return newsPost;
        }

        public void DeletePost(int id)
        {
            var postFind = _context.newsPosts.FirstOrDefault(p => p.Id == id);

            _context.newsPosts.Remove(postFind);
            _context.SaveChanges();
        }

        public List<NewsPost> getAllPost()
        {
            return _context.newsPosts.ToList();
        }

        public NewsPost getPostByID(int id)
        {
            return _context.newsPosts.FirstOrDefault(p => p.Id == id);
        }

        public NewsPost UpdatePost(NewsPost newsPost)
        {
            var PostFind = _context.newsPosts.Where(p => p.Id == newsPost.Id).FirstOrDefault();
            PostFind.Id = newsPost.Id;
            PostFind.Title = newsPost.Title;
            PostFind.Description = newsPost.Description;

            _context.SaveChanges();

            return newsPost;
        }
    }
}
