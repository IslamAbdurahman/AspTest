using AspTest.Data;
using AspTest.Data.Services;
using AspTest.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace AspTest.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    private readonly AspTestDbContext _context;

    public AuthController(JwtService jwtService, AspTestDbContext context)
    {
        _jwtService = jwtService;
        _context = context;
    }

    private string Md5Hash(string input)
    {
        using (var md5 = MD5.Create())
        {
            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == request.Username);
        if (user == null)
            return Unauthorized("Login yoki parol noto‘g‘ri");

        if (user.PasswordHash != Md5Hash(request.Password))
            return Unauthorized("Login yoki parol noto‘g‘ri");

        // 3️⃣ Token generatsiya qilish
        var token = _jwtService.GenerateToken(user.Username, user.Id);

        return Ok(new { Token = token });
    }
}
