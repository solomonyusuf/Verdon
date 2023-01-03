using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Socical
{
    public class Reaction
    {
        [Key]
        public virtual Guid ReactionId { get; set; }
        public virtual Guid PostId { get; set; }
        public virtual int TotalCount { get; set; }
    }
}
