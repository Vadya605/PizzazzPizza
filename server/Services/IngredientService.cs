

public class IngredientService
{
    private EF_DataContext _dataContext;

    public IngredientService (EF_DataContext dataContext){
        _dataContext = dataContext;
    }

    public List<ProductIngredient>? GetIngredientsProduct(int product_id){
        List<ProductIngredient>? ingredientsProduct = _dataContext.ProductIngredients?.Where(
            ingredient => ingredient.productId == product_id
        ).ToList();

        return ingredientsProduct.Any()? ingredientsProduct : null;
        // return ingredientsProduct;
        //а какая разница вернется null или пустой массив, если это соус
    }


}