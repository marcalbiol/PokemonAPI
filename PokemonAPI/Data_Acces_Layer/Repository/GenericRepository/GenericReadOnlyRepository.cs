using Data_Acces_Layer.Repository;
using Microsoft.EntityFrameworkCore;

namespace Acceso_BD.Repository.GenericRepository;

public class GenericReadOnlyRepository<T> : IGenericReadOnlyRepository<T> where T : class
{
    private readonly MyDbContext context;
    private readonly DbSet<T> table;

    public GenericReadOnlyRepository()
    {
        context = new MyDbContext();
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