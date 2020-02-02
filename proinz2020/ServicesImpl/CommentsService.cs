using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proinz2020.Model;
using proinz2020.Services;

namespace proinz2020.ServicesImpl
{
    public class CommentsService : ICommentsService
    {

        private readonly PSQLDbContext _context;

        public CommentsService(PSQLDbContext context)
        {
            _context = context;
        }

        public void AddComment(Comment comment)
        {
            _context.Add(comment);
            _context.SaveChanges();
        }

        public IEnumerable<Comment> findCommentsByPostId(Post post)
        {
            var comments = from c in _context.Comments where c.Post.Id.Equals(post.Id) select c;
            return comments;
        }
    }
}
