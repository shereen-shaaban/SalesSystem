using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Repository;

namespace SalesSystem.Services
{
    public class GenericServices<T> : IBaseService<T> where T : class
    {
        private readonly IBaserepository<T> repo;
        public GenericServices(IBaserepository<T> repository)
        {
            this.repo = repository;
		}   
		public void ADD(T entity)
        {
            repo.ADD(entity);
            repo.SaveChanges();
			Console.WriteLine("Entity added successfully.");
		}

        public T Getbyid(int id)
        {
            var t=repo.Getbyid(id);
            if(t!=null)
                return t;
            else
                return null;
		}

        public List<T> GetAll()
        {
           if(repo.GetAll().Count>0)
                return repo.GetAll();
            else
                return null;
		}

        public void Remove(int id)
        {
            var t = repo.Getbyid(id);
            if (t != null)
            {
                repo.Remove(t);
                repo.SaveChanges();
                Console.WriteLine("Entity removed successfully.");
            }
            else
            {
                Console.WriteLine("Entity not found.");
            }
        }
		public void Update(int id)
        {
            var t= repo.Getbyid(id);
            if (t != null)
            {
                repo.Update(t);
                repo.SaveChanges();
                Console.WriteLine("Entity updated successfully.");
            }
            else
            {
                Console.WriteLine("Entity not found.");
            }
		}
    }
}
