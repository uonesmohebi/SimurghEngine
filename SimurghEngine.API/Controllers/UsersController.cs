using Microsoft.AspNetCore.Mvc;
using SimurghEngine.API.Data;
using Microsoft.EntityFrameworkCore;
using SimurghEngine.API.Entities.CMS;

namespace SimurghEngine.API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetUsers(){
            return await _context.AppUsers.ToListAsync();
        }
    }
}