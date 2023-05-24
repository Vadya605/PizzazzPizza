using Microsoft.EntityFrameworkCore;
public class EF_DataContext: DbContext {
    public EF_DataContext(DbContextOptions < EF_DataContext > options): base(options) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.UseSerialColumns();
    }
    public DbSet <Addtive>? Additives { get; set; }
    public DbSet <BankCard>? BankCards { get; set; }
    public DbSet <Basket>? Baskets { get; set; }
    public DbSet <Feature>? Features { get; set; }
    public DbSet <OrderHistory>? OrderHistories { get; set; }
    public DbSet <Product>? Products { get; set; }
    public DbSet <ProductFeature>? ProductFeatures { get; set; }
    public DbSet <TypeProduct>? TypesProduct { get; set; }
    public DbSet <User>? Users { get; set; }
    public DbSet <Ingredient>? Ingredients { get; set; }
    public DbSet <ProductIngredient>? ProductIngredients { get; set; }



}