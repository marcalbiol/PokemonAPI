using Acceso_BD.Repository.Entity;
using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XAct;

namespace PokemonBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public LoginBll _Bll;
        private MyDbContext db = new();

        public RegisterController()
        {
            _Bll = new LoginBll();
        }

        [HttpPost]
        public void Register(RegisterModel model)
        {
            _Bll.PostRegister(model);
        }
    }
}