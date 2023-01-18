using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Socical
{
    public class People
    {
        [Key]
        public virtual Guid PeopleId { get; set; }
        public virtual Guid ChatId { get; set; }
        public virtual string UserId { get; set; }
        public virtual string Image { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual List<Conversation> Conversations { get; set; }
        public virtual DateTime DateTime { get; set; }
        public People()
        {
            DateTime = DateTime.Now;
            Conversations = new List<Conversation>();
        }
    }
}
