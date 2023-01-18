using System;

namespace Verdon.Core.Dynamic
{
    public class News
    {
        public virtual int NewsId { get; set; }
        public virtual string Image { get; set; }
        public virtual string Title { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime DateTime { get; set; }
        public News()
        {
            DateTime = DateTime.Now;
        }
    }
}
