using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Base
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public int RatingCount { get; set; }
        public string AppUserId { get; set; }
    }
}
