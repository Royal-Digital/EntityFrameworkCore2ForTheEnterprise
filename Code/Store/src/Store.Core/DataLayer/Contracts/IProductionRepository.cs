using System.Collections.Generic;
using Store.Core.EntityLayer.Production;

namespace Store.Core.DataLayer.Contracts
{
    public interface IProductionRepository
	{
		IEnumerable<Product> GetProducts();

		Product GetProduct(Product entity);

		void AddProduct(Product entity);

		void UpdateProduct(Product changes);

		void DeleteProduct(Product entity);
	}
}
