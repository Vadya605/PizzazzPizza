using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ingredients")]
public class Ingredient
{
    [Key, Required]
    public int id { get; set; }
    [Required, Column("ingredient_title")]
    public string? ingredientTitle { get; set; }
}