﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ecommerce.Server.Data;

#nullable disable

namespace ecommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ecommerce.Shared.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                            ImageUrl = "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                            Price = 275m,
                            Title = "Kayak"
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                            ImageUrl = "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                            Price = 48.95m,
                            Title = "Life jacket"
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                            ImageUrl = "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                            Price = 19.50m,
                            Title = "Soccer ball"
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "I'm baby twee hella enamel pin aesthetic pork belly. Blackbird spyplane taiyaki four dollar toast fixie, tumeric godard poutine jawn put a bird on it man bun fanny pack cold-pressed. Ascot VHS distillery banjo succulents health goth celiac sartorial meditation lumbersexual live-edge paleo. Deep v bitters letterpress activated charcoal butcher af whatever taxidermy salvia chartreuse.",
                            ImageUrl = "https://images.unsplash.com/photo-1526779259212-939e64788e3c?w=500&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8ZnJlZSUyMGltYWdlc3xlbnwwfHwwfHx8MA%3D%3D",
                            Price = 34.95m,
                            Title = "Corner flag"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}