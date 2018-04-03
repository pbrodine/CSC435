using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Assignment_7.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Notes> Notes2 { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string CreatedOn { get; set; }

        public List<Notes> Notes2 { get; set; }
    }
    
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string CreatedOn { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Notes> Notes2 { get; set; }
    }
}