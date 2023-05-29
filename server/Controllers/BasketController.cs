using Microsoft.AspNetCore.Mvc;


namespace server.Controllers
{
    [ApiController]

    public class BasketController : ControllerBase
    {
        private readonly BasketService? _basketService;

        public BasketController(EF_DataContext dataContext){
            _basketService = new BasketService(dataContext, 1);
        }

        // добавить проверку id во все методы
        //заменить ok на правильный тип ответа в случае ошибки
        [HttpGet]
        [Route("api/[controller]/")]
        public IActionResult GetAll(){
            List<Product>? productsInBasket = _basketService.GetAllProductsInBasket();
            if(!productsInBasket.Any()){
                return Ok("Нет продуктов в корзине");
            }
            return Ok(productsInBasket);
        }

        [HttpPost]
        [Route("api/[controller]/add/")]
        //или просто принимать productId
        public IActionResult AddProductInBasket(Product product){
            bool isProductAdded = _basketService.AddProductInBasket(product.id);
            if(!isProductAdded){
                return Forbid("Значение не является допустимым для увеличения");
            }
            return Ok("Продукт добавлен в корзину");            
        }

        [HttpPut]
        [Route("api/[controller]/increase/")]
        //потому что приходит json а принимал только int
        public IActionResult IncreaseCountProductInBasket(Product product){
            Console.WriteLine(product.id);
            bool isIncreasedProductCount = _basketService.IncreaseCountProductInBasket(product.id);
            if(!isIncreasedProductCount){
                return Ok("Значение не является допустимым для увеличения");
            }
            return Ok("Значение увеличено");
        }

        [HttpPut]
        [Route("api/[controller]/decrease/")]
        public IActionResult DecreaseCountProductInBasket(Product product){
            bool isDecreasedProductCount = _basketService.DecreaseCountProductInBasket(product.id);
            if(!isDecreasedProductCount){
                return Ok("Значение не является допустимым для уменьшения");
            }
            return Ok("Значение уменьшено");
        }

        [HttpDelete]
        [Route("api/[controller]/delete/")]
        public IActionResult DeleteProductInBasket(Product product){
            bool isDecreasedProductCount = _basketService.RemoveProductInBasket(product.id);
            if(!isDecreasedProductCount){
                return Ok("Не найден продукт для удаления");
            }
            return Ok("Продукт удален");
        }

    }
}
