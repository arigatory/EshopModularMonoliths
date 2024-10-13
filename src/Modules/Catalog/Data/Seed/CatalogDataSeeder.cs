namespace Catalog.Data.Seed;

public class CatalogDataSeeder(CatalogDbContext dbContext) : IDataSeeder
{
    public async Task SeedAllAsync()
    {
        await dbContext.Products.AddRangeAsync(InitialData.Products);
        await dbContext.SaveChangesAsync();
    }
}
