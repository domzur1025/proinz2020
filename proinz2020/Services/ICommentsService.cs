using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proinz2020.Model;

namespace proinz2020.Services
{
    interface ICommentsService
    {
        IEnumerable<Comment> findCommentsByPostId(Post post);
        void AddComment(Comment comment);
    }
}
