using System;
using System.Collections.Generic;
using System.Text;
using Forum.Models;

namespace Forum.Date
{
   public class ForumData
    {
        public List<Category> Categories { get; set; }

        public List<User> Users { get; set; }

        public List<Post> Posts { get; set; }

        public List<Reply> Replies { get; set; }

        public ForumData()
        {
            this.Users = DataMapper.LoadUsers();
            this.Categories = DataMapper.LoadCategories();
            this.Posts = DataMapper.Loadposts();
            this.Replies = DataMapper.LoadReply();
        }

        public void SaveChanges()
        {
            DataMapper.SaveUsers(this.Users);
            DataMapper.Saveposts(this.Posts);
            DataMapper.SaveReplies(this.Replies);
            DataMapper.SaveCategories(this.Categories);
        }
    }
}
