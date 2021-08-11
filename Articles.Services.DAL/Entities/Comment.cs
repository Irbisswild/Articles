using System;

namespace Articles.Services.DAL.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Guid ArticleId { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
