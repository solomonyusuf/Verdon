using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Lesson
    {
        [Key]
        public Guid LessonId { get; set; }
        public Guid LectureId { get; set; }
        public string LessonName { get; set; }
        public string Size { get; set; }
        public string Video { get; set; }
    }
}
