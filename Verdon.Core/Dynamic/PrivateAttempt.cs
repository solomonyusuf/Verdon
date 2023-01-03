using System;
using System.ComponentModel.DataAnnotations;

namespace Verdon.Core.Dynamic
{
    public class PrivateAttempt
    {
        [Key]
        public virtual Guid PrivateAttemptId { get; set; }
        public virtual string UserId { get; set; }
        public virtual int QuizId { get; set; }
        public virtual Guid PrivateQuestionId { get; set; }
        public virtual string Response { get; set; }
        public virtual string Answer { get; set; }
        public DateTime DateTime { get; set; }
    }
}
