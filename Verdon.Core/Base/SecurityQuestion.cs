using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Base
{
    public class SecurityQuestion
    {
        [Key]
        public Guid SecurityQuestionId { get; set; }
        public string AppUserId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
