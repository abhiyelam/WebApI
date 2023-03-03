using WebApI.Model;

namespace WebApI.Service
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProductById(int id);
        public int AddProduct(Product product);
        public int UpdateProduct(Product product);
        public int DeleteProduct(int id);

    }
}
