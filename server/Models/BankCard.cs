using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("banck_cards")]
public class BankCard
{
    [Key, Required]
    public int id {get; set;}
    [Required, Column("number_bank_card")]
    public int numberBanckCard {get; set;}
    [Required, Column("expiration_date_bank_card")]
    public string? expirationDateBankCard {get; set;}
    [Required]
    public string? cvv {get; set;}
    [Required, Column("user_id")]
    public int userId {get; set;}
}