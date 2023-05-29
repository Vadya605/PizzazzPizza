using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("basket")]
public class Basket {
    [Key, Required, Column("id")]
    public int Id { get; set; }
    [Required, Column("user_id")]
    public int UserId { get; set; }
    [Required, Column("product_id")]
    public int ProductId { get; set; }
    [Required, Column("count_product")]
    public int CountProduct { get; set; }    
}