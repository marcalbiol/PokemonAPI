using Acceso_BD.Repository.Entity;
using Data_Acces_Layer.Repository;
using Microsoft.EntityFrameworkCore;

namespace Acceso_BD.Repository.GenericRepository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly MyDbContext context;
    private readonly DbSet<T> table;
    private Pagination pagination;

    public GenericRepository()
    {
        context = new MyDbContext();
        table = context.Set<T>();
    }

    public GenericRepository(MyDbContext context, DbSet<T> table, Pagination pagination)
    {
        this.pagination = pagination;
        this.context = context;
        this.table = table;
    }

    public List<T> GetByPag(Pagination pagination)
    {
        return table.ToList();
    }

    public List<T> GetAllData()
    {
        return table.ToList();
    }

    public T GetById(object id)
    {
        return table.Find(id);
    }

    public List<T> GetByName(string name)
    {
        return table.ToList();
    }


    public void Delete(object id)
    {
        var existing = table.Find(id);
        table.Remove(existing);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Insert(T obj)
    {
        context.Add(obj);
        context.SaveChanges();
    }

    public void Update(T obj)
    {
        table.Attach(obj);
        context.Entry(obj).State = EntityState.Modified;
        context.SaveChanges();
    }

    public void Save()
    {
        context.SaveChanges();
    }
}