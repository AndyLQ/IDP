using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using registering_try2.Models;

namespace registering_try2.Data
{
    public class WebSiteRatingDbContext : DbContext
    {

        public WebSiteRatingDbContext(DbContextOptions<WebSiteRatingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RatingCategory> RatingCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API mappings (if needed)
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Rating>().ToTable("Rating");
            modelBuilder.Entity<RatingCategory>().ToTable("RatingCategory");

        }

    }
}
