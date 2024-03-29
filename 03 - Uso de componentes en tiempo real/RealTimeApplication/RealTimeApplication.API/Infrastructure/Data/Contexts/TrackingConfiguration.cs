﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using RealTimeApplication.API.Infrastructure.Data.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RealTimeApplication.API.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RealTimeApplication.API.Infrastructure.Data.Contexts
{
    public class TrackingConfiguration : IEntityTypeConfiguration<Tracking>
    {
        public void Configure(EntityTypeBuilder<Tracking> entity)
        {
            entity.ToTable("Tracking");

            entity.Property(e => e.EstimatedDeliveryTime).HasColumnType("datetime");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.Trackings)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackingOrder");

            entity.HasOne(d => d.TrackingStatus)
                .WithMany(p => p.Trackings)
                .HasForeignKey(d => d.TrackingStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackingTrackingStatus");
        }
    }
}
