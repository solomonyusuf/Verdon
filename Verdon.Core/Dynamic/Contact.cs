using System;

namespace Verdon.Core.Dynamic
{
    public class Contact
    {
        public virtual int ContactId { get; set; }
        public virtual string FullName { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual string Message { get; set; }
        public virtual DateTime DateTime { get; set; }
        public Contact()
        {
            DateTime = DateTime.Now;
        }
    }
}
