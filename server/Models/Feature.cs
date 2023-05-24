using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Features")]
public class Feature
{
    [Key, Required]
    public int id { get; set; }
    [Required, Column("feature_title")]
    public string ? featureTitle { get; set; }
    [Required, Column("feature_value")]
    public string ? featureValue { get; set; }
}