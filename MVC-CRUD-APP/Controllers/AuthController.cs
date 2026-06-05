using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MVC_CRUD_APP.Data;
using MVC_CRUD_APP.Dto;
using MVC_CRUD_APP.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        public async Task<IActionResult> CreateUser(UserDto dto)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (existingUser != null)
            {
                ViewBag.ErrorMessage = "User Already registered!";
                return RedirectToAction("Login");
            } else
            {
                if (string.IsNullOrEmpty(dto.UserName)|| string.IsNullOrEmpty(dto.Password) || string.IsNullOrEmpty(dto.Email))
                {
                    ViewBag.ErrorMessage = "Required Field cannot be Emply!";
                    return View("Register");
                }
                var user = new User()
                {
                    UserName = dto.UserName,
                    Email = dto.Email,
                    Password = dto.Password
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }

            TempData["SuccessMessage"] = "User Registered Successfully Plase login...";
            return RedirectToAction("Login");
        }

        public async Task<IActionResult> LoginUser(UserDto dto)
        {
            if (string.IsNullOrEmpty(dto.Email) || string.IsNullOrEmpty(dto.Password))
            {
                ViewBag.ErrorMessage = "Required filed cannot be empty!";
                return View("Login");
            }
            var existUser = await _context.Users.FirstOrDefaultAsync(user => user.Email == dto.Email);

            if(existUser == null)
            {
                ViewBag.ErrorMessage = "User not found!";
                return View("Login");
            } 
            else if(existUser.Password != dto.Password)
            {
                ViewBag.ErrorMessage = "Wrong Password!";
                return View("Login");
            }

            TempData["SuccessMessage"] = "Login Successfully!";
            var token = GenerateJwtToken(dto);

            Response.Cookies.Append("jwt_key", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddMinutes(30)
            });

            return RedirectToAction("Index", "Dashboard");
        }
        private string GenerateJwtToken(UserDto dto)
        {
            var jwtHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("d71135625ba80acd4999906df3647197ed9c483aed91f206834745e6ce1a0a77");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, dto.Email),
                     
                }),

                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256),
            };
            var token = jwtHandler.CreateToken(tokenDescriptor);

            return jwtHandler.WriteToken(token);
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt_key");
            return RedirectToAction("Login");
        }
    }
}
