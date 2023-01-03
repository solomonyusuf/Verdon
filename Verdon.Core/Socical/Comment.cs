using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Socical
{
    public class Comment
    {
        [Key]
        public virtual Guid CommentId { get; set; }
        public virtual Guid PostId { get; set; }
        public virtual string Body { get; set; }
    }
}
