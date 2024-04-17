﻿// <auto-generated />
using System;
using Group4_WebAppFinal.Controllers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Group4_WebAppFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240417175940_AddedPokemonTeam")]
    partial class AddedPokemonTeam
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
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

                    b.Property<string>("PokemonName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GenerationId");

                    b.HasIndex("PokemonName");

                    b.ToTable("Generations");

                    b.HasData(
                        new
                        {
                            GenerationId = 1,
                            GenGames = "Red, Blue, Green, Yellow"
                        },
                        new
                        {
                            GenerationId = 2,
                            GenGames = "Gold, Silver, Crystal"
                        },
                        new
                        {
                            GenerationId = 3,
                            GenGames = "Ruby, Sapphire, Emerald, FireRed, LeafGreen"
                        },
                        new
                        {
                            GenerationId = 4,
                            GenGames = "Diamond, Pearl, Platinum, HeartGold, SoulSilver"
                        },
                        new
                        {
                            GenerationId = 5,
                            GenGames = "Black, White, Black 2, White 2"
                        },
                        new
                        {
                            GenerationId = 6,
                            GenGames = "X, Y, Omega Ruby, Alpha Sapphire"
                        },
                        new
                        {
                            GenerationId = 7,
                            GenGames = "Sun, Moon, Ultra Sun, Ultra Moon"
                        },
                        new
                        {
                            GenerationId = 8,
                            GenGames = "Sword, Shield, Brilliant Diamond, Shining Pearl"
                        },
                        new
                        {
                            GenerationId = 9,
                            GenGames = "Scarlet, Violet"
                        });
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Pokemon", b =>
                {
                    b.Property<string>("PokemonName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DexNumber")
                        .HasColumnType("int");

                    b.Property<int>("Generation")
                        .HasColumnType("int");

                    b.Property<int?>("TeamNum")
                        .HasColumnType("int");

                    b.Property<string>("Type1")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type2")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PokemonName");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            PokemonName = "Bulbasaur",
                            DexNumber = 1,
                            Generation = 1,
                            TeamNum = 1,
                            Type1 = "Grass",
                            Type2 = "Poison"
                        },
                        new
                        {
                            PokemonName = "Lileep",
                            DexNumber = 345,
                            Generation = 3,
                            Type1 = "Rock",
                            Type2 = "Grass"
                        });
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.PokemonType", b =>
                {
                    b.Property<string>("TypeName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PokemonName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TypeName");

                    b.HasIndex("PokemonName");

                    b.ToTable("PokemonTypes");

                    b.HasData(
                        new
                        {
                            TypeName = "Normal"
                        },
                        new
                        {
                            TypeName = "Fire"
                        },
                        new
                        {
                            TypeName = "Water"
                        },
                        new
                        {
                            TypeName = "Electric"
                        },
                        new
                        {
                            TypeName = "Grass"
                        },
                        new
                        {
                            TypeName = "Ice"
                        },
                        new
                        {
                            TypeName = "Fighting"
                        },
                        new
                        {
                            TypeName = "Poison"
                        },
                        new
                        {
                            TypeName = "Ground"
                        },
                        new
                        {
                            TypeName = "Flying"
                        },
                        new
                        {
                            TypeName = "Psychic"
                        },
                        new
                        {
                            TypeName = "Bug"
                        },
                        new
                        {
                            TypeName = "Rock"
                        },
                        new
                        {
                            TypeName = "Ghost"
                        },
                        new
                        {
                            TypeName = "Dragon"
                        },
                        new
                        {
                            TypeName = "Dark"
                        },
                        new
                        {
                            TypeName = "Steel"
                        },
                        new
                        {
                            TypeName = "Fairy"
                        });
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

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.Generation", b =>
                {
                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.Pokemon", null)
                        .WithMany("Generations")
                        .HasForeignKey("PokemonName");
                });

            modelBuilder.Entity("Group4_WebAppFinal.Controllers.Entities.PokemonType", b =>
                {
                    b.HasOne("Group4_WebAppFinal.Controllers.Entities.Pokemon", null)
                        .WithMany("PokemonTypes")
                        .HasForeignKey("PokemonName");
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
                    b.Navigation("Generations");

                    b.Navigation("PokemonTypes");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
