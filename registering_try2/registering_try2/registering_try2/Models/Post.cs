using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registering_try2.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ÏmageUrl{ get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Comment> Comments { get; set; }


        public Post()
        { }
       public Post(string heading, string description, int userId, int categoryId)
        {
            Heading = heading;
            Description = description;
            UserId = userId;
            CategoryId = categoryId;
        }
    }
}
