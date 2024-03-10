using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.", "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D", 275m, "Kayak" },
                    { 2, "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.", "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D", 48.95m, "Life jacket" },
                    { 3, "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.", "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D", 19.50m, "Soccer ball" },
                    { 4, "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.", "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D", 34.95m, "Corner flag" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
