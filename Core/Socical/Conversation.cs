using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Socical
{
    public class Conversation
    {
        [Key]
        public virtual Guid ConversationId { get; set; }
        public virtual Guid PeopleId { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime DateTime { get; set; }
        public Conversation()
        {
            DateTime = DateTime.Now;
        }
    }
}
