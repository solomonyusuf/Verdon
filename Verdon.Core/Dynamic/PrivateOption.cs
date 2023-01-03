using System;
using System.ComponentModel.DataAnnotations;

namespace Verdon.Core.Dynamic
{
    public class PrivateOption
    {
        [Key]
        public virtual Guid OptionId { get; set; }
        public virtual Guid PrivateQuestionId { get; set; }
        public virtual string Alphabet { get; set; }
        public virtual string Content { get; set; }
    }
}
