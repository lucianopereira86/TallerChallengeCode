using Infra.Database.Configurations;
using Infra.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database
{
    /// <summary>
    /// Represents the database context for the User repository.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the DbSet for user datas.
        /// </summary>
        public DbSet<User> Users { get; set; }


        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
