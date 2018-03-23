using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Post
    {
        public Post(int id, string title, string content, int categotyId, int authorId, ICollection<int> replyIds)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CategotyId = categotyId;
            this.AuthorId = authorId;
            this.ReplyIds = new List<int>(replyIds);
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CategotyId { get; set; }

        public int AuthorId { get; set; }

        public ICollection<int> ReplyIds { get; set; }
    }
}
