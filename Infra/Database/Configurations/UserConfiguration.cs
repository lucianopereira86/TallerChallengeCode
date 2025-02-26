using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Infra.Entities;

namespace Infra.Database.Configurations
{
    /// <summary>
    /// Anime data configuration.
    /// </summary>
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(b => b.Id);
        }
    }
}
