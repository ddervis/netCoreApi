using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Notes.Core.Models
{
   public class Target
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime TargetTime { get; set; }

    }
}
