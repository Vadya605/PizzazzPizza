using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ingredient
{
    [Key, Required]
    public int id { get; set; }
    [Required, Column("ingredient_title")]
    public string? ingredientTitle { get; set; }
}