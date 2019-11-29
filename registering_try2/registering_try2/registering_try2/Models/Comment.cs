using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registering_try2.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public string Heading { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }


        public Comment() 
        
        { }
       public Comment(int userId, string content, string heading)
        {
            UserId = userId;
            Content = content;
            Heading = heading;
        }
    }
}
