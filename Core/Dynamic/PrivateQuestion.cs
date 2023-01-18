using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class PrivateQuestion
    {
        [Key]
        public virtual Guid PrivateQuestionId { get; set; }
        public virtual Guid PrivateQuizId { get; set; }
        public virtual string Image { get; set; }
        public virtual string Title { get; set; }
        public virtual List<PrivateOption> Options { get; set; }
        public virtual string Answer { get; set; }
        public DateTime DateTime { get; set; }
        public PrivateQuestion()
        {
            DateTime = DateTime.Now;
            Options = new List<PrivateOption>();
        }

    }
}
