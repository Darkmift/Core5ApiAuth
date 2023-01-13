using Core5ApiAuth.Data;
using Core5ApiAuth.Models;
using Core5ApiAuth.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Core5ApiAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IJWTManagerRepository _jWTManager;
		private readonly UserContext _dbContext;


		public UsersController(IJWTManagerRepository jWTManager,UserContext dbContext)
        {
            this._jWTManager = jWTManager;
			this._dbContext = dbContext;
		}
		[HttpGet]
		public List<string> Get()
		{
			var users = new List<string>
		{
			"Satinder Singh",
			"Amit Sarna",
			"Davin Jon"
		};

			return users;
		}

		[AllowAnonymous]
		[HttpPost]
		[Route("authenticate")]
		public IActionResult Authenticate(Users usersdata)
		{
			var token = _jWTManager.Authenticate(usersdata, _dbContext);

			if (token == null)
			{
				return Unauthorized();
			}

			return Ok(token);
		}
	}
}
