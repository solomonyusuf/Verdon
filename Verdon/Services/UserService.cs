using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Verdon.Core.Base;
using Verdon.Data;

namespace Verdon.Services
{
    public class UserService
    {
        public readonly IHttpContextAccessor _cont;
        public readonly UserManager<IdentityUser> _user;
        public readonly ApplicationDbContext _db;
        public UserService(IHttpContextAccessor cont, UserManager<IdentityUser> user, ApplicationDbContext db)
        {
            _cont = cont;
            _user = user;
            _db = db;
        }
        public async Task<User> CurrentUser()
        {
            var res = _cont.HttpContext.User.Identity.Name;
            var usr = await _db.User.Where(x => x.Email.Equals(res)).SingleAsync();
            return usr;
        }
    }
}
