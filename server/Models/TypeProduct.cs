using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("types_product")]
public class TypeProduct
{
    [Key, Required]
    public int id {get; set;}
    [Required, Column("type_title")]
    public string? typeTitle { get; set; }

}