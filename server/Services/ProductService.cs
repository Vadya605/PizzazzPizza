namespace server
{
    public class ProductService
    {
        private EF_DataContext _dataContext;
        public ProductService(EF_DataContext dataContext){
            _dataContext = dataContext;
        }

        public List<Product>? GetAllProducts(){
            List<Product>? allProducts = _dataContext.Products?.ToList();
            return allProducts;
        }

        public List<Product>? GetProductsByType(string productType){
            List<Product>? specificTypeProducts = _dataContext.Products?.Where( 
                product => product.productType.ToLower() == productType.ToLower() 
            ).ToList();

            return specificTypeProducts;
        }

        public Product? GetProductById(int productid){
            Product? specificIdProduct = _dataContext.Products?.Where(
                product => product.id == productid
            ).FirstOrDefault();
            return specificIdProduct;
        }

    }
}