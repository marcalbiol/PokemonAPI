using Acceso_BD.Repository.Entity;
using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using XAct;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase
{
    private readonly MyDbContext _db = new();
    public LoginBll _Bll;

    public RegisterController()
    {
        _Bll = new LoginBll();
    }


    [HttpGet]
    public List<RegisterModel> GetAllUsers()
    {
        return _Bll.GetAll();
    }

    [HttpPost]
    public void Register([FromBody] RegisterModel model)
    {
        _Bll.PostRegister(model);
    }

    [HttpPost("/Login")]
    public IActionResult Login(RegisterModel model)
    {
        var userFromDb = _db.Users.FirstOrDefault(u => u.Username == model.Username);
        var isPasswordMatched = LoginBll.VerifyPassword(model.Password, userFromDb.Salt, userFromDb.Password);

        if (isPasswordMatched)
        {
            return Ok("Login success");
        }

        return BadRequest("Password or user incorrect");
    }
}