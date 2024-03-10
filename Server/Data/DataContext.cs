namespace ecommerce.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Title = "Kayak",
                ImageUrl =
                    "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                Description =
                    "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                Price = 275M
            },
            new Product
            {
                ProductId = 2,
                Title = "Life jacket",
                ImageUrl =
                    "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                Description =
                    "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                Price = 48.95M
            },
            new Product
            {
                ProductId = 3,
                Title = "Soccer ball",
                ImageUrl =
                    "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                Description =
                    "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                Price = 19.50M
            },
            new Product
            {
                ProductId = 4,
                Title = "Corner flag",
                ImageUrl =
                    "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                Description =
                    "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                Price = 34.95M
            }
        );
    }


    public DbSet<Product> Products { get; set; }
}