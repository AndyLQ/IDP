using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace registering_try2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int Role { get; set; }
        public List<Post> Posts { get; set; }

        public User() 
        { }
        public User(int userId, string userName, string password, int role) {
            UserId = userId;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}
