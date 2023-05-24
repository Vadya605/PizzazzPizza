using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("additives")]
public class Addtive
{
    [Key, Required]
    public int id { get; set; }
    [Required, Column("additive_title")]
    public string? additiveTitle { get; set; }
    [Required, Column("additive_price")]
    public decimal additivePrice { get; set; }
    [Required, Column("product_id")]
    public int productId { get; set; }
}