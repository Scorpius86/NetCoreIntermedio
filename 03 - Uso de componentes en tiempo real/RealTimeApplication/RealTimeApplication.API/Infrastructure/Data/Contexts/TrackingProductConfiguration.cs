﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using RealTimeApplication.API.Infrastructure.Data.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RealTimeApplication.API.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RealTimeApplication.API.Infrastructure.Data.Contexts
{
    public class TrackingProductConfiguration : IEntityTypeConfiguration<TrackingProduct>
    {
        public void Configure(EntityTypeBuilder<TrackingProduct> entity)
        {
            entity.ToTable("TrackingProduct");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.TrackingProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackingProductProduct");

            entity.HasOne(d => d.Tracking)
                .WithMany(p => p.TrackingProducts)
                .HasForeignKey(d => d.TrackingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackingProductTracking");
        }
    }
}
