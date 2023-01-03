using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Socical
{
    public class Post
    {
        [Key]
        public virtual Guid PostId { get; set; }
        public virtual string Body { get; set; }
        public virtual Reaction Reaction { get; set; }
        public virtual List<Attachment> Attachments { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual DateTime DateTime { get; set; }
        public Post()
        {
            DateTime = DateTime.Now;
            Comments = new List<Comment>();
            Reaction = new Reaction();
            Attachments = new List<Attachment>();
        }
    }
}
