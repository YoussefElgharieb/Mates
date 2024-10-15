﻿using Mates.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mates.Infrastructure.Configuration
{
    internal class RelationshipEntityTypeConfiguration : IEntityTypeConfiguration<Relationship>
    {
        public void Configure(EntityTypeBuilder<Relationship> builder)
        {
            builder
                .HasKey(r => new { r.UserId, r.OtherUserId });

            builder
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .IsRequired();

            builder
                .HasOne(r => r.OtherUser)
                .WithMany()
                .HasForeignKey(r => r.OtherUserId)
                .IsRequired();
        }
    }
}
