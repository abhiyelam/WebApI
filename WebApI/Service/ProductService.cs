using WebApI.Model;
using WebApI.Repository;

namespace WebApI.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repo) 
        { 
            this.repo = repo;
        }
        public int AddProduct(Product product)
        {
            return repo.AddProduct(product);
        }

        public int DeleteProduct(int id)
        {
           return repo.DeleteProduct(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public int UpdateProduct(Product product)
        {
            return repo.UpdateProduct(product);
        }
    }
}
