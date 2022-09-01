namespace Acceso_BD.Repository.Entity;

public class Pagination
{
    private const int maxSize = 50;

    private int _pageSize = 10;
    public int Pagina { get; set; } = 1;

    public int TamañoPagina
    {
        get => _pageSize;
        set => _pageSize = value > maxSize ? maxSize : value;
    }
}