using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("product_features")]
public class ProductFeature
{
    [Key, Required]
    public int id { get; set; }
    [Required, Column("feature_id")]
    public int featureId { get; set; }
    [Required, Column("product_id")]
    public int productId { get; set; }

}