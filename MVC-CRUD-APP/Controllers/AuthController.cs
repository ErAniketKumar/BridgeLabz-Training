using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_APP.Data;
using MVC_CRUD_APP.Dto;
using MVC_CRUD_APP.Models;

namespace MVC_CRUD_APP.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult CreateUser(UserDto dto)
        { 
            var user = new User()
            {
                UserName = dto.UserName,
                Email = dto.Email,
                Password = dto.Password
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);

        }

        public IActionResult LoginUser(UserDto dto)
        {
            var user = _context.Users.Find(dto.Email);
            if(user==null)
            {
                return NotFound();
            }

            if(user.Email==dto.Email && user.Password==dto.Password)
            {
                Console.WriteLine("login sucessfull!");
                
            } else
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
