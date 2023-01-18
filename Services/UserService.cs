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
        public readonly UserManager<User> _user;
        public readonly ApplicationDbContext _db;
        public UserService(IHttpContextAccessor cont, UserManager<User> user, ApplicationDbContext db)
        {
            _cont = cont;
            _user = user;
            _db = db;
        }
        public async Task<User> CurrentUser()
        {
            var res = _cont.HttpContext.User.Identity.Name;
            var usr = await _db.User.Where(x => _cont.HttpContext.User.Identity.Name.Equals(x.Email)).ToListAsync();
            return usr[0];
        }
    }
}
