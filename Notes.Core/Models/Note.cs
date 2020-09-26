using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Core.Models
{
   public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int TargetId { get; set; }

        public virtual Target Target { get; set; }
        public virtual Category Category { get; set; }
    }
}
