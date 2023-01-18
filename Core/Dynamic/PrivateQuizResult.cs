using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class PrivateQuizResult
    {
        [Key]
        public virtual string PrivateQuizResultId { get; set; }
        public virtual Guid PrivateQuizId { get; set; }
        public virtual string UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string Department { get; set; }
        public virtual string MatricNo { get; set; }
        public virtual string Score { get; set; }
        public virtual DateTime DateTime { get; set; }
        public PrivateQuizResult()
        {
            DateTime = DateTime.Now;
        }
    }
}
