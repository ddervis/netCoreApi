using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Core.Models
{
   public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
