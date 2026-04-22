using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SalesSystem.Context;

namespace SalesSystem.Repository
{
    public class Genericrepository<T> : IBaserepository<T> where T : class
    {
        private readonly AppDBContext context;
        private DbSet<T> dbSet;

        public Genericrepository(AppDBContext dBContext)
        {
            context = dBContext;

        }
        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public void ADD(T entity)
        {
            dbSet.Add(entity);
        }

        public T Getbyid(int id)
        {
            return dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
