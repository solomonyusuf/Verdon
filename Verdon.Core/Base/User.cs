using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verdon.Core.Dynamic;

namespace Verdon.Core.Base
{
    public class User : IdentityUser
    {
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CourseName { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }
        public string School { get; set; }
        public string DOB { get; set; }
        public string Sex { get; set; }
        public string Skills { get; set; }
        public string Bio { get; set; }
        public string Description { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public virtual string MatricNo { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public virtual List<PrivateQuizResult> PrivateQuizResults { get; set; }
        public List<SecurityQuestion> SecurityQuestions { get; set; }
        public virtual DateTime DateTime { get; set; }
        public User()
        {
            Ratings = new List<Rating>();
            Portfolios = new List<Portfolio>();
            SecurityQuestions = new List<SecurityQuestion>();
            PrivateQuizResults = new List<PrivateQuizResult>();
            DateTime = DateTime.Now;
        }
    }
}
