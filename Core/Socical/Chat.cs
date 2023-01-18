using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Socical
{
    public class Chat
    {
        [Key]
        public virtual Guid ChatId { get; set; }
        public virtual string UserId { get; set; }
        public virtual List<People> Peoples { get; set; }
        public virtual DateTime DateTime { get; set; }
        public Chat()
        {
            DateTime = DateTime.Now;
        }
    }
}
