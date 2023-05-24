using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("users")]
public class User {
    [Key, Required]
    public int id { get; set; }
    [Required, Column]
    public string ? name { get; set; }
    [Required]
    public string ? password { get; set; }
    [Required]
    public string? email { get; set; }
    [Required, Column("phone_number")]
    public string? phoneNumber { get; set; }
    [Column("day_birth")]
    public int? dayBirth { get; set; }
    [Column("month_birth")]
    public string? monthBirth { get; set; }
    [Required, Column("number_accumuleted_bonuses")]
    public int numberAccumuletedBonuses { get; set; }
}