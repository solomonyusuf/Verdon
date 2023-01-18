using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }
        public Guid LectureId { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public string File { get; set; }
    }
}
