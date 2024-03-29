﻿using BilgeAdamBitirmeProjesi.Core.Map;
using BilgeAdamBitirmeProjesi.Model.Entities;
using BilgeAdamBitirmeProjesi.Model.Maps.Base;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdamBitirmeProjesi.Model.Maps
{
    class OrderDetailMap : IEntityBuilder
    {
        public void Build(ModelBuilder builder)
        {
            builder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetails");

                entity.HasExtended();

                entity.Property(x => x.ProductName).HasMaxLength(50).IsRequired(true);
                entity.Property(x => x.Quantity).HasMaxLength(20).IsRequired(true);
                entity.Property(x => x.TotalPrice).HasMaxLength(255).IsRequired(true);
            });
        }
    }
}
