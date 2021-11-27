using Microsoft.EntityFrameworkCore;
using Application;
using Domains;
using Persistence.EntityTypeConfigurations;

namespace Persistence
{
    public class NotesDbContext : DbContext, INoteDbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}