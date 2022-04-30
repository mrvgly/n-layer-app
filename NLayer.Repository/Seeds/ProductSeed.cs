﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product() { Id = 1, CategoryId = 1, Name = "Kalem1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product() { Id = 2, CategoryId = 1, Name = "Kalem2", Price = 200, Stock = 30, CreatedDate = DateTime.Now },
                new Product() { Id = 3, CategoryId = 1, Name = "Kalem3", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product() { Id = 4, CategoryId = 2, Name = "Kitap1", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product() { Id = 5, CategoryId = 2, Name = "Kitap2", Price = 6600, Stock = 320, CreatedDate = DateTime.Now }
            );
        }
    }
}