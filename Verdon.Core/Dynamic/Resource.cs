using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Resource
    {
        [Key]
        public Guid ResourceId { get; set; }
        public Guid LectureId { get; set; }
        public string ResourceName { get; set; }
        public string Size { get; set; }
        public string File { get; set; }
    }
}
