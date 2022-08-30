using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShortLink.Core.Models;

namespace ShortLink.Repo.Data;

public class LinkData : IEntityTypeConfiguration<LinkEntity>
{
    public void Configure(EntityTypeBuilder<LinkEntity> builder)
    {
        builder.HasData(
            new LinkEntity("google.com"),
            new LinkEntity("googleTwo.com"));
    }
}
