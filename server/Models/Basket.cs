using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("basket")]
public class Basket {
    [Key, Required]
    public int id { get; set; }
    [Required, Column("user_id")]
    public int userId { get; set; }
    [Required, Column("product_id")]
    public int product { get; set; }
    [Required, Column("count_product")]
    public int countProduct { get; set; }    
}