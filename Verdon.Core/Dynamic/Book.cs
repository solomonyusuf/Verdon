using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Author { get; set; }
        public string File { get; set; }
        public DateTime DateTime { get; set; }
        public Book()
        {
            DateTime = DateTime.Now;
        }

    }
}
