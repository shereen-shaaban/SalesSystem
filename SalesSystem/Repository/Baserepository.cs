using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSystem.Repository
{
    public interface IBaserepository<T>
	{
			List<T> GetAll();
			T Getbyid(int id);
			void ADD(T entity);
			void Remove(T entity);
			void Update(T entity);

		void SaveChanges();

	}
}
