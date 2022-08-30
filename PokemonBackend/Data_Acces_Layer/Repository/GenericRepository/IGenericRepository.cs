using Acceso_BD.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.GenericRepository
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        // METODOS CRUD ACCIONES
        List<T> GetAll(Pagination pagination);
        List<T> GetAllData();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
