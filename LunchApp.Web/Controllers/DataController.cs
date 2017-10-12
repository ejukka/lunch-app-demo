using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lunch_app_demo.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {

		private readonly DbModels.ModelContext _context;

		public DataController(DbModels.ModelContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Get()
		{
			var users = await _context.Users
				.Include(u => u.Posts)
				.ToArrayAsync();

			var response = users.Select(u => new
			{
				firstName = u.FirstName,
				lastName = u.LastName,
				posts = u.Posts.Select(p => p.Content)
			});

			return Ok(response);
		}
    }
}
