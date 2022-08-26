using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.GenericRepository
{
    public interface IGenericReadOnlyRepository<T>: IDisposable where T : class
    {
        List<T> GetAll();
        T GetById(object id);
    }
}
