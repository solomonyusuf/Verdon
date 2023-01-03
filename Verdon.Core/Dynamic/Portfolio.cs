using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verdon.Core.Dynamic
{
    public class Portfolio
    {
        [Key]
        public Guid PortfolioId { get; set; }
        public string UserId { get; set; }
        public string Image { get; set; }
    }
}
