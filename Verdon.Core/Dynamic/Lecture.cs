using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Lecture
    {
        [Key]
        public Guid LectureId { get; set; }
        public string LectureName { get; set; }
        public string CourseCode { get; set; }
        public int LecturePass { get; set; }
        public string Password { get; set; }
        public List<Attendance> Attendance { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Assignment> Assignment { get; set; }
        public DateTime DateTime { get; set; }
        public Lecture()
        {
            Attendance = new List<Attendance>();
            Lessons = new List<Lesson>();
            Resources = new List<Resource>();           
            Assignment = new List<Assignment>();
            DateTime = DateTime.Now;
            var rand = new Random();
            LecturePass = rand.Next(100000);
        }
    }
}
