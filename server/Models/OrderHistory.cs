using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("order_history")]
public class OrderHistory
{
    [Key, Required]
    public int id { get; set; }
    [Required, Column("date_order")]
    public DateOnly? dateOrder {get; set;}
    [Required, Column("user_id")]
    public int userId { get; set; }
    [Required, Column("product_id")]
    public int productId { get; set; }
}