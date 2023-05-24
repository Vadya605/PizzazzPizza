using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("product_ingredients")]
public class ProductIngredient
{
    [Key, Required]
    public int id {get; set;}
    [Required,Column("ingredient_title")]
    public string? ingredientTitle { get; set; }

    [Required,Column("product_id")]
    public int productId { get; set; }
}