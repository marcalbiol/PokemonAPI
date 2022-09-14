using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase
{
        private MyDbContext db = new();
        private RegisterBll _BLL;

        public RegisterController()
        {
            _BLL = new RegisterBll();
        }

        [HttpPost]
        public void PostNewUser([FromBody] RegisterModel model)
        {
            _BLL.NewUser(model);
        }

}