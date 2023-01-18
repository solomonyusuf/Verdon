using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Tutorial
    {
        [Key]
        public Guid TutorialId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Video { get; set; }
        public DateTime DateTime { get; set; }
        public Tutorial()
        {
            DateTime = DateTime.Now;
        }
    }
}
