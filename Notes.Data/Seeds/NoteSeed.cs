using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Data.Seeds
{
    class NoteSeed : IEntityTypeConfiguration<Note>
    {
        private readonly int[] _Ids;
        public NoteSeed(int[] ids)
        {
            _Ids = ids;
        }

        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasData(
                new Note { Id = 1, Name = "Risale", Description = "Çok okumalıyım", TargetId = _Ids[0] },
                new Note { Id = 2, Name = "Coding", Description = "Çok okumalıyım", TargetId = _Ids[0] },
                new Note { Id = 3, Name = "Dava Adamı", Description = "Çok okumalıyım", TargetId = _Ids[1] },
                new Note { Id = 4, Name = "İngilizce Oku", Description = "Çok okumalıyım", TargetId = _Ids[0] },
                new Note { Id = 5, Name = "Muhasebeni Yap", Description = "Çok okumalıyım", TargetId = _Ids[1] }
                ) ;
        }
    }
}
