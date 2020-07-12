using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs"); //chuyển qua sql dạng bảng với table tên AppConfigs

            builder.HasKey(x => x.Key); //khóa chính

            builder.Property(x => x.Value).IsRequired(true); //IsRequired(true) bắt buộc phải nhật
        }
    }
}
