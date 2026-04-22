using System;
using System.Collections.Generic;
using System.Text;
using SalesSystem.Models;

namespace SalesSystem.Services
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        T Getbyid(int id);
        void ADD(T entity);
        void Remove(int id);
        void Update(int id);

        

	}

	public class ProductLineBuilder
	{
		private ProductLine productline = new ProductLine();

		public ProductLineBuilder SetText(string Name)
		{
			productline.DescLNText = Name;
			return this;
		}

		public ProductLineBuilder Sethtml(string desc)
		{
			productline.DescLNHtml = desc;
			return this;
		}
		public ProductLineBuilder Setimage(string image)
		{
			productline.Image = image;
			return this;
		}

		public ProductLine Build()
		{
			return productline;
		}

	}
}
