using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public Department()
        {
            DateTime = DateTime.Now;
        }

    }
}
