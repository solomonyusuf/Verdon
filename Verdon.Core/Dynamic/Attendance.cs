using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Attendance
    {
        [Key]
        public Guid AttendanceId { get; set; }
        public Guid LectureId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string MatricNo { get; set; }
        public DateTime DateTime { get; set; }
        public Attendance()
        {
            DateTime = DateTime.Now;
        }
    }
}
