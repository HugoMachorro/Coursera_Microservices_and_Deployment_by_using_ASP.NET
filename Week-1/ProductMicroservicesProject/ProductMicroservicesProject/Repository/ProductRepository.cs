using Microsoft.EntityFrameworkCore;
using ProductMicroservicesProject.Models;

namespace ProductMicroservicesProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            _context.Products.Remove(product);
            Save();
        }

        public Product GetProductById(int productid)
        {
            return _context.Products.Find(productid);

        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _context.Add(product);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            Save();
        }
    }
}
