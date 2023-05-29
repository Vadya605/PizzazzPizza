//можно инициализировать продукт сразу здесь
//
//
public class BasketService
{
    private EF_DataContext _dataContext;
    private int _userId;
    // private int _productId;
    // private bool _isExistingProductInBasket;
    //скорее всего изменится на productBasketId, будет отдельная таблица

    public BasketService(EF_DataContext dataContext, int userId){
        _dataContext = dataContext;
        _userId = userId;
        // _productId = productId;
        // _isExistingProductInBasket = GetProductInBasket() == null;
    }

    public  List<Product>? GetAllProductsInBasket(){
        // List<Basket>? allProductsInBasket = _dataContext.Baskets?.Where( basket => 
        //     basket.UserId == this._userId
        // ).ToList(); 

        List<Product>? allProductsInBasket = _dataContext.Baskets?.Where(
            b => b.UserId == this._userId
        ).Join(_dataContext.Products, 
            b => b.ProductId,
            p => p.id,
            (b, p) => new Product{
                id = p.id,
                productTitle = p.productTitle,
                productPrice = p.productPrice,
                productType = p.productType
            }
        ).ToList();

        return allProductsInBasket;
    }

    private Basket? GetProductInBasket(int productId){
        Basket? productInBasket = _dataContext.Baskets?.Where( basket => 
            basket.UserId == this._userId && basket.ProductId == productId 
        ).FirstOrDefault();
        return productInBasket;
    }

    public bool AddProductInBasket(int productId, int countProduct=1){
        bool isExistingProductInBasket = GetProductInBasket(productId) != null;
        if(isExistingProductInBasket){
            return IncreaseCountProductInBasket(productId);
        }
        var newBasket = new Basket{
            ProductId = productId,
            UserId = this._userId,
            CountProduct = countProduct
        };
        _dataContext.Baskets.Add(newBasket);
        _dataContext.SaveChanges();
        return true;
    }

    public bool IncreaseCountProductInBasket(int productId){
        Console.WriteLine(productId);
        Basket? productInBasket = GetProductInBasket(productId);
        if(productInBasket == null){
            Console.WriteLine("not");
            return false;
        }
        return ChangeCountProductInbasket(productInBasket, 99, 1);  
    }

    private bool ChangeCountProductInbasket(Basket productInBasket, int acceptableCountProduct, int valueChange){
        if(acceptableCountProduct==productInBasket.CountProduct){
            return false;
        }
        productInBasket.CountProduct+=valueChange;
        _dataContext.SaveChanges();
        return true;
    }

    public bool DecreaseCountProductInBasket(int productId){
        Basket? productInBasket = GetProductInBasket(productId);
        if(productInBasket == null){
            return false;
        }
        return ChangeCountProductInbasket(productInBasket, 1, -1);
    }

    public bool RemoveProductInBasket(int productId){
        Basket? productInBasket = GetProductInBasket(productId);
        if(productInBasket == null){
            return false;
        }
        _dataContext.Baskets?.Remove(productInBasket);
        _dataContext.SaveChanges();
        return true;
    }
}