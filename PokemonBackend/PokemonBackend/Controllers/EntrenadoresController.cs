using Acceso_BD.Repository.Entity;
using Business_Logic_Layer;
using Business_Logic_Layer.Models;
using Data_Acces_Layer.Repository;
using Microsoft.AspNetCore.Mvc;
using PokemonBackend.Models;

namespace PokemonBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EntrenadorController : ControllerBase
{
    public EntrenadorBLL _BLL;
    private MyDbContext db = new();


    public EntrenadorController()
    {
        _BLL = new EntrenadorBLL();
    }

    [HttpGet]
    public List<EntrenadorModel> GetEntrenadors([FromQuery] Pagination pagination)
    {
        return _BLL.GetEntrenador(pagination);
    }

    [HttpPost]
    public void PostEntrenador([FromBody] EntrenadorModel entrenadorModel)
    {
        // en el controlador llamamos a los metodos de la logica de negocio
        _BLL.PostEntrenador(entrenadorModel);
    }

    [HttpPut]
    public void PutEntrenador(int id, EntrenadorModel entrenadorModel)
    {
        _BLL.PutEntrenador(id, entrenadorModel);
    }

    [HttpDelete("{id}")]
    public Entrenador DeleteEntrenadorById(int id)
    {
        return _BLL.DeleteEntrenadorById(id);
    }
}