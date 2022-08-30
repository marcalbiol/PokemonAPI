﻿using Acceso_BD.Repository.Entity;
using Data_Acces_Layer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MyDbContext context;
        private DbSet<T> table = null;
        private Pagination pagination;

        public GenericRepository()
        {

            this.context = new MyDbContext();
            table = context.Set<T>();
        }

        public GenericRepository(MyDbContext context, DbSet<T> table, Pagination pagination)
        {
            this.pagination = pagination;
            this.context = context;
            this.table = table;
        }

        public List<T> GetAll(Pagination pagination)
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
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
}