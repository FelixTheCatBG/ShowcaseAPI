
using ShowcaseAPIOldV.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ShowcaseAPIOldV.DAL
{
    public class ShowcaseDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }


        public DbSet<Comment> Comments { get; set; }

        public ShowcaseDbContext(DbContextOptions<ShowcaseDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
            .HasMany(u => u.Posts)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);


            builder.Entity<Post>()
            .HasMany(p => p.Comments)
            .WithOne(c => c.Post)
            .HasForeignKey(c => c.PostId);
        }

    }
}
