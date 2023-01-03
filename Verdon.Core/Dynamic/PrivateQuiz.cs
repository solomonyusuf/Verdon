using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class PrivateQuiz
    {
        [Key]
        [Required]
        public virtual Guid PrivateQuizId { get; set; }
        public virtual string UserId { get; set; }
        public virtual int QuizId { get; set; }
        public virtual string Password { get; set; }
        public virtual string Title { get; set; }
        public virtual int Duration { get; set; }
        public virtual bool Visible { get; set; }
        public virtual int Factor { get; set; }
        public virtual List<PrivateQuestion> PrivateQuestions { get; set; }
        public virtual List<PrivateQuizResult> PrivateQuizResults { get; set; }
        public virtual DateTime DateTime { get; set; }
        public PrivateQuiz()
        {
            DateTime = DateTime.Now;
            PrivateQuestions = new List<PrivateQuestion>();
            PrivateQuizResults = new List<PrivateQuizResult>();
            var random = new Random();
            var seed = random.Next(10000);
            QuizId = seed;

        }
    }
}
