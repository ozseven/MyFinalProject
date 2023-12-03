using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
            new Product {CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},

            new Product { CategoryId = 1, ProductId = 5, ProductName = "telefon", UnitPrice = 15, UnitsInStock = 15 },

            new Product { CategoryId = 2, ProductId = 2, ProductName = "Tabak", UnitPrice = 10, UnitsInStock = 20 },


            new Product { CategoryId = 1, ProductId = 3, ProductName = "Çatal", UnitPrice = 5, UnitsInStock = 30 },

            new Product { CategoryId = 2, ProductId = 4, ProductName = "Kaşık", UnitPrice = 8, UnitsInStock = 25 },


        };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;

            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> getAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate;
            productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate = product;
        }
    }
}
