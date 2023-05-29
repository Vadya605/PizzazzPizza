using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("products")]
public class Product {
    [Key, Required]
    public int id { get; set; }
    [Required]
    [Column("product_title")]
    public string ? productTitle { get; set; }
    [Required]
    [Column("product_price")]
    public decimal productPrice { get; set; }
    [Required]
    [Column("product_type")]
    public string? productType { get; set; }

    public List<ProductIngredient>? productIngredients 
    { 
        get;
        set; 
    }
    public List<Feature>? productFeatures { get; set; }

    
}