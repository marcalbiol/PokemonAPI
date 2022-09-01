namespace Business_Logic_Layer.Models;

public class PokemonModel
{
    // aqui se puede modificar, no se sobreescribe cuando se cambia
    public int? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Tipo { get; set; }
    public string? Imagen { get; set; }
}