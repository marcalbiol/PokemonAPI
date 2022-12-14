namespace Business_Logic_Layer.Models;

public class PokedexModel
{
    public int? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Altura { get; set; }
    public string? Peso { get; set; }
    public string? Imagen { get; set; }
    public List<TipoModel>? Tipos { get; set; }
    public RegionModel? Region { get; set; }
    public TierModel Tier { get; set; }
    public ZonaModel? Zonas { get; set; }
}

public class EditPokedexModel
{
    public int? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Altura { get; set; }
    public string? Peso { get; set; }
}

public class PokedexZonaModel
{
    public int? ZonaId { get; set; }
}