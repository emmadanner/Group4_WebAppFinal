﻿// <auto-generated />
using Group4_WebAppFinal.Controllers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Bag", b =>
                {
                    b.Property<string>("ItemName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ItemQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ItemType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ItemName");

                    b.ToTable("Bags");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Generation", b =>
                {
                    b.Property<int>("GenerationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenerationId"));

                    b.Property<string>("GenGames")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenerationId");

                    b.ToTable("Generations");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Pokemon", b =>
                {
                    b.Property<string>("PokemonName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DexNumber")
                        .HasColumnType("int");

                    b.Property<int>("GenerationId")
                        .HasColumnType("int");

                    b.Property<string>("Type1TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type2TypeName")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PokemonName");

                    b.HasIndex("GenerationId");

                    b.HasIndex("Type1TypeName");

                    b.HasIndex("Type2TypeName");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.PokemonType", b =>
                {
                    b.Property<string>("TypeName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TypeName");

                    b.ToTable("PokemonTypes");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"));

                    b.Property<string>("BagItemName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PokemonName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TeamId");

                    b.HasIndex("BagItemName");

                    b.HasIndex("PokemonName");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Pokemon", b =>
                {
                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.Generation", "Generation")
                        .WithMany()
                        .HasForeignKey("GenerationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.PokemonType", "Type1")
                        .WithMany()
                        .HasForeignKey("Type1TypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.PokemonType", "Type2")
                        .WithMany()
                        .HasForeignKey("Type2TypeName");

                    b.Navigation("Generation");

                    b.Navigation("Type1");

                    b.Navigation("Type2");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Team", b =>
                {
                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagItemName");

                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.Pokemon", "Pokemon")
                        .WithMany("Team")
                        .HasForeignKey("PokemonName");

                    b.Navigation("Bag");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Pokemon", b =>
                {
                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
