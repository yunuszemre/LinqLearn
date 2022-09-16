using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {

            new Product{ProductId=1,CategoryId=1,ProductName="Computer",UnitPrice=15000,UnitsInStock=10},
            new Product{ProductId=2,CategoryId=1,ProductName="Cup",UnitPrice=55,UnitsInStock=150},
            new Product{ProductId=2,CategoryId=2,ProductName="Phone",UnitPrice=8000,UnitsInStock=20},
            new Product{ProductId=3,CategoryId=2,ProductName="Keyboard",UnitPrice=450,UnitsInStock=5},
            new Product{ProductId=4,CategoryId=2,ProductName="Mouse",UnitPrice=550,UnitsInStock=2}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(t0 => t0.ProductId == product.ProductId);

            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            
            return _products.Where(t0 => t0.CategoryId == categoryId).ToList();
            
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(t0 => t0.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

            
        }
    }
}
