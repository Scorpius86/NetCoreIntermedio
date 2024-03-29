﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using RealTimeApplication.API.Infrastructure.Data.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RealTimeApplication.API.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RealTimeApplication.API.Infrastructure.Data.Contexts
{
    public class TrackingStatusConfiguration : IEntityTypeConfiguration<TrackingStatus>
    {
        public void Configure(EntityTypeBuilder<TrackingStatus> entity)
        {
            entity.ToTable("TrackingStatus");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.IconCls)
                .HasMaxLength(250)
                .IsUnicode(false);
        }
    }
}
