using Acceso_BD.Repository.Entity;

namespace Acceso_BD.Repository.GenericRepository;

public interface IGenericRepository<T> : IDisposable where T : class
{
    // METODOS CRUD ACCIONES
    List<T> GetAllPag(Pagination pagination);
    List<T> GetAllData();
    T GetById(object id);
    void Insert(T obj);
    void Update(T obj);
    void Delete(object id);
    void Save();
}