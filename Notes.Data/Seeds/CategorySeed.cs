using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Data.Seeds
{
    class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

            public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
               new Category { Id = _ids[0], Name = "Kişisel Gelişimler"},
               new Category { Id = _ids[1], Name = "Manevi İşler"}
               );
        }
    }
}
