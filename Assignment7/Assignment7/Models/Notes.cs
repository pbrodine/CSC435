using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Assignment7.Models
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<UserContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Notes> Notes2 { get; set; }
        public DbSet<Category> Categories { get; set; }
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
}