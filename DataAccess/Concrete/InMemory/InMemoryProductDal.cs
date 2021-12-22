using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitsInStock=15, UnitPrice=15},
            new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitsInStock=500, UnitPrice=3},
            new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitsInStock=1500, UnitPrice=2},
            new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitsInStock=150, UnitPrice=65},
            new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitsInStock=80, UnitPrice=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //product id - ye gore silinecek mehsulun tapilmasi
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            //silinecek olan mehsulun tapildiqdan sonra silinmesi
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //product id - ye gore duzeldilecek mehsulun tapilmasi
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            //duzeldilecek mehsulun tapildiqdan sonra tek-tek duzeldilmesi
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
