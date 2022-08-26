using Data_Acces_Layer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.GenericRepository
{
    public class GenericReadOnlyRepository<T> : IGenericReadOnlyRepository<T> where T : class
    {
        private readonly MyDbContext context;
        private readonly DbSet<T> table = null;

        public GenericReadOnlyRepository()
        {
            this.context = new MyDbContext();
            table = context.Set<T>();
        }
        public GenericReadOnlyRepository(MyDbContext context, DbSet<T> table)
        {
            this.context = context;
            this.table = table;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
