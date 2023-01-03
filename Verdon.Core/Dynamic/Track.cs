using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Verdon.Core.Dynamic
{
    public class Track
    {
        [Key]
        public virtual string TrackId { get; set; }
        public virtual string QId { get; set; }
        public virtual DateTime DateTime { get; set; }
        public Track()
        {
            DateTime = DateTime.Now;
        }

    }
}
